using System.Text.Json;
using System.Text.Json.Serialization;

namespace RD.MediaInfo.Converters;

public class StringToDoubleConverter : JsonConverter<double>
{
    public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        double.TryParse(value, out double result);

        return result;
    }

    public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
