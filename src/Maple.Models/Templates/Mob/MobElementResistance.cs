using Maple.Enums;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// A single elemental resistance entry for a mob.
/// </summary>
/// <param name="ElemType">Element that the resistance entry applies to.</param>
/// <param name="Tier">Resistance or weakness tier for the element.</param>
public readonly record struct MobElementResistance(Element ElemType, ElemResistanceTier Tier);
