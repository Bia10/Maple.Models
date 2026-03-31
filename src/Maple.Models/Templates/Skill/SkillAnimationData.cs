namespace Maple.Models.Templates.Skill;

/// <summary>
/// Skill animation paths and icon presence flags.
/// </summary>
/// <param name="EffectUol">Primary effect animation path.</param>
/// <param name="ScreenEffectUol">Full-screen overlay effect animation path.</param>
/// <param name="AffectedUol">Primary self-buff sprite path shown on the player while the buff is active.</param>
/// <param name="Affected0Uol">Secondary self-buff sprite layer path.</param>
/// <param name="SpecialAffectedUol">Special-variant affected-target animation path.</param>
/// <param name="PrepareUol">Skill preparation (pre-cast) animation path played before activation.</param>
/// <param name="KeyDownUol">Looping animation path shown while the activation key is held.</param>
/// <param name="KeyDownEndUol">Animation path played when the held key is released.</param>
/// <param name="HitRootUol">Root path for all hit-effect animations.</param>
/// <param name="HitUols">Per-hit-index animation paths for multi-hit sequences.</param>
/// <param name="BallUol">Projectile animation path for ranged skills.</param>
/// <param name="FlipBallUol">Horizontally mirrored variant of the projectile animation path.</param>
/// <param name="MobUol">Mob-overlay or summoned-mob animation path.</param>
/// <param name="TileUol">Tile-type skill ground effect animation path.</param>
/// <param name="AfterimageUol">Afterimage trail animation path following the character during the skill.</param>
/// <param name="SpecialUol">Special-effect animation sequence path.</param>
/// <param name="SummonedUol">Summoned-creature animation path.</param>
/// <param name="FinishUol">Finishing-blow animation path played on the final hit.</param>
/// <param name="HasIconDisabled">Whether the skill template exposes a greyed-out disabled-state icon asset.</param>
/// <param name="HasIcon">Whether the skill template exposes a standard enabled-state icon asset.</param>
/// <param name="HasIconMouseOver">Whether the skill template exposes a hover-state icon asset.</param>
public sealed record SkillAnimationData(
    string? EffectUol = null,
    string? ScreenEffectUol = null,
    string? AffectedUol = null,
    string? Affected0Uol = null,
    string? SpecialAffectedUol = null,
    string? PrepareUol = null,
    string? KeyDownUol = null,
    string? KeyDownEndUol = null,
    string? HitRootUol = null,
    IReadOnlyList<string>? HitUols = null,
    string? BallUol = null,
    string? FlipBallUol = null,
    string? MobUol = null,
    string? TileUol = null,
    string? AfterimageUol = null,
    string? SpecialUol = null,
    string? SummonedUol = null,
    string? FinishUol = null,
    bool HasIconDisabled = false,
    bool HasIcon = false,
    bool HasIconMouseOver = false
);
