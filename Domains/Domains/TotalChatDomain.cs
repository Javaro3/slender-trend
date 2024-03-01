using System.Text.Json.Serialization;

namespace Domains.Domains;

public class TotalChatDomain {
    [JsonIgnore]
    public int Id { get; set; }

    [JsonIgnore]
    public DateTime Date { get; set; }

    public int Total { get; set; }
}
