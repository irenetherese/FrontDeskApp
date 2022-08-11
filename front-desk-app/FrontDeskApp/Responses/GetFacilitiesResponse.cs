using System.Collections.Generic;
using FrontDeskApp.ViewModels;

namespace FrontDeskApp.Responses
{
    public class GetFacilitiesResponse
    {
        public IEnumerable<FacilityViewModel> Facilities { get; set; }
    }
}