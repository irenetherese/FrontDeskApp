using FrontDeskApp.Requests;
using FrontDeskApp.Responses;
using FrontDeskApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Record.Api.Controllers
{
    [ApiController]
    [Route("api/records")]
    public class RecordsController : Controller
    {
        private readonly IRecordService _recordService;

        public RecordsController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        /// <summary>
        /// Gets a list of records
        /// </summary>
        /// <param name="request"></param>
        /// <returns>A list of records</returns>
        [HttpGet]
        [Route("")]
        public Task<GetRecordsResponse> GetRecordsAsync([FromQuery] GetRecordsRequest request) => _recordService.GetRecordsAsync(request);

        /// <summary>
        /// Creates a new record
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Record id of newly created record</returns>
        [HttpPost]
        [Route("create")]
        public Task<CreateRecordResponse> CreateRecordAsync([FromBody] CreateRecordRequest request) => _recordService.CreateRecordAsync(request);

        /// <summary>
        /// Gets a record
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns>One record</returns>
        [HttpGet]
        [Route("{record_id}")]
        public Task<GetRecordResponse> GetRecordAsync(int record_id) => _recordService.GetRecordAsync(record_id);


        /// <summary>
        /// Update record information
        /// </summary>
        /// <param name="record_id"></param>
        /// <param name="request"></param>
        /// <returns>An empty response</returns>
        [Route("{record_id}/update")]
        [HttpPost]
        public Task<UpdateRecordResponse> UpdateRecordAsync([FromBody] UpdateRecordRequest request, int record_id) => _recordService.UpdateRecordAsync(record_id, request);
    }
}
