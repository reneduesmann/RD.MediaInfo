using RD.MediaInfo.Domain.Models;

namespace RD.MediaInfo.Contracts;
public interface IMediaInfo : IDisposable
{
    void Close();

    MediaInfoItem? GetMediaInformations();

    string GetMediaInformationsAsJson();

    void Open(string path);
}