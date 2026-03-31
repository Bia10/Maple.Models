namespace Maple.Models.Templates.Item;

/// <summary>A named stat value emitted by an item level-up stage or random potential roll.</summary>
/// <param name="Name">Raw stat key name from the template data.</param>
/// <param name="Value">Numeric value associated with <paramref name="Name"/>.</param>
public readonly record struct ItemLevelStat(string Name, int Value);
