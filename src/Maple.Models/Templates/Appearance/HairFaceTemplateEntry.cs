using Maple.StrongId;

namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Catalog entry for a hair or face style, backed by an equip item template ID.
/// </summary>
/// <param name="Id">Hair or face item template ID.</param>
/// <param name="Name">Display name for the hair or face style.</param>
public sealed record HairFaceTemplateEntry(int Id, string Name) : TemplateCatalogEntry(Id, Name)
{
    /// <summary>Typed wrapper for the underlying item template ID.</summary>
    public ItemTemplateId ItemId => new(Id);
}
