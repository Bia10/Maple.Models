using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>
/// Top-level quest definition aggregated from quest info, requirements, and reward nodes.
/// Uses grouped metadata, start requirements, completion requirements, and rewards so each
/// constructor argument represents a coherent quest subdomain instead of a flat flag bag.
/// </summary>
/// <remarks>
/// Payload properties (<see cref="Metadata"/>, <see cref="StartRequirements"/>, <see cref="CompletionRequirements"/>, <see cref="Rewards"/>) have no
/// <c>init</c> accessor — <c>with</c> expressions leave them unchanged.
/// Use the constructor directly when payload modifications are needed.
/// </remarks>
public sealed record QuestTemplateEntry : TemplateCatalogEntry
{
    /// <summary>Creates a quest entry from grouped metadata, requirement, and reward payloads.</summary>
    /// <param name="id">Numeric quest template identifier.</param>
    /// <param name="name">Localized quest name.</param>
    /// <param name="metadata">Descriptive quest metadata.</param>
    /// <param name="startRequirements">Requirements that govern quest acceptance.</param>
    /// <param name="completionRequirements">Requirements that govern quest completion.</param>
    /// <param name="rewards">Rewards emitted when the quest completes.</param>
    public QuestTemplateEntry(
        int id,
        string name,
        QuestTemplateMetadata? metadata = null,
        QuestTemplateStartRequirements? startRequirements = null,
        QuestTemplateCompletionRequirements? completionRequirements = null,
        QuestTemplateRewardData? rewards = null
    )
        : base(id, name, Description: metadata?.Summary, Category: metadata?.Parent)
    {
        Metadata = metadata;
        StartRequirements = startRequirements;
        CompletionRequirements = completionRequirements;
        Rewards = rewards;
    }

    /// <summary>Typed wrapper for this entry's quest template ID.</summary>
    public QuestTemplateId QuestId => new(Id);

    /// <summary>Descriptive quest metadata and categorization.</summary>
    public QuestTemplateMetadata? Metadata { get; }

    /// <summary>Requirements and acceptance behavior for starting the quest.</summary>
    public QuestTemplateStartRequirements? StartRequirements { get; }

    /// <summary>Completion rules and lifecycle behavior for the quest.</summary>
    public QuestTemplateCompletionRequirements? CompletionRequirements { get; }

    /// <summary>Reward payload emitted when the quest completes.</summary>
    public QuestTemplateRewardData? Rewards { get; }

    /// <summary>Gets whether the quest starts automatically when its start conditions are met.</summary>
    public bool AutoStart => StartRequirements?.AutoStart ?? false;

    /// <summary>Gets whether the quest completes automatically when its completion conditions are met.</summary>
    public bool AutoComplete => CompletionRequirements?.AutoComplete ?? false;

    /// <summary>Gets the parent or grouping label assigned to the quest metadata.</summary>
    public string? Parent => Metadata?.Parent;

    /// <summary>Gets the primary quest summary text shown to consumers.</summary>
    public string? Summary => Metadata?.Summary;

    /// <summary>Gets the localized reward-summary text emitted by the quest metadata.</summary>
    public string? RewardSummary => Metadata?.RewardSummary;

    /// <summary>Gets the primary completion time limit declared by the quest.</summary>
    public int? TimeLimit => CompletionRequirements?.TimeLimit;

    /// <summary>Gets the NPC template ID used to start the quest, when one is required.</summary>
    public NpcTemplateId? StartNpcId => StartRequirements?.StartNpcId;

    /// <summary>Gets the NPC template ID used to complete the quest, when one is required.</summary>
    public NpcTemplateId? CompleteNpcId => CompletionRequirements?.CompleteNpcId;

    /// <summary>Gets the minimum character level required to accept the quest.</summary>
    public int? LvMin => StartRequirements?.LvMin;

    /// <summary>Gets the maximum character level allowed to accept the quest.</summary>
    public int? LvMax => StartRequirements?.LvMax;

    /// <summary>Gets the experience reward granted when the quest completes.</summary>
    public long? Exp => Rewards?.Exp;

    /// <summary>Gets the meso reward granted when the quest completes.</summary>
    public long? Meso => Rewards?.Meso;

    /// <summary>Gets the follow-up quest template unlocked or referenced after completion.</summary>
    public QuestTemplateId? NextQuestId => Rewards?.NextQuestId;

    /// <summary>Gets the mob-kill requirements declared for quest completion.</summary>
    public IReadOnlyList<QuestMobKill>? MobKills => CompletionRequirements?.MobKills;

    /// <summary>Gets the item requirements that must be satisfied before the quest can start.</summary>
    public IReadOnlyList<QuestItemReq>? StartItemReqs => StartRequirements?.StartItemReqs;

    /// <summary>Gets the item requirements that must be satisfied before the quest can complete.</summary>
    public IReadOnlyList<QuestItemReq>? CompleteItemReqs => CompletionRequirements?.CompleteItemReqs;

    /// <summary>Gets the item rewards emitted when the quest completes.</summary>
    public IReadOnlyList<QuestItemReward>? ItemRewards => Rewards?.ItemRewards;

    /// <summary>Gets the skill rewards emitted when the quest completes.</summary>
    public IReadOnlyList<QuestSkillReward>? SkillRewards => Rewards?.SkillRewards;

    /// <summary>Gets the quest-state changes applied when the quest completes.</summary>
    public IReadOnlyList<QuestStateChange>? QuestStateChanges => Rewards?.QuestStateChanges;

