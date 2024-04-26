using System.Globalization;
using System.Text.Json;

namespace RD.MediaInfo.Domain.Enums;

public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    private readonly string[] _supportedFormats = [
        "yyyy-MM-dd HH:mm:ss 'UTC'",
        "yyyy-MM-dd HH:mm:ss.fff 'UTC'",
        "yyyy-MM-ddTHH:mm:ss.fffZ",
        "yyyy-MM-ddTHH:mm:ss.ffffffZ"
    ];

    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if (string.IsNullOrWhiteSpace(value))
        {
            return DateTimeOffset.MinValue;
        }

        if (DateTimeOffset.TryParseExact(value, _supportedFormats, CultureInfo.InvariantCulture,
            DateTimeStyles.None, out DateTimeOffset result))
        {
            return result;
        }

        return default;
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
