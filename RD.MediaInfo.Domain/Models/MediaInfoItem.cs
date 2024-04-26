namespace RD.MediaInfo.Domain.Models;

public class MediaInfoItem
{
    [JsonPropertyName("creatingLibrary")]
    public CreatingLibrary? CreatingLibrary { get; set; }
    
    [JsonPropertyName("media")]
    public Media? Media { get; set; }
}