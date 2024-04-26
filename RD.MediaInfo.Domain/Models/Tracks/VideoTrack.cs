using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class VideoTrack : ITrack
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

    [JsonPropertyName("Format_Url")]
    public Uri? FormatUrl { get; set; }

    [JsonPropertyName("Format_Commercial")]
    public string? FormatCommercial { get; set; }

    [JsonPropertyName("Format_Profile")]
    public string? FormatProfile { get; set; }

    [JsonPropertyName("Format_Level")]
    public int FormatLevel { get; set; }

    [JsonPropertyName("Format_Settings")]
    public string? FormatSettings { get; set; }

    [JsonPropertyName("Format_Settings_CABAC")]
    public bool FormatSettingsCABAC { get; set; }

    [JsonPropertyName("Format_Settings_CABAC_String")]
    public string? FormatSettingsCABACString { get; set; }

    [JsonPropertyName("Format_Settings_RefFrames")]
    public int FormatSettingsRefFrames { get; set; }

    [JsonPropertyName("Format_Settings_RefFrames_String")]
    public string? FormatSettingsRefFramesString { get; set; }

    [JsonPropertyName("InternetMediaType")]
    public string? MIMEType { get; set; }

    [JsonPropertyName("CodecID")]
    public string? CodecID { get; set; }

    [JsonPropertyName("CodecID_Info")]
    public string? CodecIDInfo { get; set; }

    [JsonPropertyName("Duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("Duration_String")]
    public IReadOnlyList<string> DurationStrings { get; set; } = [];

    [JsonPropertyName("BitRate")]
    public int BitRate { get; set; }

    [JsonPropertyName("BitRate_String")]
    public string? BitRateString { get; set; }

    [JsonPropertyName("Width")]
    public int Width { get; set; }

    [JsonPropertyName("Width_String")]
    public string? WidthString { get; set; }

    [JsonPropertyName("Height")]
    public int Height { get; set; }

    [JsonPropertyName("Height_String")]
    public string? HeightString { get; set; }

    [JsonPropertyName("Stored_Height")]
    public int StoredHeight { get; set; }

    [JsonPropertyName("Sampled_Width")]
    public int SampledWidth { get; set; }

    [JsonPropertyName("Sampled_Height")]
    public int SampledHeight { get; set; }

    [JsonPropertyName("PixelAspectRatio")]
    public string? PixelAspectRatio { get; set; }

    [JsonPropertyName("DisplayAspectRatio")]
    public string? DisplayAspectRatio { get; set; }

    [JsonPropertyName("DisplayAspectRatio_String")]
    public string? DisplayAspectRatio_String { get; set; }

    [JsonPropertyName("Rotation")]
    public string? Rotation { get; set; }

    [JsonPropertyName("Rotation_String")]
    public string? RotationString { get; set; }

    [JsonPropertyName("FrameRate_Mode")]
    public string? FrameRateMode { get; set; }

    [JsonPropertyName("FrameRate_Mode_String")]
    public string? FrameRateModeString { get; set; }

    [JsonPropertyName("FrameRate")]
    public string? FrameRate { get; set; }

    [JsonPropertyName("FrameRate_String")]
    public string? FrameRateString { get; set; }

    [JsonPropertyName("FrameRate_Num")]
    public int FrameRateNum { get; set; }

    [JsonPropertyName("FrameRate_Den")]
    public int FrameRateDen { get; set; }

    [JsonPropertyName("FrameRate_Minimum")]
    public string? FrameRateMinimum { get; set; }

    [JsonPropertyName("FrameRate_Minimum_String")]
    public string? FrameRateMinimumString { get; set; }

    [JsonPropertyName("FrameRate_Maximum")]
    public string? FrameRateMaximum { get; set; }

    [JsonPropertyName("FrameRate_Maximum_String")]
    public string? FrameRateMaximumString { get; set; }

    [JsonPropertyName("FrameCount")]
    public int FrameCount { get; set; }

    [JsonPropertyName("ColorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("ChromaSubsampling")]
    public string? ChromaSubsampling { get; set; }

    [JsonPropertyName("ChromaSubsampling_String")]
    public string? ChromaSubsampling_String { get; set; }

    [JsonPropertyName("BitDepth")]
    public int BitDepth { get; set; }

    [JsonPropertyName("BitDepth_String")]
    public string? BitDepthString { get; set; }

    [JsonPropertyName("ScanType")]
    public string? ScanType { get; set; }

    [JsonPropertyName("ScanType_String")]
    public string? ScanTypeString { get; set; }

    [JsonPropertyName("BitsPixel_Frame")]
    public string? BitsPixelFrame { get; set; }

    [JsonPropertyName("StreamSize")]
    public long StreamSize { get; set; }

    [JsonPropertyName("StreamSize_String")]
    public IReadOnlyList<string> StreamSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize_Proportion")]
    public string? StreamSizeProportion { get; set; }

    [JsonPropertyName("colour_description_present")]
    public bool ColourDescriptionPresent { get; set; }

    [JsonPropertyName("colour_description_present_Source")]
    public string? ColourDescriptionPresentSource { get; set; }

    [JsonPropertyName("colour_range")]
    public string? ColourRange { get; set; }

    [JsonPropertyName("colour_range_Source")]
    public string? ColourRangeSource { get; set; }

    [JsonPropertyName("colour_primaries")]
    public string? ColourPrimaries { get; set; }

    [JsonPropertyName("colour_primaries_Source")]
    public string? ColourPrimariesSource { get; set; }

    [JsonPropertyName("transfer_characteristics")]
    public string? TransferCharacteristics { get; set; }

    [JsonPropertyName("transfer_characteristics_Source")]
    public string? TransferCharacteristicsSource { get; set; }

    [JsonPropertyName("matrix_coefficients")]
    public string? MatrixCoefficients { get; set; }

    [JsonPropertyName("matrix_coefficients_Source")]
    public string? MatrixCoefficientsSource { get; set; }

    [JsonPropertyName("extra")]
    public ExtraVideoTrackInformation? Extra { get; set; }

    [JsonPropertyName("UniqueID")]
    public string? UniqueID { get; set; }

    [JsonPropertyName("Format_Settings_SliceCount")]
    public string? FormatSettingsSliceCount { get; set; }

    [JsonPropertyName("Format_Settings_SliceCount_String")]
    public string? FormatSettingsSliceCountString { get; set; }

    [JsonPropertyName("CodecID_Url")]
    public Uri? CodecIDUrl { get; set; }

    [JsonPropertyName("Delay")]
    public string? Delay { get; set; }

    [JsonPropertyName("Delay_String")]
    public IReadOnlyList<string> DelayStrings { get; set; } = [];

    [JsonPropertyName("Delay_Source")]
    public string? DelaySource { get; set; }

    [JsonPropertyName("Delay_Source_String")]
    public string? DelaySourceString { get; set; }

    [JsonPropertyName("Language")]
    public string? Language { get; set; }

    [JsonPropertyName("Language_String")]
    public IReadOnlyList<string> LanguageStrings { get; set; } = [];

    [JsonPropertyName("Default")]
    public bool Default { get; set; }

    [JsonPropertyName("Default_String")]
    public string? DefaultString { get; set; }

    [JsonPropertyName("Forced")]
    public bool Forced { get; set; }

    [JsonPropertyName("Forced_String")]
    public string? ForcedString { get; set; }

    [JsonPropertyName("Encoded_Library")]
    public string? EncodedLibrary { get; set; }

    [JsonPropertyName("Encoded_Library_String")]
    public string? EncodedLibraryString { get; set; }

    [JsonPropertyName("Encoded_Library_Name")]
    public string? EncodedLibraryName { get; set; }

    [JsonPropertyName("Encoded_Library_Version")]
    public string? EncodedLibraryVersion { get; set; }

    [JsonPropertyName("Encoded_Library_Settings")]
    public string? EncodedLibrarySettings { get; set; }

    [JsonPropertyName("BitRate_Mode")]
    public string? BitRateMode { get; set; }

    [JsonPropertyName("BitRate_Mode_String")]
    public string? BitRateModeString { get; set; }

    [JsonPropertyName("BitRate_Maximum")]
    public string? BitRateMaximum { get; set; }

    [JsonPropertyName("BitRate_Maximum_String")]
    public string? BitRateMaximumString { get; set; }

    [JsonPropertyName("BufferSize")]
    public string? BufferSize { get; set; }
}