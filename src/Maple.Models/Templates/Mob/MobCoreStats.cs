namespace Maple.Models.Templates.Mob;

/// <summary>
/// Core combat stats for a mob.
/// </summary>
/// <param name="Level">Mob display level shown in the HP tag.</param>
/// <param name="MaxHP">Maximum hit points. Template value; server tracks current HP; client uses this for HP bar percentage display.</param>
/// <param name="MaxMP">Maximum mana points. Consumed by mob skills that cost MP.</param>
/// <param name="PADamage">Physical attack damage.</param>
/// <param name="MADamage">Magic attack damage.</param>
/// <param name="PDRate">Physical defense rate as a percentage.</param>
/// <param name="MDRate">Magic defense rate as a percentage.</param>
/// <param name="Accuracy">Accuracy stat used in hit calculations against player evasion.</param>
/// <param name="Evasion">Evasion stat used in miss-chance calculations when players attack.</param>
/// <param name="Exp">Base EXP granted when the mob is defeated.</param>
/// <param name="Speed">Ground movement speed.</param>
/// <param name="FlySpeed">Flight speed for mobs with fly movement ability.</param>
public readonly record struct MobCoreStats(
    int Level,
    long MaxHP,
    int MaxMP,
    int PADamage,
    int MADamage,
    int PDRate,
    int MDRate,
    int Accuracy,
    int Evasion,
    int Exp,
    int Speed,
    int FlySpeed
);
