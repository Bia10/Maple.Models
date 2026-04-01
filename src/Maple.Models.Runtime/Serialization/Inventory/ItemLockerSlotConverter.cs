using System.Text.Json;
using System.Text.Json.Serialization;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Custom converter for <see cref="IItemLockerSlot"/> using the shared concrete locker-slot shape.
/// </summary>
internal sealed class ItemLockerSlotConverter : JsonConverter<IItemLockerSlot>
{
    public override IItemLockerSlot? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    ) => JsonSerializer.Deserialize(ref reader, LockerJsonContext.Default.ItemLockerSlot);

    public override void Write(Utf8JsonWriter writer, IItemLockerSlot value, JsonSerializerOptions options) =>
        JsonSerializer.Serialize(writer, (ItemLockerSlot)value, LockerJsonContext.Default.ItemLockerSlot);
}
