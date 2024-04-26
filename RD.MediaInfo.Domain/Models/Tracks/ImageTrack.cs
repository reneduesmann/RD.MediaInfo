using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class ImageTrack : ITrack
{
    [JsonPropertyName("@type")]
    public StreamKind Type { get; set; }

    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("StreamCount")]
    public int StreamCount { get; set; }

    [JsonPropertyName("StreamKind")]
    public StreamKind StreamKind { get; set; }

    [JsonPropertyName("StreamKind_String")]
    public string? StreamKind_String { get; set; }

    [JsonPropertyName("StreamKindID")]
    public int StreamKindID { get; set; }

    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    [JsonPropertyName("Format_String")]
    public string? Format_String { get; set; }

    [JsonPropertyName("Format_Commercial")]
    public string? Format_Commercial { get; set; }

    [JsonPropertyName("InternetMediaType")]
    public string? MIMEType { get; set; }

    [JsonPropertyName("Width")]
    public int Width { get; set; }

    [JsonPropertyName("Width_String")]
    public string? Width_String { get; set; }

    [JsonPropertyName("Height")]
    public int Height { get; set; }

    [JsonPropertyName("Height_String")]
    public string? Height_String { get; set; }

    [JsonPropertyName("ColorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("BitDepth")]
    public int BitDepth { get; set; }

    [JsonPropertyName("BitDepth_String")]
    public string? BitDepth_String { get; set; }

    [JsonPropertyName("Compression_Mode")]
    public string? Compression_Mode { get; set; }

    [JsonPropertyName("Compression_Mode_String")]
    public string? Compression_Mode_String { get; set; }

    [JsonPropertyName("StreamSize")]
    public long StreamSize { get; set; }

    [JsonPropertyName("StreamSize_String")]
    public IReadOnlyList<string> StreamSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize_Proportion")]
    public string? StreamSize_Proportion { get; set; }
}