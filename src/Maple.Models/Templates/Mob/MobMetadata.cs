using Maple.Enums;
using Maple.Models.Common;
using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Classification, rendering, and identity metadata for a mob.
/// </summary>
/// <param name="MonsterBookId">Overrides the Monster Book entry ID.</param>
/// <param name="Species">Species classification for the mob.</param>
/// <param name="Category">Mob category classification.</param>
/// <param name="MoveAbility">Movement ability configured for the mob.</param>
/// <param name="ChaseSpeed">Speed override when the mob pursues a target.</param>
/// <param name="PushedDamage">Knockback force applied to the mob when hit.</param>
/// <param name="WeaponId">Item template ID of the mob's weapon, used for visual weapon attachment.</param>
/// <param name="Fs">Ground traction / friction coefficient affecting slide and knockback response.</param>
/// <param name="HpTagColor">Foreground color used for the HP tag; presence implies custom HP tag rendering.</param>
/// <param name="HpTagBgColor">Background color used for the HP tag.</param>
/// <param name="ChargeCount">Charge-count value configured for the mob.</param>
/// <param name="DropItemPeriod">Period between item drops, when explicitly configured.</param>
/// <param name="BanType">Ban or restriction behavior type associated with the mob.</param>
/// <param name="HitCount">Hit-count threshold value associated with the mob.</param>
/// <param name="DieCount">Death-count threshold value associated with the mob.</param>
/// <param name="EscortType">Escort behavior type for the mob.</param>
/// <param name="ChatBalloon">Chat balloon style override for the mob.</param>
public sealed record MobMetadata(
    int? MonsterBookId = null,
    MobSpecies? Species = null,
    MobCategory? Category = null,
    MobMoveAbility MoveAbility = MobMoveAbility.Stop,
    int? ChaseSpeed = null,
    int? PushedDamage = null,
    ItemTemplateId? WeaponId = null,
    float? Fs = null,
    ArgbColor? HpTagColor = null,
    ArgbColor? HpTagBgColor = null,
    int? ChargeCount = null,
    int? DropItemPeriod = null,
    MobBanType? BanType = null,
    int? HitCount = null,
    int? DieCount = null,
    MobEscortType? EscortType = null,
    ChatBalloonType? ChatBalloon = null
);
