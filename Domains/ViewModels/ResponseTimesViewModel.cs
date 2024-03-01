using Domains.Domains;

namespace Domains.ViewModels {
    public class ResponseTimesViewModel {
        public int Total { get; set; }
        public Dictionary<string, ResponseTimeDomain> Records { get; set; }
    }
}
