using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Top-level mob catalog entry.
/// </summary>
/// <param name="Id">Mob template ID.</param>
/// <param name="Name">Display name of the mob.</param>
/// <param name="CategoryId">Category classification for the mob.</param>
/// <param name="Type">Movement ability of the mob. <c>null</c> when not resolvable.</param>
/// <param name="Link">When set, animation data is loaded from the linked template.</param>
public sealed record MobTemplateEntry(
    int Id,
    string Name,
    MobCategory? CategoryId = null,
    MobMoveAbility? Type = null,
    MobTemplateId? Link = null
) : TemplateCatalogEntry(Id, Name, Category: CategoryId?.GetDisplayLabel())
{
    /// <summary>Typed wrapper for this entry's mob template ID.</summary>
    public MobTemplateId MobId => new(Id);
}
