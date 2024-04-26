using RD.Extensions.Enums.Attributes;

namespace RD.MediaInfo.Domain.Enums;

public enum StreamKind
{
    Undefined = 0,

    [StringValue("General")]
    General,
    
    [StringValue("Video")]
    Video,

    [StringValue("Audio")]
    Audio,

    [StringValue("Text")]
    Text,

    [StringValue("Other")]
    Other,
    
    [StringValue("Image")]
    Image,
    
    [StringValue("Menu")]
    Menu,

    [StringValue("Max")]
    Max
}

