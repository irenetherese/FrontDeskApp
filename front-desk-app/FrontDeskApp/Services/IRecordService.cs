using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using System.Threading.Tasks;

namespace FrontDeskApp.Services
{
    public interface IRecordService
    {
        Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request);
        Task<CreateRecordResponse> CreateRecordAsync(CreateRecordRequest request);
        Task<GetRecordResponse> GetRecordAsync(int record_id);
        Task<UpdateRecordResponse> UpdateRecordAsync(int record_id, UpdateRecordRequest request);
    }
}
