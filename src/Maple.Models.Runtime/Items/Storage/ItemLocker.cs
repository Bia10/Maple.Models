namespace Maple.Models.Items.Storage;

/// <summary>
/// Concrete item locker model used by persistence layers and administrative editors.
/// </summary>
public sealed class ItemLocker : IItemLocker
{
    /// <summary>Maximum number of slots exposed by the locker.</summary>
    public short SlotMax { get; init; }

    /// <summary>Ordered locker-slot collection.</summary>
    public IReadOnlyList<IItemLockerSlot> Items { get; init; } = [];
}
