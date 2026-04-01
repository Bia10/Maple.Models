using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable stackable item slot for consumables, install items, etc items, and other non-equip entries.
/// Maps to <c>GW_ItemSlotBundle</c> (PDB), which inherits <c>GW_ItemSlotBase</c>.
/// Runtime state is primarily quantity plus lightweight metadata.
/// </summary>
public sealed class ItemSlotBundle : IItemSlotBundle, IEquatable<ItemSlotBundle>
{
    /// <summary>Item template identifier (<c>GW_ItemSlotBase::nItemID</c>).</summary>
    public ItemTemplateId TemplateId { get; set; }

    /// <summary>
    /// Cash shop transfer serial number (<c>GW_ItemSlotBase::liCashItemSN</c>).
    /// Non-null only when the item originated from a cash-shop purchase.
    /// Distinct from the inventory instance serial (<c>GW_ItemSlotBundle::liSN</c>), which is not persisted here.
    /// </summary>
    public long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp (<c>GW_ItemSlotBase::dateExpire</c>), or <see langword="null"/> when permanent.</summary>
    public DateTime? DateExpire { get; set; }

    /// <summary>Stack quantity in this slot (<c>GW_ItemSlotBundle::nNumber</c>); unsigned short in C++.</summary>
    public ushort Number { get; set; }

    /// <summary>
    /// Item attribute bitfield (<c>GW_ItemSlotBundle::nAttribute</c>).
    /// Bit 0x01 = protected (item lock), 0x02 = prevent slip (anti-drop),
    /// 0x04 = warm support, 0x08 = account-bound, 0x10 = possible trading.
    /// </summary>
    public short Attribute { get; set; }

    /// <summary>
    /// Custom title text embedded in the item instance (<c>GW_ItemSlotBundle::sTitle[13]</c>).
    /// Written by name-tag scrolls; <see langword="null"/> when the item has no custom title.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>Creates a detached copy of this bundle slot.</summary>
    public ItemSlotBundle Clone() =>
        new()
        {
            TemplateId = TemplateId,
            CashItemSN = CashItemSN,
            DateExpire = DateExpire,
            Number = Number,
            Attribute = Attribute,
            Title = Title,
        };

    /// <summary>
    /// Compares bundle identity for merge operations.
    /// Quantity is intentionally excluded so equal bundles can still be stacked together.
    /// </summary>
    public bool Equals(ItemSlotBundle? other)
    {
        if (ReferenceEquals(this, other))
            return true;
        if (other is null)
            return false;

        return TemplateId == other.TemplateId
            && CashItemSN == other.CashItemSN
            && Attribute == other.Attribute
            && string.Equals(Title, other.Title, StringComparison.Ordinal)
            && DateExpire == other.DateExpire;
    }

    /// <inheritdoc/>
    public override bool Equals(object? obj) => Equals(obj as ItemSlotBundle);

    /// <inheritdoc/>
    public override int GetHashCode() => HashCode.Combine(TemplateId, CashItemSN, Attribute, Title, DateExpire);
}
