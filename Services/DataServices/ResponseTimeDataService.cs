using Domains.Domains;
using Domains.ViewModels;
using Repository.Repositories;

namespace Services.DataServices {
    public class ResponseTimeDataService : IDataService<ResponseTimesViewModel> {
        private readonly ResponseTimeRepository _repository;

        public ResponseTimeDataService(ResponseTimeRepository repository) {
            _repository = repository;
        }

        public ResponseTimesViewModel GetAll(RequestModel request) {
            var responseTimes = _repository
                .GetAll()
                .Where(e => e.Date.CompareTo(request.Filter.From) >= 0)
                .Where(e => e.Date.CompareTo(request.Filter.To) <= 0);

            var total = responseTimes
                .Select(e => e.Count)
                .Aggregate((a, b) => a + b);

            var responseTimesByDate = new Dictionary<string, ResponseTimeDomain>();

            foreach (var responseTime in responseTimes) {
                responseTimesByDate.Add(responseTime.Date.ToString("yyyy-MM-dd"), responseTime);
            }

            var model = new ResponseTimesViewModel() {
                Total = total,
                Records = responseTimesByDate
            };
            return model;
        }
    }
}
