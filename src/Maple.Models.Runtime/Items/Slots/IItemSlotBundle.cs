using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable contract for stackable or otherwise non-equip inventory entries that carry
/// quantity, title, and attribute metadata in addition to the common slot identity.
/// </summary>
public interface IItemSlotBundle : IItemSlotBase
{
    /// <summary>Strongly typed template identifier for the item instance.</summary>
    new ItemTemplateId TemplateId { get; set; }

    /// <summary>Cash shop serial number recorded for cash-origin items, when present.</summary>
    new long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp for time-limited items, or <see langword="null"/> when permanent.</summary>
    new DateTime? DateExpire { get; set; }

    /// <summary>Stack quantity stored in the slot (<c>GW_ItemSlotBundle::nNumber</c>; unsigned short in C++).</summary>
    ushort Number { get; set; }

    /// <summary>Custom title text attached to the item instance, if any.</summary>
    string? Title { get; set; }

    /// <summary>Raw attribute bitfield persisted for the item instance.</summary>
    short Attribute { get; set; }
}
