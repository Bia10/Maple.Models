namespace Maple.Models.Templates.Map;

/// <summary>Boat/ferry animation data. Present only on continent-move maps.</summary>
/// <param name="ShipObj">Sprite or object key used for the ship visual.</param>
/// <param name="ShipKind">Ship-kind code that controls the animation preset.</param>
/// <param name="TMove">Movement duration or timing value for the ship animation.</param>
/// <param name="X">Ship X coordinate.</param>
/// <param name="X0">Secondary X reference used as the starting position offset.</param>
/// <param name="Y">Ship Y coordinate.</param>
/// <param name="Z">Z-order or depth value used when rendering the ship.</param>
/// <param name="TAppear">Appearance timing value used when the ship enters the scene.</param>
/// <param name="Flip">Whether the ship graphic is mirrored horizontally.</param>
/// <param name="LimitX0">Minimum horizontal travel boundary.</param>
/// <param name="LimitX">Maximum horizontal travel boundary.</param>
/// <param name="LimitY0">Minimum vertical travel boundary.</param>
/// <param name="LimitY">Maximum vertical travel boundary.</param>
public sealed record MapShipData(
    string? ShipObj,
    int? ShipKind,
    int? TMove,
    int? X,
    int? X0,
    int? Y,
    int? Z,
    int? TAppear,
    bool Flip,
    int? LimitX0,
    int? LimitX,
    int? LimitY0,
    int? LimitY
);
