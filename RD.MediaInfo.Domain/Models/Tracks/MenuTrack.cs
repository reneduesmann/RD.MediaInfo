using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public class MenuTrack : ITrack
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
    
    [JsonPropertyName("Chapters_Pos_Begin")]
    public string? ChaptersPosBegin { get; set; }
    
    [JsonPropertyName("Chapters_Pos_End")]
    public string? ChaptersPosEnd { get; set; }

    [JsonPropertyName("extra")]
    public Dictionary<string, string> Timestamps { get; set; } = [];
}