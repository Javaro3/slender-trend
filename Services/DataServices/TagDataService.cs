using Domains.ViewModels;
using Repository.Repositories;

namespace Services.DataServices {
    public class TagDataService : IDataService<TagsViewModel> {
        private readonly TagRepository _repository;

        public TagDataService(TagRepository repository) {
            _repository = repository;
        }

        public TagsViewModel GetAll(RequestModel request) {
            var tags = _repository
                .GetAll()
                .Where(e => e.Date.CompareTo(request.Filter.From) >= 0)
                .Where(e => e.Date.CompareTo(request.Filter.To) <= 0);

            var total = tags.Select(e => e.Count).Sum();

            var tagsByDate = new Dictionary<string, Dictionary<string, int>>();

            foreach (var tag in tags) {
                if (!tagsByDate.TryAdd(tag.Date.ToString("yyyy-MM-dd"), new Dictionary<string, int>() { { tag.Name, tag.Count } })) {
                    tagsByDate[tag.Date.ToString("yyyy-MM-dd")].Add(tag.Name, tag.Count);
                }
            }

            var model = new TagsViewModel() {
                Total = total,
                Records = tagsByDate
            };
            return model;
        }
    }
}
