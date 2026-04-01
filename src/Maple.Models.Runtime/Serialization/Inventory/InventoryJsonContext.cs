using System.Text.Json;
using System.Text.Json.Serialization;
using Maple.Models.Items.Inventory;
using Maple.Models.Items.Slots;
using Maple.Models.Users;

namespace Maple.Models.Serialization.Inventory;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(CharacterInventories))]
[JsonSerializable(typeof(ItemInventory))]
[JsonSerializable(typeof(Dictionary<short, IItemSlot>))]
[JsonSerializable(typeof(IItemSlot))]
[JsonSerializable(typeof(ItemSlot))]
[JsonSerializable(typeof(ItemSlotEquip))]
[JsonSerializable(typeof(ItemSlotBundle))]
[JsonSerializable(typeof(ItemSlotPet))]
[JsonSerializable(typeof(Dictionary<string, JsonElement>))]
internal sealed partial class InventoryJsonContext : JsonSerializerContext;
