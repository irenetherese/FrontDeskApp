using System.Collections.Generic;

namespace FrontDeskApp.Models
{
    public class FacilityStorageInfo
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public BoxType BoxType { get; set; }
        public int Capacity { get; set; }
    }
}
