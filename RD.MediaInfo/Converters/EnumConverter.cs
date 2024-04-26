using RD.Extensions.Enums.Contracts;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RD.MediaInfo.Converters;

public sealed class EnumConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : Enum
{
    private readonly IEnumCache _enumCache;

    public EnumConverter(IEnumCache enumCache)
    {
        this._enumCache = enumCache ?? throw new ArgumentNullException(nameof(enumCache));
    }

    public override TEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if (string.IsNullOrWhiteSpace(value))
        {
            return default;
        }

        TEnum? targetValue = this._enumCache.GetEnumValueByAttributeValue<TEnum, string>(value);

        return targetValue;
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
