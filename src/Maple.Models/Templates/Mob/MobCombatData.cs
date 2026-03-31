namespace Maple.Models.Templates.Mob;

/// <summary>
/// Combat-facing stats, resistances, attacks, and skills for a mob.
/// See <see cref="MobCoreStats"/> and <see cref="MobBehaviorFlags"/> for field-level documentation.
/// </summary>
/// <param name="Stats">Core level, HP/MP, attack/defense, and speed stats.</param>
/// <param name="Behavior">Boolean behavioral and visibility flags.</param>
/// <param name="HPRecovery">Flat HP recovered per regen tick.</param>
/// <param name="MPRecovery">Flat MP recovered per regen tick.</param>
/// <param name="FixedDamage">When non-zero, all damage dealt by the mob is exactly this value regardless of stats.</param>
/// <param name="ElemAttr">Elemental attribute string governing how the mob applies and resists elements.</param>
/// <param name="ElementResistances">Decoded per-element resistance or weakness entries.</param>
/// <param name="AttackCount">Number of attack entries defined on the mob template.</param>
/// <param name="SkillCount">Number of skill entries defined on the mob template.</param>
/// <param name="Attacks">Attack summaries for this mob.</param>
/// <param name="Skills">Skill entries for this mob.</param>
public sealed record MobCombatData(
    MobCoreStats Stats,
    MobBehaviorFlags Behavior,
    int HPRecovery,
    int MPRecovery,
    int FixedDamage,
    string? ElemAttr,
    IReadOnlyList<MobElementResistance> ElementResistances,
    int AttackCount,
    int SkillCount,
    IReadOnlyList<MobAttackSummary> Attacks,
    IReadOnlyList<MobSkillEntry> Skills
);
