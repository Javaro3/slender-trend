using Domains.Domains;
using Domains.ViewModels;
using Repository.Repositories;

namespace Services.DataServices {
    public class DurationDataService : IDataService<DurationsViewModel> {
        private readonly DurationRepository _repository;

        public DurationDataService(DurationRepository repository) {
            _repository = repository;
        }

        public DurationsViewModel GetAll(RequestModel request) {
            var durations = _repository
                .GetAll()
                .Where(e => e.Date.CompareTo(request.Filter.From) >= 0)
                .Where(e => e.Date.CompareTo(request.Filter.To) <= 0);

            var total = durations
                .Select(e => e.Count)
                .Aggregate((a, b) => a + b);

            var durationsByDate = new Dictionary<string, DurationDomain>();

            foreach (var duration in durations){
                durationsByDate.Add(duration.Date.ToString("yyyy-MM-dd"), duration);
            }

            var model = new DurationsViewModel() {
                Total = total,
                Records = durationsByDate
            };
            return model;
        }
    }
}
