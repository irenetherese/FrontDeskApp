namespace FrontDeskApp.Common.Requests
{
    public class CreateCustomerRequest
    {
        public dynamic Data { get; set; }
        public string PhoneNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}