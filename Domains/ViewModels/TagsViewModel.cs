namespace Domains.ViewModels {
    public class TagsViewModel {
        public int Total { get; set; }
        public Dictionary<string, Dictionary<string, int>> Records { get; set; }
    }
}
