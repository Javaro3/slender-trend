using Domains.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Services.DataServices;

namespace SlenderTrend.Controllers {
    [ApiController]
    [Route("total-chats-report")]
    public class TotalChatController : Controller {
        private readonly TotalChatDataService _dataService;

        public TotalChatController(TotalChatDataService dataService) {
            _dataService = dataService;
        }

        [HttpGet]
        public ActionResult<TotalChatsViewModel> Get([FromQuery] RequestModel request) {
            return _dataService.GetAll(request);
        }
    }
}
