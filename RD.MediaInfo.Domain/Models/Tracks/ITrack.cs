using RD.MediaInfo.Domain.Enums;

namespace RD.MediaInfo.Domain.Models.Tracks;

public interface ITrack
{
    StreamKind Type { get; set; }
}
