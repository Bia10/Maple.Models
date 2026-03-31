namespace Maple.Models.Templates.SetItem;

/// <summary>
/// A single stat bonus entry from a set-item effect tier.
/// </summary>
/// <param name="Stat">Stat key name identifying which character stat receives the bonus.</param>
/// <param name="Value">Bonus amount applied to the stat when the set threshold is met.</param>
public readonly record struct SetItemStatBonus(string Stat, int Value);
