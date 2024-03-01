using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DataServices;

namespace SlenderTrend.Controllers {
    [ApiController]
    [Route("tags-report")]
    public class TagController : Controller {
        private readonly TagDataService _dataService;

        public TagController(TagDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult<TagsViewModel> Get([FromQuery]RequestModel request) {
            return _dataService.GetAll(request);
        }
    }
}
