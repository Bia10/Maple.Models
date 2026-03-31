namespace Maple.Models.Items.Stats;

/// <summary>
/// Base attribute stats contributed by an equip item.
/// Groups the four core character attributes into a single value object.
/// </summary>
/// <param name="STR">Strength bonus granted by the equip.</param>
/// <param name="DEX">Dexterity bonus granted by the equip.</param>
/// <param name="INT">Intelligence bonus granted by the equip.</param>
/// <param name="LUK">Luck bonus granted by the equip.</param>
public readonly record struct CharacterBaseStats(short STR, short DEX, short INT, short LUK);
