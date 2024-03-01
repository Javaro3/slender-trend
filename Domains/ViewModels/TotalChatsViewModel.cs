using Domains.Domains;

namespace Domains.ViewModels {
    public class TotalChatsViewModel {
        public int Total { get; set; }
        public Dictionary<string, TotalChatDomain> Records { get; set; }
    }
}
