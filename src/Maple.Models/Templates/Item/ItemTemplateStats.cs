using Maple.StrongId;

namespace Maple.Models.Templates.Item;

// Intentionally an init-property record, not positional.
// The 34 fields are sparsely populated from WZ data — most equips only set a handful.
// Positional syntax would require all 34 arguments at every call site.
// Consumers that need an "empty" stats object construct with `new ItemTemplateStats()`.
/// <summary>
/// Sparse stat payload for equip templates.
/// Short fields are basic incremental stat bonuses; int fields encode special rates or overrides.
/// Absent fields default to zero — callers should treat zero as "no bonus" unless noted otherwise.
/// </summary>
public sealed record ItemTemplateStats
{
    /// <summary>STR bonus granted by the equip.</summary>
    public short IncSTR { get; init; }

    /// <summary>DEX bonus granted by the equip.</summary>
    public short IncDEX { get; init; }

    /// <summary>INT bonus granted by the equip.</summary>
    public short IncINT { get; init; }

    /// <summary>LUK bonus granted by the equip.</summary>
    public short IncLUK { get; init; }

    /// <summary>Flat max-HP bonus granted by the equip.</summary>
    public int IncMaxHP { get; init; }

    /// <summary>Flat max-MP bonus granted by the equip.</summary>
    public int IncMaxMP { get; init; }

    /// <summary>Physical attack bonus granted by the equip.</summary>
    public short IncPAD { get; init; }

    /// <summary>Magic attack bonus granted by the equip.</summary>
    public short IncMAD { get; init; }

    /// <summary>Physical defense bonus granted by the equip.</summary>
    public short IncPDD { get; init; }

    /// <summary>Magic defense bonus granted by the equip.</summary>
    public short IncMDD { get; init; }

    /// <summary>Accuracy bonus granted by the equip.</summary>
    public short IncACC { get; init; }

    /// <summary>Evasion bonus granted by the equip.</summary>
    public short IncEVA { get; init; }

    /// <summary>Crafting / dexterity bonus granted by the equip.</summary>
    public short IncCraft { get; init; }

    /// <summary>Movement-speed bonus granted by the equip.</summary>
    public short IncSpeed { get; init; }

    /// <summary>Jump bonus granted by the equip.</summary>
    public short IncJump { get; init; }

    /// <summary>Boss-damage-rate bonus in percent granted by the equip.</summary>
    public short IncBDR { get; init; }

    /// <summary>Ignore-monster-defense-rate bonus in percent granted by the equip.</summary>
    public short IncIMDR { get; init; }

    /// <summary>All-damage-rate bonus in percent granted by the equip.</summary>
    public short IncRDamage { get; init; }

    /// <summary>Percentage max-HP bonus granted by the equip.</summary>
    public short IncMaxHPr { get; init; }

    /// <summary>Percentage max-MP bonus granted by the equip.</summary>
    public short IncMaxMPr { get; init; }

    /// <summary>Swimming-speed delta (stat increment) granted by the equip.</summary>
    public short IncSwim { get; init; }

    /// <summary>Fatigue increment granted by the equip (used for mount/taming items).</summary>
    public short IncFatigue { get; init; }

    /// <summary>Knockback-percent value for weapons; affects stagger applied to targets.</summary>
    public int Knockback { get; init; }

    /// <summary>HP recovery coefficient granted by the equip.</summary>
    public int Recovery { get; init; }

    /// <summary>Ground traction / friction coefficient override granted by the equip.</summary>
    public int Fs { get; init; }

    /// <summary>Mount/taming swim-speed override.</summary>
    public int Swim { get; init; }

    /// <summary>Taming-mob identifier associated with this equip.</summary>
    public TamingMobTemplateId? TamingMob { get; init; }

    /// <summary>Percentage physical-defense bonus granted by the equip.</summary>
    public int PddR { get; init; }

    /// <summary>Percentage magic-defense bonus granted by the equip.</summary>
    public int MddR { get; init; }

    /// <summary>Percentage all-stat damage bonus granted by the equip.</summary>
    public int DamR { get; init; }

    /// <summary>Flat HP bonus (used on accessories).</summary>
    public int Hp { get; init; }

    /// <summary>Flat MP bonus (used on accessories).</summary>
    public int Mp { get; init; }
}
