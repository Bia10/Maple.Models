using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>
/// Top-level field/map catalog entry.
/// Stores the field identity, display name, and street grouping used by map browsers.
/// </summary>
/// <param name="Id">Map/field template ID.</param>
/// <param name="Name">Display name of the map shown in the client UI.</param>
/// <param name="StreetName">Area or region grouping name shown above the map name; <see langword="null"/> if absent.</param>
/// <param name="Help">Tooltip or help text shown for this map entry; <see langword="null"/> if absent.</param>
public sealed record MapTemplateEntry(int Id, string Name, string? StreetName = null, string? Help = null)
    : TemplateCatalogEntry(Id, Name, Category: StreetName)
{
    /// <summary>Typed wrapper for this entry's map/field template ID.</summary>
    public FieldTemplateId FieldId => new(Id);
}
