using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Storage;

/// <summary>
/// Concrete shared-account trunk storage model used by editors and persistence layers.
/// </summary>
public sealed class ItemTrunk : IItemTrunk
{
    /// <summary>Mesos stored in the trunk.</summary>
    public int Money { get; set; }

    /// <summary>Maximum number of trunk slots available.</summary>
    public short SlotMax { get; set; }

    /// <summary>Mutable collection on the concrete type; exposed read-only via <see cref="IItemTrunk"/>.</summary>
    public IList<IItemSlot> Items { get; set; } = [];

    IReadOnlyCollection<IItemSlot> IItemTrunk.Items => [.. Items];
}
