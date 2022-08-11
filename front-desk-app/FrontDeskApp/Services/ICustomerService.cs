using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using System.Threading.Tasks;

namespace FrontDeskApp.Services
{
    public interface ICustomerService
    {
        Task<GetCustomerResponse> GetCustomerAsync(int customerId);
        Task<GetCustomersResponse> GetCustomersAsync(GetCustomersRequest request);
        Task<CreateCustomerResponse> CreateCustomerAsync(CreateCustomerRequest request);
        Task<UpdateCustomerResponse> UpdateCustomerAsync(int customerId, UpdateCustomerRequest request);
    }
}