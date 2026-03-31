using Maple.StrongId;

namespace Maple.Models.Templates.Etc;

/// <summary>
/// Title item metadata.
/// Reactors and title items have no WZ display name; <see cref="TemplateCatalogEntry.Name"/> is set to the numeric ID string.
/// </summary>
/// <param name="Id">Numeric item template identifier.</param>
/// <param name="Name">Numeric ID as string (no display name source).</param>
/// <param name="DateExpire">Expiration date; <see langword="null"/> means no expiry.</param>
/// <param name="OnlyUseInField">Field restricted to this map; <see langword="null"/> means unrestricted.</param>
public sealed record TitleItemEntry(int Id, string Name, DateOnly? DateExpire, FieldTemplateId? OnlyUseInField = null)
    : TemplateCatalogEntry(Id, Name)
{
    /// <summary>Typed wrapper for this entry's item template ID.</summary>
    public ItemTemplateId TitleItemId => new(Id);
}
