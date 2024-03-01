using Domains.Domains;

namespace Domains.ViewModels {
    public class DurationsViewModel {
        public int Total { get; set; }
        public Dictionary<string, DurationDomain> Records { get; set; }
    }
}
