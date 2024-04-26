using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class GeneralTrack : ITrack
{
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

    [JsonPropertyName("ImageCount")]
    public int ImageCount { get; set; }

    [JsonPropertyName("Image_Format_List")]
    public IReadOnlyList<string> Image_Format_List { get; set; } = [];

    [JsonPropertyName("Image_Format_WithHint_List")]
    public IReadOnlyList<string> Image_Format_WithHint_List { get; set; } = [];

    [JsonPropertyName("Image_Codec_List")]
    public IReadOnlyList<string> Image_Codec_List { get; set; } = [];

    [JsonPropertyName("CompleteName")]
    public string? FilePath { get; set; }

    [JsonPropertyName("FolderName")]
    public string? DirectoryPath { get; set; }

    [JsonPropertyName("FileNameExtension")]
    public string? FileNameWithExtension { get; set; }

    [JsonPropertyName("FileName")]
    public string? FileNameWithoutExtension { get; set; }

    [JsonPropertyName("FileExtension")]
    public string? FileExtension { get; set; }

    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    [JsonPropertyName("Format_String")]
    public string? FormatString { get; set; }

    [JsonPropertyName("Format_Extensions")]
    public IReadOnlyList<string> FormatExtensions { get; set; } = [];

    [JsonPropertyName("Format_Commercial")]
    public string? FormatCommercial { get; set; }

    [JsonPropertyName("Format_Version")]
    public int FormatVersion { get; set; }

    [JsonPropertyName("InternetMediaType")]
    public string? MIMEType { get; set; }

    [JsonPropertyName("FileSize")]
    public long FileSizeInBytes { get; set; }

    [JsonPropertyName("FileSize_String")]
    public IReadOnlyList<string> FileSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize")]
    public long StreamSize { get; set; }

    [JsonPropertyName("StreamSize_String")]
    public IReadOnlyList<string> StreamSizeStrings { get; set; } = [];

    [JsonPropertyName("StreamSize_Proportion")]
    public string? StreamSizeProportion { get; set; }

    [JsonPropertyName("File_Created_Date")]
    public DateTimeOffset FileCreatedDate { get; set; }

    [JsonPropertyName("File_Created_Date_Local")]
    public DateTime FileCreatedDateLocal { get; set; }

    [JsonPropertyName("File_Modified_Date")]
    public DateTimeOffset FileModifiedDate { get; set; }

    [JsonPropertyName("File_Modified_Date_Local")]
    public DateTime FileModifiedDateLocal { get; set; }

    [JsonPropertyName("@type")]
    public StreamKind Type { get; set; }

    [JsonPropertyName("VideoCount")]
    public int VideoCount { get; set; }

    [JsonPropertyName("AudioCount")]
    public int AudioCount { get; set; }

    [JsonPropertyName("TextCount")]
    public int TextCount { get; set; }

    [JsonPropertyName("MenuCount")]
    public int MenuCount { get; set; }

    [JsonPropertyName("Text_Format_List")]
    public IReadOnlyList<string> TextFormatList { get; set; } = [];

    [JsonPropertyName("Text_Format_WithHint_List")]
    public IReadOnlyList<string> TextFormatWithHintList { get; set; } = [];

    [JsonPropertyName("Text_Language_List")]
    public IReadOnlyList<string> TextLanguageList { get; set; } = [];

    [JsonPropertyName("Text_Codec_List")]
    public IReadOnlyList<string> TextCodecList { get; set; } = [];

    [JsonPropertyName("Video_Format_List")]
    public IReadOnlyList<string> VideoFormatList { get; set; } = [];

    [JsonPropertyName("Video_Format_WithHint_List")]
    public IReadOnlyList<string> VideoFormatWithHintList { get; set; } = [];

    [JsonPropertyName("Video_Codec_List")]
    public IReadOnlyList<string> VideoCodecList { get; set; } = [];

    [JsonPropertyName("Format_Url")]
    public Uri? FormatUrl { get; set; }

    [JsonPropertyName("Video_Language_List")]
    public IReadOnlyList<string> VideoLanguageList { get; set; } = [];

    [JsonPropertyName("Audio_Format_List")]
    public IReadOnlyList<string> AudioFormatList { get; set; } = [];

    [JsonPropertyName("Audio_Language_List")]
    public IReadOnlyList<string> AudioLanguageList { get; set; } = [];

    [JsonPropertyName("Audio_Format_WithHint_List")]
    public IReadOnlyList<string> AudioFormatWithHintList { get; set; } = [];

    [JsonPropertyName("Audio_Codec_List")]
    public IReadOnlyList<string> AudioCodecList { get; set; } = [];

    [JsonPropertyName("Audio_Channels_Total")]
    public int AudioChannelsTotal { get; set; }

    [JsonPropertyName("Format_Profile")]
    public string? FormatProfile { get; set; }

    [JsonPropertyName("CodecID")]
    public string? CodecID { get; set; }

    [JsonPropertyName("CodecID_String")]
    public string? CodecIDString { get; set; }

    [JsonPropertyName("CodecID_Url")]
    public Uri? CodecIDUrl { get; set; }

    [JsonPropertyName("CodecID_Compatible")]
    public string? CodecIDCompatible { get; set; }

    [JsonPropertyName("Duration")]
    public string? Duration { get; set; }

    [JsonPropertyName("Duration_String")]
    public IReadOnlyList<string> DurationStrings { get; set; } = [];

    [JsonPropertyName("OverallBitRate")]
    public long OverallBitRateInBytes { get; set; }

    [JsonPropertyName("OverallBitRate_String")]
    public string? OverallBitRateString { get; set; }

    [JsonPropertyName("FrameRate")]
    public string? FrameRate { get; set; }

    [JsonPropertyName("FrameRate_String")]
    public string? FrameRateString { get; set; }

    [JsonPropertyName("FrameCount")]
    public int FrameCount { get; set; }

    [JsonPropertyName("HeaderSize")]
    public int HeaderSize { get; set; }

    [JsonPropertyName("DataSize")]
    public long DataSize { get; set; }

    [JsonPropertyName("FooterSize")]
    public int FooterSize { get; set; }

    [JsonPropertyName("IsStreamable")]
    public bool IsStreamable { get; set; }

    [JsonPropertyName("Encoded_Application")]
    public string? EncodedApplication { get; set; }

    [JsonPropertyName("Encoded_Application_String")]
    public string? EncodedApplicationString { get; set; }

    [JsonPropertyName("Encoded_Library")]
    public string? EncodedLibrary { get; set; }

    [JsonPropertyName("Encoded_Library_String")]
    public string? EncodedLibraryString { get; set; }

    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    [JsonPropertyName("Track")]
    public string? Track { get; set; }

    [JsonPropertyName("Performer")]
    public string? Performer { get; set; }

    [JsonPropertyName("Comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("UniqueID")]
    public string? UniqueID { get; set; }

    [JsonPropertyName("UniqueID_String")]
    public string? UniqueID_String { get; set; }

    [JsonPropertyName("Encoded_Date")]
    public DateTimeOffset? EncodedDate { get; set; }

    [JsonPropertyName("OverallBitRate_Mode")]
    public string? OverallBitRateMode { get; set; }

    [JsonPropertyName("OverallBitRate_Mode_String")]
    public string? OverallBitRateModeString { get; set; }
}