using System.Collections.Generic;
using FrontDeskApp.Common.ViewModels;

namespace FrontDeskApp.Common.Responses
{
    public class GetCustomersResponse
    {
        public IEnumerable<CustomerViewModel> Customers { get; set; }
    }
}