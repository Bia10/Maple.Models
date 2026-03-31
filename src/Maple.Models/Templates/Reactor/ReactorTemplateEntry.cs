using Maple.StrongId;

namespace Maple.Models.Templates.Reactor;

/// <summary>
/// Reactor template catalog entry.
/// Reactors have no display name; the <c>Name</c> parameter is set to the numeric ID as a string.
/// </summary>
/// <param name="Id">Reactor template identifier.</param>
/// <param name="Name">Numeric ID as string (no display name source); set to <c>id.ToString()</c> by default.</param>
public sealed record ReactorTemplateEntry(int Id, string Name) : TemplateCatalogEntry(Id, Name)
{
    /// <summary>Typed wrapper for this entry's reactor template ID.</summary>
    public ReactorTemplateId ReactorId => new(Id);
}
