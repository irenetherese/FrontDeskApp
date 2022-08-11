using FrontDeskApp.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using FrontDeskApp.ViewModels;
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

            var viewModel = new FacilityViewModel
            {

            };


            var response = new GetFacilityResponse
            {
                Facility = viewModel
            };

            return response;
        }
    }
}
