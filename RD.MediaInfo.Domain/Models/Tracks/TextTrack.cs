using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class TextTrack : ITrack
{
    [JsonPropertyName("@type")]
    public StreamKind Type { get; set; }

    [JsonPropertyName("@typeorder")]
    public int Typeorder { get; set; }

    [JsonPropertyName("Count")]
    public int Count { get; set; }

    [JsonPropertyName("StreamCount")]
    public int StreamCount { get; set; }

    [JsonPropertyName("StreamKind")]
    public StreamKind StreamKind { get; set; }

    [JsonPropertyName("StreamKind_String")]
    public string? StreamKindString { get; set; }

    [JsonPropertyName("StreamKindID")]
    public int StreamKindID { get; set; }

    [JsonPropertyName("StreamKindPos")]
    public string? StreamKindPos { get; set; }

    [JsonPropertyName("StreamOrder")]
    public string? StreamOrder { get; set; }

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("ID_String")]
    public string? IDString { get; set; }

    [JsonPropertyName("UniqueID")]
    public string? UniqueID { get; set; }

    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    [JsonPropertyName("Format_String")]
    public string? FormatString { get; set; }

    [JsonPropertyName("Format_Commercial")]
    public string? FormatCommercial { get; set; }

    [JsonPropertyName("CodecID")]
    public string? CodecID { get; set; }

    [JsonPropertyName("CodecID_Info")]
    public string? CodecIDInfo { get; set; }

    [JsonPropertyName("Duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("Duration_String")]
    public IReadOnlyList<string> DurationStrings { get; set; } = [];

    [JsonPropertyName("BitRate")]
    public string? BitRate { get; set; }

    [JsonPropertyName("BitRate_String")]
    public string? BitRateString { get; set; }

    [JsonPropertyName("FrameRate")]
    public string? FrameRate { get; set; }

    [JsonPropertyName("FrameRate_String")]
    public string? FrameRateString { get; set; }

    [JsonPropertyName("FrameCount")]
    public string? FrameCount { get; set; }

    [JsonPropertyName("ElementCount")]
    public string? ElementCount { get; set; }

    [JsonPropertyName("StreamSize")]
    public long StreamSize { get; set; }

    [JsonPropertyName("StreamSize_String")]
    public IReadOnlyList<string> StreamSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize_Proportion")]
    public string? StreamSizeProportion { get; set; }

    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    [JsonPropertyName("Language")]
    public string? Language { get; set; }

    [JsonPropertyName("Language_String")]
    public IReadOnlyList<string> LanguageStrings { get; set; } = [];

    [JsonPropertyName("Default")]
    public string? Default { get; set; }

    [JsonPropertyName("Default_String")]
    public string? DefaultString { get; set; }

    [JsonPropertyName("Forced")]
    public string? Forced { get; set; }

    [JsonPropertyName("Forced_String")]
    public string? ForcedString { get; set; }
}