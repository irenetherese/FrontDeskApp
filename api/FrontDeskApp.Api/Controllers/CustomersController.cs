using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using FrontDeskApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FrontDeskApp.Api.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Gets a list of customers
        /// </summary>
        /// <param name="request"></param>
        /// <returns>A list of customers</returns>
        [HttpGet]
        [Route("")]
        public Task<GetCustomersResponse> GetCustomersAsync([FromQuery] GetCustomersRequest request) => _customerService.GetCustomersAsync(request);

        /// <summary>
        /// Creates a new customer
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Customer id of newly created customer</returns>
        [HttpPost]
        [Route("create")]
        public Task<CreateCustomerResponse> CreateCustomerAsync([FromBody] CreateCustomerRequest request) => _customerService.CreateCustomerAsync(request);

        /// <summary>
        /// Gets a customer
        /// </summary>
        /// <param name="customer_id"></param>
        /// <returns>One customer</returns>
        [HttpGet]
        [Route("{customer_id}")]
        public Task<GetCustomerResponse> GetCustomerAsync(int customer_id) => _customerService.GetCustomerAsync(customer_id);


        /// <summary>
        /// Update customer information
        /// </summary>
        /// <param name="customer_id"></param>
        /// <param name="request"></param>
        /// <returns>An empty response</returns>
        [Route("{customer_id}/update")]
        [HttpPost]
        public Task<UpdateCustomerResponse> UpdateCustomerAsync([FromBody] UpdateCustomerRequest request, int customer_id) => _customerService.UpdateCustomerAsync(customer_id, request);
    }
}
