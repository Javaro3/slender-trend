using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DataServices;

namespace SlenderTrend.Controllers {
    [ApiController]
    [Route("ratings-report")]
    public class RatingController : Controller {
        private readonly RatingDataService _dataService;

        public RatingController(RatingDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult<RatingsViewModel> Get([FromQuery]RequestModel request) {
            return _dataService.GetAll(request);
        }
    }
}
