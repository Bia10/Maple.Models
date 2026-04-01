using System.Text.Json;
using System.Text.Json.Serialization;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Custom converter for <see cref="IItemLocker"/> that deserializes via the registered derived-type metadata.
/// </summary>
internal sealed class ItemLockerConverter : JsonConverter<IItemLocker>
{
    public override IItemLocker? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        JsonSerializer.Deserialize(ref reader, LockerJsonContext.Default.ItemLocker);

    public override void Write(Utf8JsonWriter writer, IItemLocker value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, (ItemLocker)value, LockerJsonContext.Default.ItemLocker);
}
