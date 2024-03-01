using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DataServices;

namespace SlenderTrend.Controllers {
    [ApiController]
    [Route("response-time-report")]
    public class ResponseTimeController : Controller {
        private readonly ResponseTimeDataService _dataService;

        public ResponseTimeController(ResponseTimeDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult<ResponseTimesViewModel> Get([FromQuery]RequestModel request) {
            return _dataService.GetAll(request);
        }
    }
}
