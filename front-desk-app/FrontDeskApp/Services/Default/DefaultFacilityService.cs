using FrontDeskApp.Common.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using FrontDeskApp.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace FrontDeskApp.Services.Default
{
    public class DefaultFacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;
        private readonly IFacilityStorageInfoRepository _facilityStorageInfoRepository;

        public DefaultFacilityService(IFacilityRepository facilityRepository, IFacilityStorageInfoRepository facilityStorageInfoRepository)
        {
            _facilityRepository = facilityRepository;
            _facilityStorageInfoRepository = facilityStorageInfoRepository;
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

            var viewModel = new FacilityWithStorageInfoViewModel
            {
                Id = facility.Id,
                Name = facility.Name,
                FacilityStorageInfo = facilityStorageInfo
            };


            var response = new GetFacilityResponse
            {
                Facility = viewModel
            };

            return response;
        }
    }
}
