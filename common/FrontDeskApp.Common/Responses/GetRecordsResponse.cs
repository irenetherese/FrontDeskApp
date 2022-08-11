using System.Collections.Generic;
using FrontDeskApp.Common.ViewModels;

namespace FrontDeskApp.Common.Responses
{
    public class GetRecordsResponse
    {
        public IEnumerable<RecordViewModel> Records { get; set; }
    }
}