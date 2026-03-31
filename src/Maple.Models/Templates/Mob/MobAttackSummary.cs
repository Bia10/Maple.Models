using Maple.Enums;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Summary of a single mob attack entry.
/// </summary>
/// <param name="Index">Zero-based attack index within the mob template.</param>
/// <param name="PADamage">Physical damage value dealt by the attack.</param>
/// <param name="ConMP">MP consumed when the mob uses the attack.</param>
/// <param name="IsMagic">Whether the attack is treated as a magic attack.</param>
/// <param name="IsDeadly">Whether the attack is marked as deadly (one-shots or causes severe status).</param>
/// <param name="HasKnockBack">Whether the attack applies knockback to the target.</param>
/// <param name="MPBurn">MP burned by the attack on the target.</param>
/// <param name="RangeLeft">Left bound of the attack range.</param>
/// <param name="RangeTop">Top bound of the attack range.</param>
/// <param name="RangeRight">Right bound of the attack range.</param>
/// <param name="RangeBottom">Bottom bound of the attack range.</param>
/// <param name="ElemAttr">Elemental attribute of the attack. Only applies when <see cref="IsMagic"/> is true.</param>
/// <param name="Type">Attack range type.</param>
/// <param name="BulletNumber">Number of projectiles fired.</param>
/// <param name="BulletSpeed">Projectile speed.</param>
/// <param name="EffectAfterMs">Delay before the effect applies.</param>
/// <param name="AttackAfterMs">Delay before the attack resolves.</param>
/// <param name="RandDelayMs">Random additional delay.</param>
/// <param name="Tremble">Whether the attack causes a screen-shake effect.</param>
/// <param name="DoFirst">Whether the attack runs as a priority action.</param>
/// <param name="IsRush">Whether the attack is a rush/charge attack.</param>
/// <param name="IsSpecial">Whether the attack is marked as special.</param>
/// <param name="IsInactive">Whether the attack is disabled.</param>
/// <param name="IsJumpAttack">Whether the attack is performed while jumping.</param>
/// <param name="HitAttach">Whether the hit effect attaches to the target.</param>
/// <param name="FacingAttach">Whether the effect attaches facing the target.</param>
/// <param name="EffectUol">Hit effect animation reference.</param>
/// <param name="BallUol">Projectile animation reference.</param>
/// <param name="HitUol">Hit animation reference.</param>
/// <param name="AreaWarningUol">Danger-zone warning effect reference.</param>
public sealed record MobAttackSummary(
    int Index,
    int PADamage,
    int ConMP,
    bool IsMagic,
    bool IsDeadly,
    bool HasKnockBack,
    int MPBurn,
    int? RangeLeft = null,
    int? RangeTop = null,
    int? RangeRight = null,
    int? RangeBottom = null,
    Element? ElemAttr = null,
    MobAttackRange Type = MobAttackRange.Range,
    int BulletNumber = 0,
    int BulletSpeed = 0,
    int EffectAfterMs = 0,
    int AttackAfterMs = 0,
    int RandDelayMs = 0,
    bool Tremble = false,
    bool DoFirst = false,
    bool IsRush = false,
    bool IsSpecial = false,
    bool IsInactive = false,
    bool IsJumpAttack = false,
    bool HitAttach = false,
    bool FacingAttach = false,
    string? EffectUol = null,
    string? BallUol = null,
    string? HitUol = null,
    string? AreaWarningUol = null
);
