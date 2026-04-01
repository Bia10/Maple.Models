using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Minimal non-equip item slot implementation.
/// Stores only the item template identity and is used for inventory entries that do not
/// expose equip stat state.
/// </summary>
public sealed class ItemSlot : IItemSlot
{
    /// <summary>Strongly typed item template identifier stored in this slot.</summary>
    public ItemTemplateId TemplateId { get; set; }

    /// <summary>Creates a new plain item slot for the provided item template.</summary>
    public ItemSlot(ItemTemplateId templateId)
    {
        TemplateId = templateId;
    }

    /// <summary>Creates a detached copy of this item slot.</summary>
    public ItemSlot Clone() => new(TemplateId);
}
