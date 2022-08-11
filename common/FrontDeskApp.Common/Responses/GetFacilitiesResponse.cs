using System.Collections.Generic;
using FrontDeskApp.Common.ViewModels;

namespace FrontDeskApp.Common.Responses
{
    public class GetFacilitiesResponse
    {
        public IEnumerable<FacilityViewModel> Facilities { get; set; }
    }
}