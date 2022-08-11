namespace FrontDeskApp.Requests
{
    public class UpdateCustomerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public dynamic Data { get; set; }
    }
}