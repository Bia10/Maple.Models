namespace Maple.Models.Templates.Map;

/// <summary>A single foothold segment.
/// The three-level hierarchy encodes rendering layer, grouping, and serial ID in the node names rather than as field values.</summary>
/// <param name="Id">The foothold serial number.</param>
/// <param name="X1">Start X coordinate of the foothold segment.</param>
/// <param name="Y1">Start Y coordinate (positive = lower on screen).</param>
/// <param name="X2">End X coordinate of the foothold segment.</param>
/// <param name="Y2">End Y coordinate (positive = lower on screen).</param>
/// <param name="CantThrough">Whether the player cannot jump through from below.</param>
/// <param name="Prev">Chained previous foothold serial ID; 0 = none.</param>
/// <param name="Next">Chained next foothold serial ID; 0 = none.</param>
/// <param name="Force">Forced terrain behavior type.</param>
/// <param name="Piece">Piece grouping identifier for multi-part platforms.</param>
/// <param name="Layer">Rendering layer index (0–7).</param>
/// <param name="Group">Foothold group identifier.</param>
/// <param name="Drag">Surface drag coefficient; defaults to 0.2.</param>
/// <param name="Walk">Whether the foothold surface allows walking; defaults to <see langword="true"/>.</param>
/// <param name="ForbidFallDown">Whether players cannot drop through this platform.</param>
public readonly record struct MapFootholdEntry(
    int Id,
    int X1,
    int Y1,
    int X2,
    int Y2,
    bool CantThrough = false,
    int? Prev = null,
    int? Next = null,
    int? Force = null,
    int? Piece = null,
    int Layer = 0,
    int Group = 0,
    float Drag = 0.2f,
    bool Walk = true,
    bool ForbidFallDown = false
)
{
    /// <summary>True when the foothold is a vertical wall (x1 == x2).</summary>
    public bool IsWall => X1 == X2;
}
