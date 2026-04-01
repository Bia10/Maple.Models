using System.Text.Json.Serialization;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ItemLocker))]
[JsonSerializable(typeof(IItemLocker))]
[JsonSerializable(typeof(ItemLockerSlot))]
[JsonSerializable(typeof(IItemLockerSlot))]
[JsonSerializable(typeof(List<IItemLockerSlot>))]
internal sealed partial class LockerJsonContext : JsonSerializerContext;
