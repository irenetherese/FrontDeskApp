using FrontDeskApp.Common.Models;
using FrontDeskApp.Common.ViewModels;

namespace FrontDeskApp.App.Services
{
    public interface IFrontDeskApiClient
    {
        public Task<IEnumerable<CustomerViewModel>> GetCustomers();
        public Task<CustomerViewModel> GetCustomer(int id);
        public Task<bool> CreateCustomer(Customer customer);
        public Task<bool> UpdateCustomer(Customer customer);

        public Task<IEnumerable<FacilityViewModel>> GetFacilities();
        public Task<FacilityViewModel> GetFacility(int id);


        public Task<IEnumerable<RecordViewModel>> GetRecords();
        public Task<RecordViewModel> GetRecord(int id);
        public Task<bool> CreateRecord(Record record);
        public Task<bool> UpdateRecord(Record record);
    }
}