using Maple.Enums;
using Maple.Models.Common;
using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Combat stats and behavioral properties for a mob template,
/// loaded on-demand for the mob details popup.
/// Grouped sub-records keep combat, metadata, and interaction data coherent without a single flat constructor.
/// </summary>
/// <remarks>
/// Payload properties (<see cref="Combat"/>, <see cref="Metadata"/>, <see cref="Interaction"/>) have no
/// <c>init</c> accessor — <c>with</c> expressions leave them unchanged.
/// Use the constructor directly when payload modifications are needed.
/// </remarks>
public sealed record MobInfoEntry
{
    /// <summary>Creates a mob info entry from grouped combat, metadata, and interaction payloads.</summary>
    /// <param name="combat">Combat stats, behavior, attacks, and skills.</param>
    /// <param name="metadata">Classification, rendering, and identity metadata.</param>
    /// <param name="interaction">Spawn, dialogue, and special-interaction metadata.</param>
    public MobInfoEntry(MobCombatData combat, MobMetadata metadata, MobInteractionData interaction)
    {
        Combat = combat;
        Metadata = metadata;
        Interaction = interaction;
    }

    /// <summary>Gets the combat-facing stats, resistances, attacks, and skills.</summary>
    public MobCombatData Combat { get; }

    /// <summary>Gets the classification, rendering, and identity metadata.</summary>
    public MobMetadata Metadata { get; }

    /// <summary>Gets the spawn, dialogue, and special-interaction metadata.</summary>
    public MobInteractionData Interaction { get; }

    /// <summary>Gets the stat payload.</summary>
    public MobCoreStats Stats => Combat.Stats;

    /// <summary>Gets the behavioral and visibility flags for the mob.</summary>
    public MobBehaviorFlags Behavior => Combat.Behavior;

    /// <summary>Gets the HP recovery value applied by the mob.</summary>
    public int HPRecovery => Combat.HPRecovery;

    /// <summary>Gets the MP recovery value applied by the mob.</summary>
    public int MPRecovery => Combat.MPRecovery;

    /// <summary>Gets the fixed damage value used by the mob.</summary>
    public int FixedDamage => Combat.FixedDamage;

    /// <summary>Gets the element attribute string.</summary>
    public string? ElemAttr => Combat.ElemAttr;

    /// <summary>Gets the parsed elemental resistances or weaknesses.</summary>
    public IReadOnlyList<MobElementResistance> ElementResistances => Combat.ElementResistances;

    /// <summary>Gets the number of attack entries defined for the mob.</summary>
    public int AttackCount => Combat.AttackCount;

    /// <summary>Gets the number of skill entries defined for the mob.</summary>
    public int SkillCount => Combat.SkillCount;

    /// <summary>Gets the attack summaries parsed from the mob template.</summary>
    public IReadOnlyList<MobAttackSummary> Attacks => Combat.Attacks;

    /// <summary>Gets the skill entries parsed from the mob template.</summary>
    public IReadOnlyList<MobSkillEntry> Skills => Combat.Skills;

    /// <summary>Gets the Monster Book identifier.</summary>
    public int? MonsterBookId => Metadata.MonsterBookId;

    /// <summary>Gets the species classification for the mob.</summary>
    public MobSpecies? Species => Metadata.Species;

    /// <summary>Gets the category classification for the mob.</summary>
    public MobCategory? Category => Metadata.Category;

    /// <summary>Gets the movement ability configured for the mob.</summary>
    public MobMoveAbility MoveAbility => Metadata.MoveAbility;

    /// <summary>Gets the chase-speed override used when the mob pursues a target.</summary>
    public int? ChaseSpeed => Metadata.ChaseSpeed;

    /// <summary>Gets the damage threshold or value used when the mob is pushed.</summary>
    public int? PushedDamage => Metadata.PushedDamage;

    /// <summary>Gets the item template ID of the mob's weapon, when present.</summary>
    public ItemTemplateId? WeaponId => Metadata.WeaponId;

    /// <summary>Gets the traction or friction coefficient.</summary>
    public float? Fs => Metadata.Fs;

    /// <summary>Gets the foreground color used for the HP tag.</summary>
    public ArgbColor? HpTagColor => Metadata.HpTagColor;

    /// <summary>Gets the background color used for the HP tag.</summary>
    public ArgbColor? HpTagBgColor => Metadata.HpTagBgColor;

    /// <summary>Gets the charge-count value configured for the mob.</summary>
    public int? ChargeCount => Metadata.ChargeCount;

    /// <summary>Gets the period between item drops, when explicitly configured.</summary>
    public int? DropItemPeriod => Metadata.DropItemPeriod;

    /// <summary>Gets the ban or restriction type associated with the mob.</summary>
    public MobBanType? BanType => Metadata.BanType;

    /// <summary>Gets the hit-count value associated with the mob.</summary>
    public int? HitCount => Metadata.HitCount;

    /// <summary>Gets the death-count value associated with the mob.</summary>
    public int? DieCount => Metadata.DieCount;

    /// <summary>Gets the escort behavior type associated with the mob.</summary>
    public MobEscortType? EscortType => Metadata.EscortType;

    /// <summary>Gets the chat balloon style override.</summary>
    public ChatBalloonType? ChatBalloon => Metadata.ChatBalloon;

    /// <summary>Gets the mob templates spawned when this mob dies.</summary>
    public IReadOnlyList<MobTemplateId>? ReviveIds => Interaction.ReviveIds;

    /// <summary>Gets the mob templates allowed to damage this mob.</summary>
    public IReadOnlyList<MobTemplateId>? DamagedBySelectedMob => Interaction.DamagedBySelectedMob;

    /// <summary>Gets the skills allowed to damage this mob.</summary>
    public IReadOnlyList<SkillTemplateId>? DamagedBySelectedSkill => Interaction.DamagedBySelectedSkill;

    /// <summary>Gets the speak or chat-bubble entries for this mob.</summary>
    public IReadOnlyList<MobSpeakEntry>? SpeakInfo => Interaction.SpeakInfo;

    /// <summary>Gets the elemental bonus values keyed by element.</summary>
    public IReadOnlyDictionary<Element, int>? ElemBonus => Interaction.ElemBonus;

    /// <summary>Gets the fixed body-attack damage ratio override.</summary>
    public int? FixedBodyAttackDamR => Interaction.FixedBodyAttackDamR;
}
