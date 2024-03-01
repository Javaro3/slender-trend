using System.Text.Json.Serialization;

namespace Domains.Domains;

public class DurationDomain {
    [JsonIgnore]
    public int Id { get; set; }
    
    [JsonIgnore]
    public DateTime Date { get; set; }

    [JsonPropertyName("agents_chatting_duration")]
    public int AgentsChattingDuration { get; set; }

    public int Count { get; set; }

    public int Duration { get; set; }
}
