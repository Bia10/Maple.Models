using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Storage;

/// <summary>
/// Shared-account trunk storage model containing mesos and an ordered collection of stored items.
/// </summary>
public interface IItemTrunk
{
    /// <summary>Mesos stored in the trunk.</summary>
    int Money { get; set; }

    /// <summary>Maximum number of trunk slots available.</summary>
    short SlotMax { get; set; }

    /// <summary>The ordered item collection stored in the trunk.</summary>
    IReadOnlyCollection<IItemSlot> Items { get; }
}
