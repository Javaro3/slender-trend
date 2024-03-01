using System.Text.Json.Serialization;

namespace Domains.Domains;

public class TagDomain {
    [JsonIgnore]
    public int Id { get; set; }

    [JsonIgnore]
    public DateTime Date { get; set; }

    public string Name { get; set; } = null!;

    public int Count { get; set; }
}
