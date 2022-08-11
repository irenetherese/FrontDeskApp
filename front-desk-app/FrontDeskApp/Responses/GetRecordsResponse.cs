using System.Collections.Generic;
using FrontDeskApp.ViewModels;

namespace FrontDeskApp.Responses
{
    public class GetRecordsResponse
    {
        public IEnumerable<RecordViewModel> Records { get; set; }
    }
}