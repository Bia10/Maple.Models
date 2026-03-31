using Maple.Enums;

namespace Maple.Models.Templates.Item;

/// <summary>Elemental-damage boost from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="ElemType">Element type of the damage boost.</param>
/// <param name="Volume">Elemental-damage percentage boost value.</param>
public readonly record struct AdditionElemBoost(AdditionCondition? Condition, Element ElemType, int Volume);
