using System.Text.Json.Serialization;

namespace Domains.Domains;

public class ResponseTimeDomain {
    [JsonIgnore]
    public int Id { get; set; }

    [JsonIgnore]
    public DateTime Date { get; set; }

    public int Count { get; set; }
    
    [JsonPropertyName("response_time")]

    public double ResponseTime { get; set; }
}
