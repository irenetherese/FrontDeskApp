using System.Collections.Generic;
using FrontDeskApp.ViewModels;

namespace FrontDeskApp.Responses
{
    public class GetCustomersResponse
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }
    }
}