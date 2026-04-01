using System.Text.Json.Serialization;
using Maple.Models.Items.Slots;

namespace Maple.Models.Serialization.Inventory;

[JsonSourceGenerationOptions(WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(IItemSlot))]
[JsonSerializable(typeof(ItemSlot))]
[JsonSerializable(typeof(ItemSlotEquip))]
[JsonSerializable(typeof(ItemSlotBundle))]
[JsonSerializable(typeof(ItemSlotPet))]
[JsonSerializable(typeof(IItemSlotBundle))]
[JsonSerializable(typeof(IItemSlotPet))]
[JsonSerializable(typeof(IItemSlotEquip))]
[JsonSerializable(typeof(IItemSlotBase))]
internal sealed partial class ItemSlotJsonContext : JsonSerializerContext;
