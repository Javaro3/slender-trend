using Domains.Domains;

namespace Domains.ViewModels {
    public class RatingsViewModel {
        public int Total { get; set; }
        public Dictionary<string, RatingDomain> Records { get; set; }
    }
}
