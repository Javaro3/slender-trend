using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DataServices;

namespace SlenderTrend.Controllers {
    [ApiController]
    [Route("duration-report")]
    public class DurationController : Controller {
        private readonly DurationDataService _dataService;

        public DurationController(DurationDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult<DurationsViewModel> Get([FromQuery]RequestModel request) {
             return _dataService.GetAll(request);
        }
    }
}