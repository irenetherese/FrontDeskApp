namespace FrontDeskApp.Common.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int FacilityId { get; set; }
        public Facility Facility { get; set; }
        public BoxType BoxType { get; set; }
        public Status Status {get; set;}
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? StoredOnUtc { get; set; }
        public DateTime? RetrievedOnUtc { get; set; }
        public string Data { get; set; }
    }
}
