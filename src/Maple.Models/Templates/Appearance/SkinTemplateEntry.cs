namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Catalog entry for a selectable skin tone used by character appearance data.
/// </summary>
/// <param name="Id">Skin tone identifier.</param>
/// <param name="Name">Hardcoded display label (e.g. "Light", "Tanned").</param>
public sealed record SkinTemplateEntry(int Id, string Name) : TemplateCatalogEntry(Id, Name);
