using FrontDeskApp.Common.Models;

namespace FrontDeskApp.Common.ViewModels
{
    public class FacilityWithStorageInfoViewModel : FacilityViewModel
    {
        public IEnumerable<FacilityStorageInfo> FacilityStorageInfo { get; set; }
        public IEnumerable<CurrentStorageInfo> CurrentStorageInfo { get; set; }
    }
}