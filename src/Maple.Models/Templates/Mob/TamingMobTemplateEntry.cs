using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Taming-mob (mount) template entry.
/// </summary>
/// <remarks>
/// Intentionally does not extend <see cref="Maple.Models.Templates.TemplateCatalogEntry"/>.
/// Taming-mob entries sourced from game data may have a null or absent display name,
/// which violates the non-null <c>Name</c> invariant enforced by <c>TemplateCatalogEntry</c>.
/// <see cref="Name"/> is therefore declared as <c>string?</c> and no Id range guard is applied.
/// </remarks>
/// <param name="TamingMobId">Taming-mob template ID, wrapped as <see cref="Maple.StrongId.TamingMobTemplateId"/>.</param>
/// <param name="Name">Display name, if present.</param>
/// <param name="Speed">Mount movement speed.</param>
/// <param name="Jump">Mount jump height.</param>
/// <param name="Fs">Friction scale used while mounted.</param>
/// <param name="Swim">Swim movement modifier.</param>
/// <param name="Fatigue">Fatigue increment applied while riding.</param>
public sealed record TamingMobTemplateEntry(
    TamingMobTemplateId TamingMobId,
    string? Name,
    int Speed,
    int Jump,
    float Fs,
    int Swim,
    int Fatigue
);
