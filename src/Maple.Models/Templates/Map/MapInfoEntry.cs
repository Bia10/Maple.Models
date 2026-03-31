namespace Maple.Models.Templates.Map;

/// <summary>Aggregated map metadata loaded on-demand.</summary>
/// <param name="Constraints">Movement and access restrictions for the map.</param>
/// <param name="Environment">Ambient and gameplay environment settings.</param>
/// <param name="PhysicsData">Per-map physics overrides; global defaults apply when absent.</param>
/// <param name="Events">Optional event sections (ship, carnival, clock, healer, pulley).</param>
/// <param name="HelpMessages">Sequential help tip strings displayed to new players entering the map.</param>
/// <param name="Portals">All portal entries for the map.</param>
/// <param name="SeatPositions">Absolute x/y positions of chair tiles in the map.</param>
/// <param name="SwimRects">Rectangles that define water/swim zones.</param>
/// <param name="FootholdCount">Total number of foothold segments across all layers.</param>
/// <param name="Backgrounds">Background layer entries.</param>
/// <param name="Areas">Named rectangular areas used for scripted triggers.</param>
public sealed record MapInfoEntry(
    MapConstraints Constraints,
    MapEnvironmentData Environment,
    MapPhysicsData PhysicsData,
    MapEventData Events,
    IReadOnlyList<string>? HelpMessages = null,
    IReadOnlyList<MapPortalEntry>? Portals = null,
    IReadOnlyList<MapPoint>? SeatPositions = null,
    IReadOnlyList<MapRect>? SwimRects = null,
    int FootholdCount = 0,
    IReadOnlyList<MapBackgroundEntry>? Backgrounds = null,
    IReadOnlyList<MapAreaEntry>? Areas = null
);
