using Maple.Enums;
using Maple.Models.Items.Stats;
using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable equip item slot contract used by editor workflows, serializers, and stat applicators.
/// The interface owns the full editable equip surface directly so the model layer does not have to
/// maintain parallel read-only and mutable contracts for the same state.
/// </summary>
public interface IItemSlotEquip : IItemSlotBase
{
    // ── Base slot identity ────────────────────────────────────────────────
    /// <summary>Strongly typed template identifier for the equipped item instance.</summary>
    new ItemTemplateId TemplateId { get; set; }

    /// <summary>Cash shop serial number recorded for cash-origin equips, when present.</summary>
    new long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp for time-limited equips, or <see langword="null"/> when permanent.</summary>
    new DateTime? DateExpire { get; set; }

    // ── Equip-specific mutable stats ──────────────────────────────────────
    /// <summary>Remaining upgrade slots before another scroll or upgrade is applied.</summary>
    byte RUC { get; set; }

    /// <summary>Number of upgrade slots already consumed on this equip.</summary>
    byte CUC { get; set; }

    /// <summary>Primary character stat bonuses stored on the equip instance.</summary>
    CharacterBaseStats BaseStats { get; set; }

    /// <summary>Accuracy, evasion, and attack bonuses stored on the equip instance.</summary>
    CombatStats Combat { get; set; }

    /// <summary>Physical and magical defense bonuses stored on the equip instance.</summary>
    DefenseStats Defense { get; set; }

    /// <summary>Maximum HP bonus granted by the equip.</summary>
    short MaxHP { get; set; }

    /// <summary>Maximum MP bonus granted by the equip.</summary>
    short MaxMP { get; set; }

    /// <summary>Crafting stat bonus granted by the equip.</summary>
    short Craft { get; set; }

    /// <summary>Movement-speed bonus granted by the equip.</summary>
    short Speed { get; set; }

    /// <summary>Jump-stat bonus granted by the equip.</summary>
    short Jump { get; set; }

    /// <summary>Custom title text attached to the equip instance, if any.</summary>
    string? Title { get; set; }

    /// <summary>Raw attribute bitfield persisted with the equip instance.</summary>
    short Attribute { get; set; }

    /// <summary>Enhancement progression mode used by the equip's growth system.</summary>
    byte LevelUpType { get; set; }

    /// <summary>Current enhancement level applied to the equip instance.</summary>
    byte Level { get; set; }

    /// <summary>Accumulated item experience used by growth-enabled equips.</summary>
    int EXP { get; set; }

    /// <summary>Remaining durability for breakable equips, or <see langword="null"/> when unused.</summary>
    int? Durability { get; set; }

    /// <summary>Hammer or innocence-related upgrade counter persisted on the equip.</summary>
    int IUC { get; set; }

    /// <summary>Potential rank currently applied to the equip.</summary>
    ItemGrade Grade { get; set; }

    /// <summary>Star-force or chaos-enhancement count applied to the equip.</summary>
    byte CHUC { get; set; }

    /// <summary>First potential option identifier.</summary>
    short Option1 { get; set; }

    /// <summary>Second potential option identifier.</summary>
    short Option2 { get; set; }

    /// <summary>Third potential option identifier.</summary>
    short Option3 { get; set; }

    /// <summary>First socketed option identifier.</summary>
    short Socket1 { get; set; }

    /// <summary>Second socketed option identifier.</summary>
    short Socket2 { get; set; }
}
