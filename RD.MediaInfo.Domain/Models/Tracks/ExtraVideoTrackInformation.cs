namespace RD.MediaInfo.Domain.Models.Tracks;

public class ExtraVideoTrackInformation
{
    [JsonPropertyName("CodecConfigurationBox")]
    public string? CodecConfigurationBox { get; set; }
}
