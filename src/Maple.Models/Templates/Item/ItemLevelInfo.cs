namespace Maple.Models.Templates.Item;

/// <summary>
/// Per-level stat bundle for level-scaling equip items.
/// </summary>
/// <param name="Level">Item level described by this stat bundle.</param>
/// <param name="Stats">Stat key-value pairs for this level.</param>
public sealed record ItemLevelInfo(int Level, IReadOnlyList<ItemLevelStat> Stats);
