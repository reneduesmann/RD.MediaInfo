using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class AudioTrack : ITrack
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
    public string? StreamKindString { get; set; }

    [JsonPropertyName("StreamKindID")]
    public int StreamKindID { get; set; }

    [JsonPropertyName("StreamOrder")]
    public int StreamOrder { get; set; }

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("ID_String")]
    public string? IDString { get; set; }

    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    [JsonPropertyName("Format_String")]
    public string? FormatString { get; set; }

    [JsonPropertyName("Format_Info")]
    public string? FormatInfo { get; set; }

    [JsonPropertyName("Format_Commercial")]
    public string? FormatCommercial { get; set; }

    [JsonPropertyName("Format_AdditionalFeatures")]
    public string? FormatAdditionalFeatures { get; set; }

    [JsonPropertyName("CodecID")]
    public string? CodecID { get; set; }

    [JsonPropertyName("Duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("Duration_String")]
    public IReadOnlyList<string> DurationStrings { get; set; } = [];

    [JsonPropertyName("BitRate_Mode")]
    public string? BitRateMode { get; set; }

    [JsonPropertyName("BitRate_Mode_String")]
    public string? BitRateModeString { get; set; }

    [JsonPropertyName("BitRate")]
    public int BitRate { get; set; }

    [JsonPropertyName("BitRate_String")]
    public string? BitRateString { get; set; }

    [JsonPropertyName("Channels")]
    public int Channels { get; set; }

    [JsonPropertyName("Channels_String")]
    public string? ChannelsString { get; set; }

    [JsonPropertyName("ChannelPositions")]
    public string? ChannelPositions { get; set; }

    [JsonPropertyName("ChannelPositions_String2")]
    public string? ChannelPositionsString2 { get; set; }

    [JsonPropertyName("ChannelLayout")]
    public string? ChannelLayout { get; set; }

    [JsonPropertyName("SamplesPerFrame")]
    public int SamplesPerFrame { get; set; }

    [JsonPropertyName("SamplingRate")]
    public int SamplingRate { get; set; }

    [JsonPropertyName("SamplingRate_String")]
    public string? SamplingRateString { get; set; }

    [JsonPropertyName("SamplingCount")]
    public int SamplingCount { get; set; }

    [JsonPropertyName("FrameRate")]
    public string? FrameRate { get; set; }

    [JsonPropertyName("FrameRate_String")]
    public string? FrameRateString { get; set; }

    [JsonPropertyName("FrameCount")]
    public int FrameCount { get; set; }

    [JsonPropertyName("Compression_Mode")]
    public string? CompressionMode { get; set; }

    [JsonPropertyName("Compression_Mode_String")]
    public string? CompressionModeString { get; set; }

    [JsonPropertyName("StreamSize")]
    public long StreamSize { get; set; }

    [JsonPropertyName("StreamSize_String")]
    public IReadOnlyList<string> StreamSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize_Proportion")]
    public string? StreamSizeProportion { get; set; }

    [JsonPropertyName("Default")]
    public bool Default { get; set; }

    [JsonPropertyName("Default_String")]
    public string? DefaultString { get; set; }

    [JsonPropertyName("AlternateGroup")]
    public string? AlternateGroup { get; set; }

    [JsonPropertyName("AlternateGroup_String")]
    public string? AlternateGroupString { get; set; }

    [JsonPropertyName("Format_Version")]
    public string? FormatVersion { get; set; }

    [JsonPropertyName("Format_Profile")]
    public string? FormatProfile { get; set; }

    [JsonPropertyName("Format_Settings")]
    public string? FormatSettings { get; set; }

    [JsonPropertyName("Format_Settings_Mode")]
    public string? FormatSettingsMode { get; set; }

    [JsonPropertyName("Format_Settings_ModeExtension")]
    public string? FormatSettingsModeExtension { get; set; }

    [JsonPropertyName("InternetMediaType")]
    public string? MIMEType { get; set; }

    [JsonPropertyName("Encoded_Library")]
    public string? EncodedLibrary { get; set; }

    [JsonPropertyName("Encoded_Library_String")]
    public string? EncodedLibraryString { get; set; }

    [JsonPropertyName("@typeorder")]
    public int? Typeorder { get; set; }

    [JsonPropertyName("StreamKindPos")]
    public int StreamKindPos { get; set; }

    [JsonPropertyName("UniqueID")]
    public string? UniqueID { get; set; }

    [JsonPropertyName("Format_Url")]
    public string? FormatUrl { get; set; }

    [JsonPropertyName("Format_Commercial_IfAny")]
    public string? FormatCommercialIfAny { get; set; }

    [JsonPropertyName("Format_Settings_Endianness")]
    public string? FormatSettingsEndianness { get; set; }

    [JsonPropertyName("Delay")]
    public string? Delay { get; set; }

    [JsonPropertyName("Delay_String")]
    public IReadOnlyList<string> DelayStrings { get; set; } = [];

    [JsonPropertyName("Delay_Source")]
    public string? DelaySource { get; set; }

    [JsonPropertyName("Delay_Source_String")]
    public string? DelaySourceString { get; set; }

    [JsonPropertyName("Video_Delay")]
    public string? VideoDelay { get; set; }

    [JsonPropertyName("Video_Delay_String")]
    public IReadOnlyList<string> VideoDelayStrings { get; set; } = [];

    [JsonPropertyName("Language")]
    public string? Language { get; set; }

    [JsonPropertyName("Language_String")]
    public IReadOnlyList<string> LanguageStrings { get; set; } = [];

    [JsonPropertyName("ServiceKind")]
    public string? ServiceKind { get; set; }

    [JsonPropertyName("ServiceKind_String")]
    public string? ServiceKindString { get; set; }

    [JsonPropertyName("Forced")]
    public bool Forced { get; set; }

    [JsonPropertyName("Forced_String")]
    public string? ForcedString { get; set; }

    [JsonPropertyName("extra")]
    public ExtraAudioTrackInformation? Extra { get; set; }

    [JsonPropertyName("BitDepth")]
    public string? BitDepth { get; set; }

    [JsonPropertyName("BitDepth_String")]
    public string? BitDepthString { get; set; }

    [JsonPropertyName("Title")]
    public string? Title { get; set; }
}