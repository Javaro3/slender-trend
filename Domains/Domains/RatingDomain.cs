using System.Text.Json.Serialization;

namespace Domains.Domains;

public class RatingDomain {
    [JsonIgnore]
    public int Id { get; set; }

    [JsonIgnore]
    public DateTime Date { get; set; }

    public int Bad { get; set; }

    public int Chats { get; set; }

    public int Good { get; set; }
}
