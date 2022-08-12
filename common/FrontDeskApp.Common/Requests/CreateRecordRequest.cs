using System;
using FrontDeskApp.Common.Models;

namespace FrontDeskApp.Common.Requests
{
    public class CreateRecordRequest
    {
        public DateTime CreatedOnUtc { get; set; }
        public Status Status { get; set; }
        public BoxType BoxType { get; set; }
        public int FacilityId { get; set; }
        public int CustomerId { get; set; }
        public string Data { get; set; }
    }
}