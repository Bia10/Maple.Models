using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Behavioral payload describing what a skill does and how it is presented in play.
/// </summary>
public sealed record SkillTemplateBehaviorData
{
    /// <summary>Per-level stat tables emitted by the skill template.</summary>
    public IReadOnlyList<SkillTemplateLevel>? LevelStats { get; init; }

    /// <summary>Passive-skill link referenced by the template, if any.</summary>
    public SkillTemplateId? PsdSkillId { get; init; }

    /// <summary>Final attack action codes associated with the skill.</summary>
    public IReadOnlyList<int>? FinalAttackActionCodes { get; init; }

    /// <summary>Skill subtype discriminator.</summary>
    public SkillSubType? SkillType { get; init; }

    /// <summary>Attack element attribute for the skill, if any.</summary>
    public Element? AttackElemAttr { get; init; }

    /// <summary>Raw element attribute string from the template data.</summary>
    public string? ElemAttrStr { get; init; }

    /// <summary>Primary weapon type associated with the skill.</summary>
    public WeaponType? WeaponType { get; init; }

    /// <summary>Secondary weapon type associated with the skill.</summary>
    public WeaponType? SubWeaponType { get; init; }

    /// <summary>Action keys or animation names associated with the skill.</summary>
    public IReadOnlyList<string>? Actions { get; init; }

    /// <summary>Preparation action identifier, if the skill has a pre-cast action.</summary>
    public int? PrepareAction { get; init; }

    /// <summary>Preparation time in milliseconds, if the skill has a pre-cast delay.</summary>
    public int? PrepareTime { get; init; }

    /// <summary>Projectile delay in milliseconds.</summary>
    public int? BallDelay { get; init; }

    /// <summary>Gets whether the skill is marked invisible in the source data.</summary>
    public bool Invisible { get; init; }

    /// <summary>Mob template linked to the skill, if any.</summary>
    public MobTemplateId? MobCode { get; init; }

    /// <summary>Delay frame count used by the skill animation.</summary>
    public int? DelayFrame { get; init; }

    /// <summary>Hold frame count used by the skill animation.</summary>
    public int? HoldFrame { get; init; }

    /// <summary>Gets whether the skill emits a continuous effect.</summary>
    public bool ContinuousEffect { get; init; }

    /// <summary>Gets whether the skill uses a keydown-end lifecycle.</summary>
    public bool KeydownEnd { get; init; }

    /// <summary>Gets whether the skill behaves as a summon.</summary>
    public bool Summon { get; init; }

    /// <summary>Gets whether the skill fires a projectile.</summary>
    public bool HasProjectile { get; init; }

    /// <summary>Gets whether the skill acts as a passive skill.</summary>
    public bool Psd { get; init; }

    /// <summary>Common formula strings keyed by stat name.</summary>
    public IReadOnlyDictionary<string, string>? CommonFormulas { get; init; }

    /// <summary>Passive-skill offset additions attached to the skill.</summary>
    public IReadOnlyList<SkillAdditionPsd>? PsdSkillOffsets { get; init; }

    /// <summary>Animation metadata associated with the skill.</summary>
    public SkillAnimationData? AnimationData { get; init; }
}
