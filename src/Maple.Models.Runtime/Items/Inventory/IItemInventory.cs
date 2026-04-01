using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Inventory;

/// <summary>
/// Slot-addressed item inventory for a single inventory category such as Equip, Consume,
/// Install, Etc, or Cash.
/// </summary>
public interface IItemInventory
{
    /// <summary>Maximum number of regular positive slots available in the inventory.</summary>
    short SlotMax { get; }

    /// <summary>Items keyed by their persisted slot number.</summary>
    IReadOnlyDictionary<short, IItemSlot> Items { get; }
}
