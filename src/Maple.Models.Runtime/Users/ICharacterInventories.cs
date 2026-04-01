using Maple.Enums;
using Maple.Models.Items.Inventory;

namespace Maple.Models.Users;

/// <summary>
/// Contract for the five-tab character inventory aggregate.
/// Implemented by <see cref="CharacterInventories"/>.
/// </summary>
public interface ICharacterInventories
{
    /// <summary>Equipment inventory tab.</summary>
    IItemInventory? Equip { get; }

    /// <summary>Consumable inventory tab.</summary>
    IItemInventory? Consume { get; }

    /// <summary>Install inventory tab.</summary>
    IItemInventory? Install { get; }

    /// <summary>Etc (miscellaneous) inventory tab.</summary>
    IItemInventory? Etc { get; }

    /// <summary>Cash inventory tab.</summary>
    IItemInventory? Cash { get; }

    /// <summary>Returns the inventory tab for <paramref name="type"/>, or <see langword="null"/> if absent.</summary>
    IItemInventory? this[ItemInventoryType type] { get; }
}
