namespace Maple.Models.Items.Stats;

/// <summary>
/// Combat stats contributed by an equip item.
/// Groups physical attack, magical attack, accuracy, and evasion into a single value object.
/// </summary>
/// <param name="PAD">Physical attack damage bonus.</param>
/// <param name="MAD">Magic attack damage bonus.</param>
/// <param name="ACC">Accuracy bonus.</param>
/// <param name="EVA">Evasion bonus.</param>
public readonly record struct CombatStats(short PAD, short MAD, short ACC, short EVA);
