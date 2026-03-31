namespace Maple.Models.Templates.WorldMap;

/// <summary>A world map hyperlink used to navigate between world map views.</summary>
/// <param name="ToolTip">Tooltip text displayed on hover.</param>
/// <param name="LinkMap">Target world map image name.</param>
/// <param name="LinkImg">Link panel image resource, if any.</param>
public readonly record struct WorldMapLinkEntry(string? ToolTip, string? LinkMap, string? LinkImg);
