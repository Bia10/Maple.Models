using Maple.StrongId;

namespace Maple.Models.Templates.SetItem;

/// <summary>Equipment set bonus definition.
/// A set activates bonus stats when the player simultaneously equips N or more items from the set.</summary>
/// <param name="SetId">Numeric set identifier.</param>
/// <param name="Name">Display name of the set shown in the item tooltip.</param>
/// <param name="ItemIds">All item template IDs that belong to this set.</param>
/// <param name="Effects">Bonus stat tiers, one entry per piece-count threshold.</param>
public sealed record SetItemInfoEntry(
    int SetId,
    string Name,
    IReadOnlyList<ItemTemplateId> ItemIds,
    IReadOnlyList<SetItemEffect> Effects
) : TemplateCatalogEntry(SetId, Name)
{
    /// <summary>Gets the strongly typed set-item template identifier.</summary>
    public SetItemTemplateId SetItemId => new(SetId);
}
