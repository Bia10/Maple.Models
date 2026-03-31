namespace Maple.Models.Items.Stats;

/// <summary>
/// Defense stats contributed by an equip item.
/// Groups physical and magical defense into a single value object.
/// </summary>
/// <param name="PDD">Physical defense bonus.</param>
/// <param name="MDD">Magic defense bonus.</param>
public readonly record struct DefenseStats(short PDD, short MDD);
