using Maple.Enums;

namespace Maple.Models.Templates.Item;

/// <summary>Mob-category damage bonus from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="Category">Mob category enumeration value that receives the bonus.</param>
/// <param name="Damage">Damage percentage bonus applied against the specified mob category.</param>
public readonly record struct AdditionMobCategory(AdditionCondition? Condition, MobCategory Category, int Damage);
