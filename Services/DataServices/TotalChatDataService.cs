using Domains.Domains;
using Domains.ViewModels;
using Repository.Repositories;

namespace Services.DataServices {
    public class TotalChatDataService : IDataService<TotalChatsViewModel> {
        private readonly TotalChatRepository _repository;

        public TotalChatDataService(TotalChatRepository repository) {
            _repository = repository;
        }

        public TotalChatsViewModel GetAll(RequestModel request) {
            var totalChats = _repository
                .GetAll()
                .Where(e => e.Date.CompareTo(request.Filters.From) >= 0)
                .Where(e => e.Date.CompareTo(request.Filters.To) <= 0);

            var total = totalChats
                .Select(e => e.Total)
                .Aggregate((a, b) => a + b);

            var totalChatsByDate = new Dictionary<string, TotalChatDomain>();

            foreach (var totalChat in totalChats) {
                totalChatsByDate.Add(totalChat.Date.ToString("yyyy-MM-dd"), totalChat);
            }

            var model = new TotalChatsViewModel() {
                Total = total,
                Records = totalChatsByDate
            };
            return model;
        }
    }
}
