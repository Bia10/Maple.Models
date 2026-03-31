namespace Maple.Models.Templates.Item;

/// <summary>
/// Elemental resistance bonuses on an equip item.
/// </summary>
/// <param name="Poison">Poison resistance bonus.</param>
/// <param name="Ice">Ice resistance bonus.</param>
/// <param name="Fire">Fire resistance bonus.</param>
/// <param name="Lightning">Lightning resistance bonus.</param>
/// <param name="Holy">Holy resistance bonus.</param>
public readonly record struct ItemEquipElementResist(int Poison, int Ice, int Fire, int Lightning, int Holy);
