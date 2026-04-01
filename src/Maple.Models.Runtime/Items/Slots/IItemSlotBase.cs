namespace Maple.Models.Items.Slots;

/// <summary>
/// Base item-slot contract for persisted inventory entries that may carry cash serial
/// metadata and an expiration timestamp in addition to the item template identity.
/// </summary>
public interface IItemSlotBase : IItemSlot
{
    /// <summary>Cash shop serial number when the item originates from a cash purchase.</summary>
    long? CashItemSN { get; }

    /// <summary>Expiration time for time-limited items, or <see langword="null"/> when permanent.</summary>
    DateTime? DateExpire { get; }
}
