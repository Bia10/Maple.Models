namespace Maple.Models.Templates.Map;

/// <summary>Pulley mechanism data. Present on guild boss maps.</summary>
/// <param name="X">Pulley mechanism X coordinate.</param>
/// <param name="Y">Pulley mechanism Y coordinate.</param>
/// <param name="Hp">HP threshold value used by the guild boss pulley mechanic.</param>
public readonly record struct MapPulleyData(int X, int Y, int? Hp);
