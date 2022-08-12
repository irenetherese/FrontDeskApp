using System.Text;
using System.Text.Json;
using FrontDeskApp.Common.Models;
using FrontDeskApp.Common.Requests;
using FrontDeskApp.Common.Responses;
using FrontDeskApp.Common.ViewModels;
using Newtonsoft.Json;

namespace FrontDeskApp.App.Services
{
    public class FrontDeskApiClient : IFrontDeskApiClient
    {
        private HttpClient _httpClient; 

        public FrontDeskApiClient(FrontDeskAppApiSettings settings)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(settings.Url);
        }

        public async Task<bool> CreateCustomer(Customer customer)
        {
            var request = new CreateCustomerRequest() {
                Data = customer.Data,
                PhoneNumber = customer.PhoneNumber,
                LastName = customer.LastName,
                FirstName = customer.FirstName
            };
            
            HttpResponseMessage response = await _httpClient.PostAsync($"api/customers/create", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<CreateCustomerResponse>(responseBody);

            return  responseObject.Id > 0;
        }

        public async Task<bool> CreateRecord(Record record)
        {
            var request = new CreateRecordRequest() {
                CreatedOnUtc = record.CreatedOnUtc,
                Status = record.Status,
                BoxType = record.BoxType,
                FacilityId = record.FacilityId,
                CustomerId = record.CustomerId,
                Data = record.Data
            };
            
            HttpResponseMessage response = await _httpClient.PostAsync($"api/records/create", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<CreateRecordResponse>(responseBody);

            return  responseObject.Id > 0;
        }

        public async Task<CustomerViewModel> GetCustomer(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/customers/{id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject =  JsonConvert.DeserializeObject<GetCustomerResponse>(responseBody);

            return responseObject.Customer;
        }

        public async Task<IEnumerable<CustomerViewModel>> GetCustomers()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/customers");
            System.Diagnostics.Debug.WriteLine(response);

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject =  JsonConvert.DeserializeObject<GetCustomersResponse>(responseBody);

            return responseObject.Customers;
        }

        public async Task<IEnumerable<FacilityViewModel>> GetFacilities()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/facilities");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<GetFacilitiesResponse>(responseBody);

            return responseObject.Facilities;
        }

        public async Task<FacilityWithStorageInfoViewModel> GetFacility(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/facilities/{id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<GetFacilityResponse>(responseBody);

            return responseObject.Facility;
        }

        public async Task<RecordViewModel> GetRecord(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/records/{id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
             var responseObject = JsonConvert.DeserializeObject<GetRecordResponse>(responseBody);

            return responseObject.Record;
        }

        public async Task<IEnumerable<RecordViewModel>> GetRecords()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/records");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<GetRecordsResponse>(responseBody);

            return responseObject.Records;
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
             var request = new UpdateCustomerRequest() {
                Data = customer.Data,
                PhoneNumber = customer.PhoneNumber,
                LastName = customer.LastName,
                FirstName = customer.FirstName
            };
            
            HttpResponseMessage response = await _httpClient.PostAsync($"api/customers/{customer.Id}/update", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<UpdateCustomerResponse>(responseBody);

            return  true;
        }

        public async Task<bool> UpdateRecord(Record record)
        {
            var request = new UpdateRecordRequest() {
                CreatedOnUtc = record.CreatedOnUtc,
                Status = record.Status,
                BoxType = record.BoxType,
                FacilityId = record.FacilityId,
                CustomerId = record.CustomerId,
                StoredOnUtc = record.StoredOnUtc,
                RetrievedOnUtc = record.RetrievedOnUtc,
                Data = record.Data
            };
            
            HttpResponseMessage response = await _httpClient.PostAsync($"api/records/{record.Id}/update", new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<UpdateRecordResponse>(responseBody);

            return true;
        }
    }
}