using Maple.StrongId;

namespace Maple.Models.Templates.Etc;

/// <summary>
/// Morph/transform template entry.
/// </summary>
/// <param name="Id">Numeric morph identifier.</param>
/// <param name="Name">Display name; falls back to the numeric ID string when absent in WZ.</param>
/// <param name="Speed">Movement speed.</param>
/// <param name="Jump">Jump power.</param>
/// <param name="Fs">Friction scale used by morph movement physics.</param>
/// <param name="Swim">Swim movement modifier.</param>
/// <param name="MorphEffect">Whether the morph plays the morph-effect visual.</param>
/// <param name="SuperMan">Whether the morph enables super-man movement behavior.</param>
/// <param name="Hide">Whether the character is hidden while morphed.</param>
/// <param name="Attackable">Whether attacking is allowed.</param>
/// <param name="Movability">Movement capability mode.</param>
public sealed record MorphTemplateEntry(
    int Id,
    string Name,
    int Speed,
    int Jump,
    float Fs,
    int Swim,
    bool MorphEffect,
    bool SuperMan,
    bool Hide,
    bool Attackable,
    int Movability = 0
) : TemplateCatalogEntry(Id, Name)
{
    /// <summary>Typed wrapper for this entry's morph template ID.</summary>
    public MorphTemplateId MorphId => new(Id);
}
