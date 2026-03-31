using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Top-level skill catalog entry enriched from Skill data.
/// Holds grouped metadata, requirement, behavior, and cost payloads.
/// </summary>
/// <remarks>
/// Payload properties (<see cref="Metadata"/>, <see cref="Requirements"/>, <see cref="Behavior"/>, <see cref="Cost"/>) have no
/// <c>init</c> accessor — <c>with</c> expressions leave them unchanged.
/// Use the constructor directly when payload modifications are needed.
/// </remarks>
public sealed record SkillTemplateEntry : TemplateCatalogEntry
{
    /// <summary>Creates a skill entry from grouped metadata, requirements, behavior, and cost data.</summary>
    /// <param name="id">Numeric skill template identifier.</param>
    /// <param name="name">Localized skill name.</param>
    /// <param name="metadata">Descriptive text and grouping metadata.</param>
    /// <param name="requirements">Progression and unlock requirements.</param>
    /// <param name="behavior">Behavioral payload and animation data.</param>
    /// <param name="cost">Runtime costs and modifiers for the skill.</param>
    public SkillTemplateEntry(
        int id,
        string name,
        SkillTemplateMetadata? metadata = null,
        SkillTemplateRequirements? requirements = null,
        SkillTemplateBehaviorData? behavior = null,
        SkillTemplateCostData? cost = null
    )
        : base(id, name, metadata?.Description, Category: metadata?.JobName)
    {
        Metadata = metadata;
        Requirements = requirements;
        Behavior = behavior;
        Cost = cost;
    }

    /// <summary>Typed wrapper for this entry's skill template ID.</summary>
    public SkillTemplateId SkillId => new(Id);

    /// <summary>Descriptive text and grouping metadata for the skill.</summary>
    public SkillTemplateMetadata? Metadata { get; }

    /// <summary>Progression and unlock requirements for the skill.</summary>
    public SkillTemplateRequirements? Requirements { get; }

    /// <summary>Behavioral payload, per-level data, and animation metadata.</summary>
    public SkillTemplateBehaviorData? Behavior { get; }

    /// <summary>Runtime costs and modifiers for the skill.</summary>
    public SkillTemplateCostData? Cost { get; }

    /// <summary>Tooltip hint or short helper text associated with the skill.</summary>
    public string? Hint => Metadata?.Hint;

    /// <summary>Maximum learnable level for the skill.</summary>
    public int MaxLevel => Requirements?.MaxLevel ?? 0;

    /// <summary>Master level cap when the skill uses mastery books or equivalent systems.</summary>
    public int? MasterLevel => Requirements?.MasterLevel;

    /// <summary>Minimum character level required before the skill can be learned.</summary>
    public int? ReqLevel => Requirements?.ReqLevel;

    /// <summary>Specific job identifier required to learn the skill, when one is declared.</summary>
    public JobId? ReqJob => Requirements?.ReqJob;

    /// <summary>Per-level stat payloads that describe how the skill scales by level.</summary>
    public IReadOnlyList<SkillTemplateLevel>? LevelStats => Behavior?.LevelStats;

    /// <summary>Localized job or branch name associated with the skill.</summary>
    public string? JobName => Metadata?.JobName;

    /// <summary>Passive-skill template identifier referenced by this skill, when present.</summary>
    public SkillTemplateId? PsdSkillId => Behavior?.PsdSkillId;

    /// <summary>Final-attack action codes triggered by this skill, when defined.</summary>
    public IReadOnlyList<int>? FinalAttackActionCodes => Behavior?.FinalAttackActionCodes;

    /// <summary>Skill subtype classification from Maple.Enums.</summary>
    public SkillSubType? SkillType => Behavior?.SkillType;

    /// <summary>Elemental attribute used by the attack portion of the skill, when defined.</summary>
    public Element? AttackElemAttr => Behavior?.AttackElemAttr;

    /// <summary>Raw element-attribute text emitted by the template when preserved alongside the enum value.</summary>
    public string? ElemAttrStr => Behavior?.ElemAttrStr;

    /// <summary>Main weapon type required or associated with the skill.</summary>
    public WeaponType? WeaponType => Behavior?.WeaponType;

    /// <summary>Secondary weapon type required or associated with the skill.</summary>
    public WeaponType? SubWeaponType => Behavior?.SubWeaponType;

    /// <summary>Animation action names referenced by the skill.</summary>
    public IReadOnlyList<string>? Actions => Behavior?.Actions;

