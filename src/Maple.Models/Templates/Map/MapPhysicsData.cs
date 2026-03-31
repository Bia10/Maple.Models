namespace Maple.Models.Templates.Map;

/// <summary>
/// Physics-engine overrides and physical-world flags for the map.
/// </summary>
/// <param name="Physics">Per-map physics constant overrides; <see langword="null"/> = use global defaults for all constants.</param>
/// <param name="MirrorBottom">Whether a mirror visual effect is rendered at the bottom of the map.</param>
/// <param name="ReactorShuffle">Whether reactor spawn positions are randomized on map load.</param>
/// <param name="Cloud">Whether this is a cloud-type map with floating-cloud rendering.</param>
public sealed record MapPhysicsData(
    MapPhysicsInfo? Physics = null,
    bool MirrorBottom = false,
    bool ReactorShuffle = false,
    bool Cloud = false
);
