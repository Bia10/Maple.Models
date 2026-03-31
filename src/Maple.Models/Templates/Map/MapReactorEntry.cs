using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>A reactor spawn configuration on a map.</summary>
/// <param name="TemplateId">Reactor template identifier.</param>
/// <param name="X">Map X coordinate of the reactor origin in pixels.</param>
/// <param name="Y">Map Y coordinate of the reactor origin in pixels.</param>
/// <param name="FaceDirection">Flip/facing flag: 0 = default orientation, 1 = mirrored.</param>
/// <param name="Name">Optional instance name used to link this reactor to portal triggers; <see langword="null"/> = unnamed.</param>
/// <param name="ReactorTime">Optional respawn delay in milliseconds after the reactor is destroyed; <see langword="null"/> = immediate or no respawn.</param>
public readonly record struct MapReactorEntry(
    ReactorTemplateId TemplateId,
    int X,
    int Y,
    int FaceDirection,
    string? Name = null,
    int? ReactorTime = null
);