    /// <summary>Gets the SP rewards emitted when the quest completes.</summary>
    public IReadOnlyList<QuestSpReward>? SpRewards => Rewards?.SpRewards;

    /// <summary>Gets prerequisite quests that must already be satisfied before this quest can start.</summary>
    public IReadOnlyList<QuestPrereqQuest>? PrereqQuests => StartRequirements?.PrereqQuests;

    /// <summary>Gets the jobs allowed to accept the quest, when the start rules restrict them.</summary>
    public IReadOnlyList<JobId>? RequiredJobs => StartRequirements?.RequiredJobs;

    /// <summary>Gets the buff-item template associated with the quest reward payload, when present.</summary>
    public ItemTemplateId? BuffItemId => Rewards?.BuffItemId;

    /// <summary>Gets the fame reward granted when the quest completes.</summary>
    public int? FameReward => Rewards?.FameReward;

    /// <summary>Gets the AP reward granted when the quest completes.</summary>
    public int? ApReward => Rewards?.ApReward;

    /// <summary>Gets whether the quest is configured to cancel itself automatically.</summary>
    public bool AutoCancel => CompletionRequirements?.AutoCancel ?? false;

    /// <summary>Gets the secondary completion time-limit field exposed by the template, when present.</summary>
    public int? TimeLimit2 => CompletionRequirements?.TimeLimit2;

    /// <summary>Gets whether the quest completion path is marked as one-shot.</summary>
    public bool OneShot => CompletionRequirements?.OneShot ?? false;

    /// <summary>Gets whether the quest uses the yellow-marker UI treatment.</summary>
    public bool YellowMarker => Metadata?.YellowMarker ?? false;

    /// <summary>Gets the skill requirements that gate quest acceptance.</summary>
    public IReadOnlyList<QuestSkillReq>? RequiredSkills => StartRequirements?.RequiredSkills;

    /// <summary>Gets the required pet item template for starting the quest, when one is declared.</summary>
    public ItemTemplateId? RequiredPet => StartRequirements?.RequiredPet;

    /// <summary>Gets the fields the character must be allowed to enter to start the quest.</summary>
    public IReadOnlyList<FieldTemplateId>? FieldEnterReqs => StartRequirements?.FieldEnterReqs;

    /// <summary>Gets the repeat interval configured for the quest, when the template declares one.</summary>
    public int? Interval => StartRequirements?.Interval;

    /// <summary>Gets the first start-hour boundary allowed by the quest template.</summary>
    public int? StartHour => StartRequirements?.StartHour;

    /// <summary>Gets the final start-hour boundary allowed by the quest template.</summary>
    public int? EndHour => StartRequirements?.EndHour;

    /// <summary>Gets the demand-summary text shown alongside quest requirements.</summary>
    public string? DemandSummary => Metadata?.DemandSummary;

    /// <summary>Gets the quest-area classification assigned by the metadata payload.</summary>
    public QuestArea? Area => Metadata?.Area;

    /// <summary>Gets the display or sort order value assigned by the metadata payload.</summary>
    public int? Order => Metadata?.Order;

    /// <summary>Gets the selected mob template referenced by the quest metadata, when present.</summary>
    public MobTemplateId? SelectedMob => Metadata?.SelectedMob;

    /// <summary>Gets whether the quest metadata marks the quest as blocked.</summary>
    public bool Blocked => Metadata?.Blocked ?? false;

    /// <summary>Gets whether the quest is accepted automatically once its start conditions are met.</summary>
    public bool AutoAccept => StartRequirements?.AutoAccept ?? false;

    /// <summary>Gets whether the quest performs its pre-complete phase automatically.</summary>
    public bool AutoPreComplete => CompletionRequirements?.AutoPreComplete ?? false;

    /// <summary>Gets the medal category value associated with the quest metadata, when present.</summary>
    public int? MedalCategory => Metadata?.MedalCategory;

    /// <summary>Gets the medal item template shown by the quest metadata, when present.</summary>
    public ItemTemplateId? ViewMedalItem => Metadata?.ViewMedalItem;

    /// <summary>Gets the fame requirement that must be satisfied before the quest can start.</summary>
    public int? FameRequired => StartRequirements?.FameRequired;

    /// <summary>Gets the allowed days of the week for starting the quest, when restricted.</summary>
    public IReadOnlyList<QuestDayOfWeek>? DayOfWeek => StartRequirements?.DayOfWeek;

    /// <summary>Gets the minimum taming-mob level required to start the quest, when one is declared.</summary>
    public int? TamingMobLevelMin => StartRequirements?.TamingMobLevelMin;

    /// <summary>Gets the QR-info string written or checked during quest completion, when present.</summary>
    public string? CompleteQrInfo => CompletionRequirements?.CompleteQrInfo;

    /// <summary>Gets the experience threshold required for completion, when the quest enforces one.</summary>
    public long? CompleteExpRequired => CompletionRequirements?.CompleteExpRequired;

    /// <summary>Gets the meso threshold required for completion, when the quest enforces one.</summary>
    public long? CompleteMesoRequired => CompletionRequirements?.CompleteMesoRequired;

    /// <summary>Gets the NPC action key emitted by the reward payload, when present.</summary>
    public string? NpcActKey => Rewards?.NpcActKey;

    /// <summary>Gets the QR-info string written by the reward payload, when present.</summary>
    public string? QrInfoSet => Rewards?.QrInfoSet;
}
