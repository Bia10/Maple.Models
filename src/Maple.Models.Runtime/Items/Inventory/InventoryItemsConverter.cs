using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Maple.Models.Items.Slots;
using Maple.Models.Serialization.Inventory;

namespace Maple.Models.Items.Inventory;

/// <summary>
/// JSON converter for slot-addressed inventories whose values are serialized through the
/// <see cref="IItemSlot"/> polymorphic contract.
/// </summary>
internal sealed class InventoryItemsConverter : JsonConverter<IReadOnlyDictionary<short, IItemSlot>>
{
    /// <inheritdoc/>
    public override IReadOnlyDictionary<short, IItemSlot> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var dictionary = new Dictionary<short, IItemSlot>();

        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException("Expected start of JSON object for inventory.");

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException("Expected property name (slot key).");

            var key = reader.GetString()!;
            if (!short.TryParse(key, NumberStyles.Integer, CultureInfo.InvariantCulture, out short slot))
                throw new JsonException(
                    $"Invalid inventory slot key '{key}'. Expected a 16-bit signed integer slot number."
                );

            reader.Read();
            var item = JsonSerializer.Deserialize(ref reader, InventoryJsonContext.Default.IItemSlot);
            if (item is not null)
                dictionary.Add(slot, item);
        }

        return dictionary;
    }

    /// <inheritdoc/>
    public override void Write(
        Utf8JsonWriter writer,
        IReadOnlyDictionary<short, IItemSlot> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStartObject();
        foreach ((short slot, IItemSlot item) in value)
        {
            writer.WritePropertyName(slot.ToString(CultureInfo.InvariantCulture));
            JsonSerializer.Serialize(writer, item, InventoryJsonContext.Default.IItemSlot);
        }

        writer.WriteEndObject();
    }
}
