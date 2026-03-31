namespace Maple.Models.Templates.Item;

/// <summary>Periodic HP/MP regeneration or drain from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="HpChangePerTime">HP delta applied per periodic tick; positive = heal, negative = drain.</param>
/// <param name="MpChangePerTime">MP delta applied per periodic tick; positive = heal, negative = drain.</param>
public readonly record struct AdditionHpMpChange(
    AdditionCondition? Condition,
    int HpChangePerTime,
    int MpChangePerTime
);
