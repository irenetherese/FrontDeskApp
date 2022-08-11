using System;

namespace FrontDeskApp.ViewModels
{
    public class RecordViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string BoxType { get; set; }
        public string Status {get; set;}
        public DateTime CreatedOn { get; set; }
        public DateTime? StoredOn { get; set; }
        public DateTime? RetrievedOn { get; set; }
    }
}