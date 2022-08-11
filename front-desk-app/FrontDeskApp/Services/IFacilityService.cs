using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using System.Threading.Tasks;

namespace FrontDeskApp.Services
{
    public interface IFacilityService
    {
        Task<GetFacilitiesResponse> GetFacilitiesAsync(GetFacilitiesRequest request);
        Task<GetFacilityResponse> GetFacilityAsync(int facility_id);
    }
}
