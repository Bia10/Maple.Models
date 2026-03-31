namespace Maple.Models.Templates.Map;

/// <summary>
/// A climbable ladder or rope.
/// </summary>
/// <param name="Id">Node-index-derived synthetic identifier (0-based).</param>
/// <param name="X">Horizontal position of the climb line in world-space pixels.</param>
/// <param name="Y1">Top Y boundary; player can begin climbing here.</param>
/// <param name="Y2">Bottom Y boundary; player exits climb here.</param>
/// <param name="Page">Layer page reference (0–7); matches the map layer the element belongs to.</param>
/// <param name="IsLadder"><see langword="true"/> = ladder (grip-and-climb); <see langword="false"/> = rope or vine.</param>
/// <param name="UpperFootholdId">The foothold serial number the player steps onto when exiting at the top of the climb;
/// <see langword="null"/> or <c>0</c> = no upper-foothold binding.</param>
public readonly record struct MapLadderEntry(
    int Id,
    int X,
    int Y1,
    int Y2,
    int Page,
    bool IsLadder,
    int? UpperFootholdId = null
);
