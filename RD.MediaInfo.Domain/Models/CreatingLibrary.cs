namespace RD.MediaInfo.Domain.Models;

public class CreatingLibrary
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("version")]
    public string? Version { get; set; }
    
    [JsonPropertyName("url")]
    public Uri? Url { get; set; }
}
