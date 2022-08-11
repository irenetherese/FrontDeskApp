using System;
using FrontDeskApp.Models;

namespace FrontDeskApp.Requests
{
    public class UpdateRecordRequest
    {
        public int CustomerId { get; set; }
        public int FacilityId { get; set; }
        public BoxType BoxType { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime? StoredOnUtc { get; set; }
        public DateTime? RetrievedOnUtc { get; set; }
    }
}