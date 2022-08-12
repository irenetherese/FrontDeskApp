using FrontDeskApp.Common.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using FrontDeskApp.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using System;

namespace FrontDeskApp.Services.Default
{
    public class DefaultFacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;
        private readonly IFacilityStorageInfoRepository _facilityStorageInfoRepository;
        private readonly IRecordRepository _recordRepository;

        public DefaultFacilityService(IFacilityRepository facilityRepository, IFacilityStorageInfoRepository facilityStorageInfoRepository, IRecordRepository recordRepository)
        {
            _facilityRepository = facilityRepository;
            _facilityStorageInfoRepository = facilityStorageInfoRepository;
            _recordRepository = recordRepository;
        }

        public async Task<GetFacilitiesResponse> GetFacilitiesAsync(GetFacilitiesRequest request)
        {
            var facilities = await _facilityRepository.GetAsync();
            var viewModels = facilities.Select(v => new FacilityViewModel
            {
                Id = v.Id,
                Name = v.Name
            });

            var response = new GetFacilitiesResponse
            {
                Facilities = viewModels
            };

            return response;
        }

        public async Task<GetFacilityResponse> GetFacilityAsync(int facilityId)
        {
            var facility = await _facilityRepository.GetAsync(facilityId);
            var facilityStorageInfo = await _facilityStorageInfoRepository.GetAsync(facilityId);

            var currentStorage = await GetCurrentStorageInfo(facilityId);

            var viewModel = new FacilityWithStorageInfoViewModel
            {
                Id = facility.Id,
                Name = facility.Name,
                FacilityStorageInfo = facilityStorageInfo,
                CurrentStorageInfo = currentStorage
            };


            var response = new GetFacilityResponse
            {
                Facility = viewModel
            };

            return response;
        }

        private async Task<IEnumerable<CurrentStorageInfo>> GetCurrentStorageInfo(int facilityId)
        {
            var currentStorageInfo = new List<CurrentStorageInfo>();

            foreach (var boxType in Enum.GetValues(typeof(BoxType)).Cast<BoxType>().ToList())
            {
                var records = await _recordRepository.GetAsync(
                r => r.FacilityId == facilityId
                && (r.Status == Status.Stored || r.Status == Status.Reserved || r.Status == Status.New)
                && r.BoxType == boxType);

                currentStorageInfo.Add(new CurrentStorageInfo()
                {
                    BoxType = boxType,
                    Quantity = records.Count()
                });
            }

            return currentStorageInfo;
        }
    }
}