    /// <summary>Preparation action code played before the skill resolves, when defined.</summary>
    public int? PrepareAction => Behavior?.PrepareAction;

    /// <summary>Preparation delay in milliseconds or frames, depending on source semantics.</summary>
    public int? PrepareTime => Behavior?.PrepareTime;

    /// <summary>Projectile or orb delay value associated with the skill, when present.</summary>
    public int? BallDelay => Behavior?.BallDelay;

    /// <summary>Whether the skill's visual effect is marked as invisible.</summary>
    public bool Invisible => Behavior?.Invisible ?? false;

    /// <summary>Whether the skill disables the up-button input while active or during casting.</summary>
    public bool UpButtonDisabled => Requirements?.UpButtonDisabled ?? false;

    /// <summary>Default master level applied when no explicit mastered state is stored elsewhere.</summary>
    public int? DefaultMasterLevel => Requirements?.DefaultMasterLevel;

    /// <summary>Whether the skill is compatible with the Combat Orders effect.</summary>
    public bool CombatOrders => Cost?.CombatOrders ?? false;

    /// <summary>Whether the skill is time-limited instead of permanently available once learned.</summary>
    public bool TimeLimited => Requirements?.TimeLimited ?? false;

    /// <summary>Mob template identifier associated with summoned or transformed mob behavior, when present.</summary>
    public MobTemplateId? MobCode => Behavior?.MobCode;

    /// <summary>Delay-frame value associated with the skill's execution timing.</summary>
    public int? DelayFrame => Behavior?.DelayFrame;

    /// <summary>Hold-frame value associated with channeling or sustained portions of the skill.</summary>
    public int? HoldFrame => Behavior?.HoldFrame;

    /// <summary>Whether the skill uses a continuous effect instead of a single-shot application.</summary>
    public bool ContinuousEffect => Behavior?.ContinuousEffect ?? false;

    /// <summary>Other skills that must be learned before this skill becomes available.</summary>
    public IReadOnlyList<SkillReqEntry>? RequiredSkills => Requirements?.RequiredSkills;

    /// <summary>Whether the skill belongs to the Hyper skill tier.</summary>
    public bool Hyper => Requirements?.Hyper ?? false;

    /// <summary>Whether the skill is disabled in PvP contexts.</summary>
    public bool PvpDisable => Requirements?.PvpDisable ?? false;

    /// <summary>Whether the skill exposes a separate key-down end phase.</summary>
    public bool KeydownEnd => Behavior?.KeydownEnd ?? false;

    /// <summary>Whether the skill creates or controls a summon entity.</summary>
    public bool Summon => Behavior?.Summon ?? false;

    /// <summary>Whether the skill should remain learned even when normal removal rules would apply.</summary>
    public bool NotRemoved => Requirements?.NotRemoved ?? false;

    /// <summary>Speed modifier stored in the skill's runtime-cost payload.</summary>
    public int? Speed => Cost?.Speed;

    /// <summary>Item template consumed when the skill is used, when applicable.</summary>
    public ItemTemplateId? ItemConsume => Cost?.ItemConsume;

    /// <summary>Quantity of the consumed item required per use, when applicable.</summary>
    public int? ItemConsumeCount => Cost?.ItemConsumeCount;

    /// <summary>Meso cost required to use the skill, when applicable.</summary>
    public int? MoneyCon => Cost?.MoneyCon;

    /// <summary>HP cost required to use the skill, when applicable.</summary>
    public int? HpCon => Cost?.HpCon;

    /// <summary>MP cost required to use the skill, when applicable.</summary>
    public int? MpCon => Cost?.MpCon;

    /// <summary>Whether the skill requires or spawns a projectile resource.</summary>
    public bool HasProjectile => Behavior?.HasProjectile ?? false;

    /// <summary>Whether the skill is marked as a passive-skill-definition entry.</summary>
    public bool Psd => Behavior?.Psd ?? false;

    /// <summary>Common formula expressions shared by level data or runtime evaluation.</summary>
    public IReadOnlyDictionary<string, string>? CommonFormulas => Behavior?.CommonFormulas;

    /// <summary>Passive-skill offset entries that modify related skills or passive effects.</summary>
    public IReadOnlyList<SkillAdditionPsd>? PsdSkillOffsets => Behavior?.PsdSkillOffsets;

    /// <summary>Animation timing and action metadata grouped for the skill.</summary>
    public SkillAnimationData? AnimationData => Behavior?.AnimationData;
}
