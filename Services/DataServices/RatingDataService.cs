using Domains.Domains;
using Domains.ViewModels;
using Repository.Repositories;

namespace Services.DataServices {
    public class RatingDataService : IDataService<RatingsViewModel> {
        private readonly RatingRepository _repository;

        public RatingDataService(RatingRepository repository) {
            _repository = repository;
        }

        public RatingsViewModel GetAll(RequestModel request) {
            var ratings = _repository
                .GetAll()
                .Where(e => e.Date.CompareTo(request.Filters.From) >= 0)
                .Where(e => e.Date.CompareTo(request.Filters.To) <= 0);

            var total = ratings
                .Select(e => e.Chats)
                .Aggregate((a, b) => a + b);

            var ratingsByDate = new Dictionary<string, RatingDomain>();

            foreach (var rating in ratings) {
                ratingsByDate.Add(rating.Date.ToString("yyyy-MM-dd"), rating);
            }

            var model = new RatingsViewModel() {
                Total = total,
                Records = ratingsByDate
            };
            return model;
        }
    }
}
