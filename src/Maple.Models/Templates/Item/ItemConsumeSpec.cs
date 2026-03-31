namespace Maple.Models.Templates.Item;

/// <summary>
/// Buff and scroll effects for a consumable item.
/// For buff potions the fields encode temporary stat bonuses and their duration.
/// For scrolls they encode the stat deltas applied to equipment on success, plus chance values.
/// Null means the field is absent; the effect does not apply.
/// </summary>
/// <param name="Pad">Physical attack buff applied for the duration.</param>
/// <param name="Pdd">Physical defense buff applied for the duration.</param>
/// <param name="Mad">Magic attack buff applied for the duration.</param>
/// <param name="Mdd">Magic defense buff applied for the duration.</param>
/// <param name="Acc">Accuracy buff applied for the duration.</param>
/// <param name="Eva">Evasion buff applied for the duration.</param>
/// <param name="Craft">Crafting / dexterity buff applied for the duration.</param>
/// <param name="Speed">Movement-speed buff applied for the duration.</param>
/// <param name="Jump">Jump buff applied for the duration.</param>
/// <param name="Time">Buff duration. Absent on instant-recovery items.</param>
/// <param name="Hp">Flat HP restored immediately on use.</param>
/// <param name="Mp">Flat MP restored immediately on use.</param>
/// <param name="HpR">HP restored as percentage of max HP.</param>
/// <param name="MpR">MP restored as percentage of max MP.</param>
/// <param name="AreaBuffType">AoE buff type code; non-zero triggers party-wide buff lookup.</param>
/// <param name="IncStr">Scroll: STR added to equipment on success. Buff item: STR bonus for duration.</param>
/// <param name="IncDex">Scroll: DEX added to equipment on success. Buff item: DEX bonus for duration.</param>
/// <param name="IncInt">Scroll: INT added to equipment on success. Buff item: INT bonus for duration.</param>
/// <param name="IncLuk">Scroll: LUK added to equipment on success. Buff item: LUK bonus for duration.</param>
public sealed record ItemConsumeSpec(
    int? Pad = null,
    int? Pdd = null,
    int? Mad = null,
    int? Mdd = null,
    int? Acc = null,
    int? Eva = null,
    int? Craft = null,
    int? Speed = null,
    int? Jump = null,
    int? Time = null,
    int? Hp = null,
    int? Mp = null,
    int? HpR = null,
    int? MpR = null,
    int? AreaBuffType = null,
    int? IncStr = null,
    int? IncDex = null,
    int? IncInt = null,
    int? IncLuk = null
);
