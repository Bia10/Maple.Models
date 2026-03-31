namespace Maple.Models.Templates.Map;

/// <summary>Global physics constants — server-level defaults for all maps.</summary>
/// <param name="WalkForce">Walking acceleration force constant.</param>
/// <param name="WalkSpeed">Maximum walking speed cap.</param>
/// <param name="WalkDrag">Walking friction/drag coefficient.</param>
/// <param name="SlipForce">Slip surface acceleration force.</param>
/// <param name="SlipSpeed">Slip surface maximum speed cap.</param>
/// <param name="FloatDrag">Primary floating drag coefficient.</param>
/// <param name="FloatDrag2">Secondary floating drag coefficient.</param>
/// <param name="FloatCoefficient">Floating movement physics coefficient.</param>
/// <param name="SwimForce">Swimming acceleration force.</param>
/// <param name="SwimSpeed">Maximum swimming speed cap.</param>
/// <param name="FlyForce">Flight acceleration force.</param>
/// <param name="FlySpeed">Maximum flight speed cap.</param>
/// <param name="GravityAcc">Gravity acceleration constant.</param>
/// <param name="FallSpeed">Terminal fall velocity cap.</param>
/// <param name="JumpSpeed">Jump initial upward velocity.</param>
/// <param name="MaxFriction">Maximum platform friction coefficient.</param>
/// <param name="MinFriction">Minimum platform friction coefficient.</param>
/// <param name="SwimJumpSpeed">Upward velocity applied when jumping out of a swim state.</param>
/// <param name="FlyJumpSpeed">Upward velocity applied when jumping from a fly state.</param>
public sealed record GlobalPhysicsEntry(
    float? WalkForce = null,
    float? WalkSpeed = null,
    float? WalkDrag = null,
    float? SlipForce = null,
    float? SlipSpeed = null,
    float? FloatDrag = null,
    float? FloatDrag2 = null,
    float? FloatCoefficient = null,
    float? SwimForce = null,
    float? SwimSpeed = null,
    float? FlyForce = null,
    float? FlySpeed = null,
    float? GravityAcc = null,
    float? FallSpeed = null,
    float? JumpSpeed = null,
    float? MaxFriction = null,
    float? MinFriction = null,
    float? SwimJumpSpeed = null,
    float? FlyJumpSpeed = null
);
