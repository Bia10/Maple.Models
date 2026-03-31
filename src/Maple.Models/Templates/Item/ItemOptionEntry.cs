namespace Maple.Models.Templates.Item;

/// <summary>Composite entry aggregating the static metadata and per-level stat tables for a single potential option.</summary>
/// <param name="OptionId">Numeric identifier of the potential option.</param>
/// <param name="Info">Static metadata shared across all levels of this option.</param>
/// <param name="Levels">Per-level stat entries, index 0 = level 1.</param>
public sealed record ItemOptionEntry(int OptionId, ItemOptionInfo Info, IReadOnlyList<ItemOptionLevelData> Levels);
