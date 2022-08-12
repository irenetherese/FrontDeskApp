using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FrontDeskApp.Common.Models
{
    public class FacilityStorageInfo
    {
        public int Id { get; set; }
        public int FacilityId { get; set; }
        public BoxType BoxType { get; set; }
        public int Capacity { get; set; }
    }
}
