namespace Maple.Models.Templates.Map;

/// <summary>Healer NPC position data. Present on guild boss maps.</summary>
/// <param name="X">Healer NPC X coordinate.</param>
/// <param name="Y">Healer NPC Y coordinate.</param>
public readonly record struct MapHealerData(int X, int Y);
