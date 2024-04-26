using RD.MediaInfo.Domain.Enums;
using RD.MediaInfo.Domain.Models.Tracks;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using static RD.MediaInfo.Domain.Configurations.ErrorMessage;

namespace RD.MediaInfo.Converters;

public class TrackConverter : JsonConverter<ITrack>
{
    private readonly Dictionary<StreamKind, Type> _streamKindTypeMapping = new()
    {
        { StreamKind.General, typeof(GeneralTrack) },
        { StreamKind.Video, typeof(VideoTrack) },
        { StreamKind.Audio, typeof(AudioTrack) },
        { StreamKind.Text, typeof(TextTrack) },
        { StreamKind.Image, typeof(ImageTrack) },
        { StreamKind.Menu, typeof(MenuTrack) }
    };

    public TrackConverter()
    {
    }

    public override ITrack? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        JsonNode? node = JsonNode.Parse(ref reader);

        if (node is null)
        {
            throw new JsonException(FailedToParseReaderToNode);
        }

        string typePropertyName = "@type";

        if (node[typePropertyName] is null)
        {
            throw new JsonException(string.Format(PropertyNotFound, typePropertyName));
        }

        string type = node[typePropertyName]!.GetValue<string>();

        if (!Enum.TryParse(type, out StreamKind streamKind))
        {
            throw new JsonException(string.Format(FailedToConvertType, type, typeof(StreamKind)));
        }

        if (!this._streamKindTypeMapping.TryGetValue(streamKind, out Type? trackType))
        {
            throw new NotSupportedException(string.Format(TypeNotSupported, streamKind));
        }

        return this.DeserializeTrack(node, trackType, options);
    }

    public override void Write(Utf8JsonWriter writer, ITrack value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    private ITrack? DeserializeTrack(JsonNode node, Type type, JsonSerializerOptions options)
    {
        JsonObject @object = node.AsObject();

        IReadOnlyList<string> streamSizes = this.GetPropertiesAsList(@object, "StreamSize_String");
        IReadOnlyList<string> fileSizes = this.GetPropertiesAsList(@object, "FileSize_String");
        IReadOnlyList<string> durations = this.GetPropertiesAsList(@object, "Duration_String");
        IReadOnlyList<string> delays = this.GetPropertiesAsList(@object, "Delay_String");
        IReadOnlyList<string> languages = this.GetPropertiesAsList(@object, "Language_String");
        IReadOnlyList<string> videoDelays = this.GetPropertiesAsList(@object, "Video_Delay_String");
        IReadOnlyList<string> formatExtensions = this.GetPropertiesAsList(@object, "Format_Extensions",
            PropertyHandling.Splitting);
        IReadOnlyList<string> videoLanguages = this.GetPropertiesAsList(@object, "Video_Language_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> audioLanguages = this.GetPropertiesAsList(@object, "Audio_Language_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> imageFormats = this.GetPropertiesAsList(@object, "Image_Format_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> imageFormatWithHints = this.GetPropertiesAsList(@object, "Image_Format_WithHint_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> imageCodecs = this.GetPropertiesAsList(@object, "Image_Codec_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> videoFormats = this.GetPropertiesAsList(@object, "Video_Format_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> videoFormatWithHints = this.GetPropertiesAsList(@object, "Video_Format_WithHint_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> videoCodecs = this.GetPropertiesAsList(@object, "Video_Codec_List",
            PropertyHandling.Splitting);
        IReadOnlyList<string> audioFormats = this.GetPropertiesAsList(@object, "Audio_Format_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> audioFormatsWithHints = this.GetPropertiesAsList(@object, "Audio_Format_WithHint_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> audioCodecs = this.GetPropertiesAsList(@object, "Audio_Codec_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> textFormats = this.GetPropertiesAsList(@object, "Text_Format_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> textFormatsWithHints = this.GetPropertiesAsList(@object, "Text_Format_WithHint_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> textCodecs = this.GetPropertiesAsList(@object, "Text_Codec_List",
            PropertyHandling.Splitting, '/');
        IReadOnlyList<string> textLanguages = this.GetPropertiesAsList(@object, "Text_Language_List",
            PropertyHandling.Splitting, '/');

        this.SetProperty(node, "Text_Language_List", textLanguages);
        this.SetProperty(node, "Text_Codec_List", textCodecs);
        this.SetProperty(node, "Text_Format_WithHint_List", textFormatsWithHints);
        this.SetProperty(node, "Text_Format_List", textFormats);
        this.SetProperty(node, "Audio_Language_List", audioLanguages);
        this.SetProperty(node, "Video_Language_List", videoLanguages);
        this.SetProperty(node, "Video_Delay_String", videoDelays);
        this.SetProperty(node, "StreamSize_String", streamSizes);
        this.SetProperty(node, "Language_String", languages);
        this.SetProperty(node, "Delay_String", delays);
        this.SetProperty(node, "FileSize_String", fileSizes);
        this.SetProperty(node, "Duration_String", durations);
        this.SetProperty(node, "Format_Extensions", formatExtensions);
        this.SetProperty(node, "Image_Format_List", imageFormats);
        this.SetProperty(node, "Image_Format_WithHint_List", imageFormatWithHints);
        this.SetProperty(node, "Image_Codec_List", imageCodecs);
        this.SetProperty(node, "Video_Format_List", videoFormats);
        this.SetProperty(node, "Video_Format_WithHint_List", videoFormatWithHints);
        this.SetProperty(node, "Video_Codec_List", videoCodecs);
        this.SetProperty(node, "Audio_Format_List", audioFormats);
        this.SetProperty(node, "Audio_Format_WithHint_List", audioFormatsWithHints);
        this.SetProperty(node, "Audio_Codec_List", audioCodecs);

        ITrack? deserializedValue = node.Deserialize(type, options) as ITrack;

        return deserializedValue;
    }

    private IReadOnlyList<string> GetPropertiesAsList(JsonObject @object, string propertyName,
        PropertyHandling propertyHandling = PropertyHandling.Merging, char seperator = ' ')
    {
        if (propertyHandling == PropertyHandling.Merging)
        {
            List<KeyValuePair<string, JsonNode?>> properties = @object
                .Where(x => x.Key.StartsWith(propertyName))
                .ToList();

            List<string> values = [];
            foreach (KeyValuePair<string, JsonNode?> streamSize in properties)
            {
                string? value = streamSize.Value?.GetValue<string>();

                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                values.Add(value.Trim());
                @object.Remove(streamSize.Key);
            }

            return values;
        }

        if (propertyHandling == PropertyHandling.Splitting)
        {
            if (!@object.TryGetPropertyValue(propertyName, out JsonNode? node))
            {
                return [];
            }

            @object.Remove(propertyName);

            return node!.GetValue<string>().Split(seperator)
                .Select(x => x.Trim())
                .ToList();
        }

        return [];
    }

    private void SetProperty(JsonNode node, string propertyName, IReadOnlyList<string> values)
    {
        if (values.Count == 0)
        {
            return;
        }

        JsonArray jsonArray = [.. values];

        node[propertyName] = jsonArray;
    }
}
