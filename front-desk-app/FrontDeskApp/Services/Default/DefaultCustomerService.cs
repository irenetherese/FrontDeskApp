using FrontDeskApp.Common.Models;
using FrontDeskApp.Repositories;
using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using FrontDeskApp.Common.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Transactions;

namespace FrontDeskApp.Services.Default
{
    public class DefaultCustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public DefaultCustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<GetCustomersResponse> GetCustomersAsync(GetCustomersRequest request)
        {
            var customers = await _customerRepository.GetAsync();
            var viewModels = customers.Select(v => new CustomerViewModel
            {
                Id = v.Id,
                FirstName = v.FirstName,
                LastName = v.LastName,
                PhoneNumber = v.PhoneNumber,
                Data = JsonSerializer.Deserialize<object>(v.Data)
            });

            var response = new GetCustomersResponse
            {
                Customers = viewModels
            };

            return response;
        }

        public async Task<GetCustomerResponse> GetCustomerAsync(int customerId)
        {
            var customer = await _customerRepository.GetAsync(customerId);
            var viewModel = new CustomerViewModel
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                Data = JsonSerializer.Deserialize<object>(customer.Data)
            };

            var response = new GetCustomerResponse
            {
                Customer = viewModel
            };

            return response;
        }

        public async Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request)
        {
            var customer = new Customer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Data = JsonSerializer.Serialize(request.Data)
            };

            var id = await _customerRepository.CreateAsync(customer);

            return new CreateCustomerResponse
            {
                Id = id
            };
        }

        public async Task<UpdateCustomerResponse> UpdateCustomerAsync(int customerId, UpdateCustomerRequest request)
        {
            var customer = new Customer
            {
                Id = customerId,
                FirstName = request.FirstName,
                LastName = request.LastName,
                PhoneNumber = request.PhoneNumber,
                Data = JsonSerializer.Serialize(request.Data)
            };

            await _customerRepository.UpdateAsync(customer);
            return new UpdateCustomerResponse
            {

            };
        }
    }
}
