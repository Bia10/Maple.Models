using System.Text.Json.Serialization;
using Maple.Models.Items.Slots;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ItemTrunk))]
[JsonSerializable(typeof(IItemSlot))]
[JsonSerializable(typeof(ItemSlot))]
[JsonSerializable(typeof(ItemSlotEquip))]
[JsonSerializable(typeof(ItemSlotBundle))]
[JsonSerializable(typeof(ItemSlotPet))]
internal sealed partial class TrunkJsonContext : JsonSerializerContext;
