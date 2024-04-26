using RD.Extensions.Enums.Cache;
using RD.Extensions.Enums.Contracts;
using RD.Extensions.Enums.Enums;
using RD.MediaInfo.Contracts;
using RD.MediaInfo.Converters;
using RD.MediaInfo.Domain.Enums;
using RD.MediaInfo.Domain.Models;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace RD.MediaInfo;

public partial class MediaInfo : IMediaInfo
{
    private IntPtr _handle;

    private JsonSerializerOptions? _jsonSerializerOptions;

    private IEnumCache? _enumCache;

    #region Native Methods

    private const string _mediaInfoDll = "MediaInfo.dll";

    [LibraryImport(_mediaInfoDll)]
    private static partial IntPtr MediaInfo_New();

    [LibraryImport(_mediaInfoDll, StringMarshalling = StringMarshalling.Utf16)]
    private static partial int MediaInfo_Open(IntPtr handle, string path);

    [LibraryImport(_mediaInfoDll, StringMarshalling = StringMarshalling.Utf16)]
    private static partial IntPtr MediaInfo_Option(IntPtr handle, string option, string value);

    [LibraryImport(_mediaInfoDll)]
    private static partial IntPtr MediaInfo_Inform(IntPtr handle, int reserved);

    [LibraryImport(_mediaInfoDll)]
    private static partial int MediaInfo_Close(IntPtr handle);

    [LibraryImport(_mediaInfoDll)]
    private static partial void MediaInfo_Delete(IntPtr handle);

    [LibraryImport(_mediaInfoDll, StringMarshalling = StringMarshalling.Utf16)]
    private static partial IntPtr MediaInfo_Get(IntPtr handle, StreamKind streamKind,
        int stream, string parameter, InfoKind infoKind, InfoKind searchKind);

    [LibraryImport(_mediaInfoDll)]
    private static partial int MediaInfo_Count_Get(
        IntPtr handle, StreamKind streamKind, int stream);

    #endregion Native Methods

    public MediaInfo()
    {
        this._handle = MediaInfo_New();

        if (this._handle == IntPtr.Zero)
        {
            throw new InvalidOperationException("Failed to create a new MediaInfo handle.");
        }
    }

    public void Close()
    {
        if (this._handle != IntPtr.Zero)
        {
            MediaInfo_Close(this._handle);
        }
    }

    public string GetMediaInformationsAsJson()
    {
        if (this._handle == IntPtr.Zero)
        {
            return string.Empty;
        }

        MediaInfo_Option(this._handle, "Output", "JSON");
        MediaInfo_Option(this._handle, "Complete", "1");
        IntPtr inform = MediaInfo_Inform(this._handle, 0);

        return Marshal.PtrToStringUni(inform) ?? string.Empty;
    }

    public MediaInfoItem? GetMediaInformations()
    {
        string mediaInformations = this.GetMediaInformationsAsJson();

        JsonSerializerOptions jsonSerializerOptions = this.GetJsonSerializerOptions();

        try
        {
            return JsonSerializer.Deserialize<MediaInfoItem>(mediaInformations, jsonSerializerOptions);
        }
        catch
        {
            return null;
        }
    }

    public void Open(string path)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);

        if (MediaInfo_Open(this._handle, path) == 0)
        {
            throw new InvalidOperationException("Failed to open the file.");
        }
    }

    public void Dispose()
    {
        if (this._handle != IntPtr.Zero)
        {
            MediaInfo_Close(this._handle);
            MediaInfo_Delete(this._handle);
            this._handle = IntPtr.Zero;
        }
    }

    private JsonSerializerOptions GetJsonSerializerOptions()
    {
        this._enumCache ??= new EnumCache(new() { CachingMethod = CachingMethod.CacheEntireEnumWhenFirstUsed });

        return this._jsonSerializerOptions ??= new()
        {
            Converters =
            {
                new TrackConverter(),
                new EnumConverter<StreamKind>(this._enumCache),
                new DateTimeOffsetConverter(),
                new DateTimeConverter(),
                new StringToIntConverter(),
                new StringToLongConverter(),
                new StringToBoolConverter(),
                new StringToDoubleConverter()
            },
        };
    }
}
