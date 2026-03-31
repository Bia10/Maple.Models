namespace Maple.Models.Templates.Item;

/// <summary>Boss-damage bonus from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="Prob">Activation probability weight.</param>
/// <param name="Damage">Boss-damage percentage bonus applied when the bonus activates.</param>
public readonly record struct AdditionBoss(AdditionCondition? Condition, int Prob, int Damage);
