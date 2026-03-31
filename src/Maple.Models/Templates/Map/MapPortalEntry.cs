using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>
/// A map portal entry.
/// </summary>
/// <param name="Name">Portal name used as destination identifier when other portals reference this map.</param>
/// <param name="Type">Portal behavior type (see <see cref="MapPortalType"/> enum).</param>
/// <param name="Position">Portal world-space position in pixels.</param>
/// <param name="TargetMapId">Destination map; absent indicates no external target.</param>
/// <param name="TargetName">Destination portal name in the target map.</param>
/// <param name="Script">Server script identifier executed on use (script portal types).</param>
/// <param name="OnlyOnce">Whether the portal can only be used once per session.</param>
/// <param name="Delay">Teleport delay before the player is moved.</param>
/// <param name="HideTooltip">Whether to suppress the map name tooltip on hover.</param>
/// <param name="ReactorName">Linked reactor name; portal activates in conjunction with the named reactor.</param>
/// <param name="SessionValueKey">Session-state key for conditional portal behavior.</param>
/// <param name="SessionValue">Required or stored session-state value.</param>
/// <param name="HorizontalRange">Horizontal activation range in pixels.</param>
/// <param name="VerticalRange">Vertical activation range in pixels.</param>
/// <param name="Image">Custom portal sprite path; empty = default portal sprite.</param>
/// <param name="VerticalImpact">Vertical velocity impulse applied to the player on exit.</param>
/// <param name="HorizontalImpact">Horizontal velocity impulse applied to the player on exit.</param>
public sealed record MapPortalEntry(
    string Name,
    MapPortalType Type,
    MapPoint Position,
    FieldTemplateId? TargetMapId = null,
    string? TargetName = null,
    string? Script = null,
    bool OnlyOnce = false,
    int Delay = 0,
    bool HideTooltip = false,
    string? ReactorName = null,
    string? SessionValueKey = null,
    string? SessionValue = null,
    int? HorizontalRange = null,
    int? VerticalRange = null,
    string? Image = null,
    int? VerticalImpact = null,
    int? HorizontalImpact = null
);
