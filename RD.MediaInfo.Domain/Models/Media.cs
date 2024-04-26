using RD.MediaInfo.Domain.Models.Tracks;

namespace RD.MediaInfo.Domain.Models;

public class Media
{
    [JsonPropertyName("@ref")]
    public string? FilePath { get; set; }

    [JsonPropertyName("track")]
    public IReadOnlyList<ITrack> Tracks { get; set; } = [];
}
