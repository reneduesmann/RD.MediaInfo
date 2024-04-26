# RD.MediaInfo - Simple and lightweight .NET Wrapper for MediaInfo

Provide two methods to get the entire media informations ([like this](#Example-output-from-MediaInfo)) of a file as json or in mapped C# classes.

## Installation

1. Install the package from NuGet:
```powershell
Install-Package RD.MediaInfo
```

2. Add the [MediaInfo.dll](https://mediaarea.net/de/MediaInfo/Download/Windows) to the same directory as the executable.

## Table of Contents
* [Examples](#Examples)
* [Informations](#Informations)
* [Dependencies](#Dependencies)
* [License](#License)
* [Example output from MediaInfo](#Example-output-from-MediaInfo)

## Examples

Get media informations from a single file:
```csharp
using IMediaInfo mediaInfo = new MediaInfo();
mediaInfo.Open("PathToMediaFile");

string json = mediaInfo.GetMediaInformationsAsJson();
//or
MediaInfoItem? mediaInfoItem = mediaInfo.GetMediaInformations();
```

Get media informations from multiple files:
```csharp
using IMediaInfo mediaInfo = new MediaInfo();
string[] fileNames = 
[
    "pathOne.jpg",
    "pathTwo.mp4",
    "pathThree.mkv"
];

foreach (string fileName in fileNames)
{
    mediaInfo.Open(fileName);
    MediaInfoItem? infos = mediaInfo.GetMediaInformations();
    mediaInfo.Close();

}
```

Get general informations from a file:
```csharp
using IMediaInfo mediaInfo = new MediaInfo();
mediaInfo.Open(@"C:\Users\Ruut\Documents\Github_Repositories\RD.NoName\pso-hd-engel-1080p.mkv");

MediaInfoItem? mediaInfoItem = mediaInfo.GetMediaInformations();

GeneralTrack? generalTrack = mediaInfoItem.Media.Tracks
    .FirstOrDefault(x => x is GeneralTrack generalTrack) as GeneralTrack;
long fileSize = generalTrack.FileSizeInBytes;
```

## Informations

The `MediaInfoItem` class contains the property `Media` which contains a list `List<ITrack>`.
Currently, the following tracks are supported:
- General
- Audio
- Image
- Menu
- Text
- Video

Most common properties have a valid datatype for the values.

## Dependencies

- [RD.Extensions.Enum](https://github.com/reneduesmann/RD.Extensions.Enums) (Decorate enum values with additional data)

## License
RD.MediaInfo is licensed under the [MIT License](https://github.com/reneduesmann/RD.MediaInfo/blob/main/LICENSE). See the LICENSE file for more informations.

## Example output from MediaInfo
```powershell
General
Unique ID                                : 1234567890 (0xA1234567890)
Complete name                            : fileName.mkv
Format                                   : Matroska
Format version                           : Version 4
File size                                : 4.20 GiB
Duration                                 : 1 h 58 min
Overall bit rate                         : 5 069 kb/s
Frame rate                               : 23.976 FPS
Encoded date                             : ***
Writing application                      : ***
Writing library                          : ***

Video
ID                                       : 1
Format                                   : AVC
Format/Info                              : Advanced Video Codec
Format profile                           : High@L4
Format settings                          : CABAC / 5 Ref Frames
Format settings, CABAC                   : Yes
Format settings, Reference frames        : 5 frames
Format settings, Slice count             : 8 slices per frame
Codec ID                                 : V_MPEG4/ISO/AVC
Duration                                 : 1 h 58 min
Bit rate                                 : 4 459 kb/s
Width                                    : 1 920 pixels
Height                                   : 798 pixels
Display aspect ratio                     : 2.40:1
Frame rate mode                          : Constant
Frame rate                               : 23.976 (24000/1001) FPS
Color space                              : YUV
Chroma subsampling                       : 4:2:0
Bit depth                                : 8 bits
Scan type                                : Progressive
Bits/(Pixel*Frame)                       : 0.121
Stream size                              : 3.69 GiB (88%)
Language                                 : English
Default                                  : Yes
Forced                                   : No
Color range                              : Limited
Color primaries                          : BT.709
Transfer characteristics                 : BT.709
Matrix coefficients                      : BT.709

Audio #1
ID                                       : 2
Format                                   : AC-3
Format/Info                              : Audio Coding 3
Commercial name                          : Dolby Digital
Codec ID                                 : A_AC3
Duration                                 : 1 h 58 min
Bit rate mode                            : Constant
Bit rate                                 : 224 kb/s
Channel(s)                               : 2 channels
Channel layout                           : L R
Sampling rate                            : 48.0 kHz
Frame rate                               : 31.250 FPS (1536 SPF)
Compression mode                         : Lossy
Stream size                              : 190 MiB (4%)
Language                                 : German
Service kind                             : Complete Main
Default                                  : Yes
Forced                                   : Yes
Dialog Normalization                     : -31 dB
dialnorm_Average                         : -31 dB
dialnorm_Minimum                         : -31 dB
dialnorm_Maximum                         : -31 dB

Audio #2
ID                                       : 3
Format                                   : AC-3
Format/Info                              : Audio Coding 3
Commercial name                          : Dolby Digital
Codec ID                                 : A_AC3
Duration                                 : 1 h 58 min
Bit rate mode                            : Constant
Bit rate                                 : 384 kb/s
Channel(s)                               : 6 channels
Channel layout                           : L R C LFE Ls Rs
Sampling rate                            : 48.0 kHz
Frame rate                               : 31.250 FPS (1536 SPF)
Compression mode                         : Lossy
Stream size                              : 325 MiB (8%)
Language                                 : English
Service kind                             : Complete Main
Default                                  : No
Forced                                   : No
Dialog Normalization                     : -26 dB
compr                                    : 0.53 dB
dynrng                                   : 0.27 dB
cmixlev                                  : -3.0 dB
surmixlev                                : -3 dB
ltrtcmixlev                              : -3.0 dB
ltrtsurmixlev                            : -3.0 dB
lorocmixlev                              : -3.0 dB
lorosurmixlev                            : -3.0 dB
dialnorm_Average                         : -26 dB
dialnorm_Minimum                         : -26 dB
dialnorm_Maximum                         : -26 dB

Menu
00:00:00.000                             : en:1
...
```