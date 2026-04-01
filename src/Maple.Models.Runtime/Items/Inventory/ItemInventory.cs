using System.Text.Json.Serialization;
using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Inventory;

/// <summary>
/// Concrete slot-addressed inventory model used by persisted character data and inventory editors.
/// </summary>
public sealed class ItemInventory : IItemInventory
{
    /// <summary>Maximum number of regular positive slots available in the inventory.</summary>
    [JsonPropertyName("SlotMax")]
    public short SlotMax { get; init; }

    /// <summary>Items keyed by their persisted slot number.</summary>
    [JsonConverter(typeof(InventoryItemsConverter))]
    [JsonPropertyName("Items")]
    public IReadOnlyDictionary<short, IItemSlot> Items { get; init; } = new Dictionary<short, IItemSlot>();

    /// <summary>Creates a detached copy of this inventory and its slot mapping.</summary>
    public ItemInventory ToInventory() =>
        new() { SlotMax = SlotMax, Items = Items.ToDictionary(kvp => kvp.Key, kvp => kvp.Value) };
}
