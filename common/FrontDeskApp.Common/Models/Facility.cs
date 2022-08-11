using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontDeskApp.Common.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("FacilityId")]
        public virtual ICollection<FacilityStorageInfo> FacilityStorageInfo{ get; set; }
    }
}
