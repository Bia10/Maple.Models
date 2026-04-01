using System.Text.Json.Serialization;

namespace Maple.Models.Items.Storage;

/// <summary>
/// Cash-shop style item locker model containing ordered locker slots and a slot-cap limit.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ItemLocker))]
public interface IItemLocker
{
    /// <summary>Maximum number of slots exposed by the locker.</summary>
    short SlotMax { get; init; }

    /// <summary>Ordered locker-slot collection.</summary>
    IReadOnlyList<IItemLockerSlot> Items { get; }
}
