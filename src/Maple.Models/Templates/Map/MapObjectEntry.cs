using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>
/// A single object instance on a map layer.
/// </summary>
/// <param name="X">Object instance X coordinate.</param>
/// <param name="Y">Object instance Y coordinate.</param>
/// <param name="ObjSet">Object-set name that selects the source atlas.</param>
/// <param name="L0">First path segment under the object atlas.</param>
/// <param name="L1">Second path segment under the object atlas.</param>
/// <param name="L2">Third path segment under the object atlas.</param>
/// <param name="Z">Base Z-order of the object.</param>
/// <param name="ZM">Additional Z-order modifier for the object.</param>
/// <param name="Layer">Layer index (0–7); derived from the enclosing node hierarchy.</param>
/// <param name="FlipH">Whether the object is flipped horizontally.</param>
/// <param name="IsReactive">Whether the object is reactive (interactable by scripts or map events).</param>
/// <param name="MoveType">Object movement type; 0=none, 1+=various automated movement patterns.</param>
/// <param name="IsDynamic">Whether the object participates in dynamic object updates.</param>
/// <param name="Piece">Piece grouping identifier for composite multi-object elements.</param>
/// <param name="ObjName">Optional instance name tag for script or event targeting.</param>
/// <param name="IsHidden">Whether the object starts hidden (reveal via script).</param>
/// <param name="HasFlow">Whether the object animates or drifts independently of player interaction.</param>
/// <param name="QuestId">Quest ID that controls visibility; object shown or hidden based on quest state.</param>
/// <param name="MovePoint">Optional movement anchor point used when <see cref="MoveType"/> is nonzero.</param>
public readonly record struct MapObjectEntry(
    int X,
    int Y,
    string ObjSet,
    string L0,
    string L1,
    string L2,
    int Z,
    int ZM,
    int Layer,
    bool FlipH = false,
    bool IsReactive = false,
    int MoveType = 0,
    bool IsDynamic = false,
    int? Piece = null,
    string? ObjName = null,
    bool IsHidden = false,
    bool HasFlow = false,
    QuestTemplateId? QuestId = null,
    MapPoint? MovePoint = null
);
