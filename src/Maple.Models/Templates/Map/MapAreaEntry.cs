namespace Maple.Models.Templates.Map;

/// <summary>A named sub-area bounding rectangle within a map.</summary>
/// <param name="Id">Sequential identifier of this sub-area within the map.</param>
/// <param name="Bounds">Pixel-coordinate bounding box of the sub-area.</param>
public readonly record struct MapAreaEntry(int Id, MapRect Bounds);
