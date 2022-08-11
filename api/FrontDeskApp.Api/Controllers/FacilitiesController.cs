using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using FrontDeskApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrontDeskApp.Api.Controllers
{
    [ApiController]
    [Route("api/facilities")]
    public class FacilitiesController : Controller
    {
        private readonly IFacilityService _facilityService;

        public FacilitiesController(IFacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        /// <summary>
        /// Get a list of facilities
        /// </summary>
        /// <returns>A list of facilities</returns>
        [Route("")]
        [HttpGet]
        public Task<GetFacilitiesResponse> GetFacilitiesAsync([FromQuery] GetFacilitiesRequest request) => _facilityService.GetFacilitiesAsync(request);

        /// <summary>
        /// Gets a facility
        /// </summary>
        /// <param name="facility_id"></param>
        /// <returns>One facility</returns>
        [HttpGet]
        [Route("{facility_id}")]
        public Task<GetFacilityResponse> GetFacilityAsync(int facility_id) => _facilityService.GetFacilityAsync(facility_id);

    }
}
