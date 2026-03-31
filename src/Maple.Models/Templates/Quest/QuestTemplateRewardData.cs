using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>
/// Reward and follow-up payload emitted when a quest completes.
/// The same schema applies to start-phase rewards granted on acceptance.
/// </summary>
public sealed record QuestTemplateRewardData
{
    /// <summary>Experience reward granted on completion.</summary>
    public long? Exp { get; init; }

    /// <summary>Meso reward granted on completion.</summary>
    public long? Meso { get; init; }

    /// <summary>Derived from quest state changes: the next quest to unlock or chain after completion, if any.</summary>
    public QuestTemplateId? NextQuestId { get; init; }

    /// <summary>Item rewards granted when the quest completes.</summary>
    public IReadOnlyList<QuestItemReward>? ItemRewards { get; init; }

    /// <summary>Skill rewards granted when the quest completes.</summary>
    public IReadOnlyList<QuestSkillReward>? SkillRewards { get; init; }

    /// <summary>Quest state mutations applied to other quests on completion.</summary>
    public IReadOnlyList<QuestStateChange>? QuestStateChanges { get; init; }

    /// <summary>SP rewards granted when the quest completes, keyed by job category.</summary>
    public IReadOnlyList<QuestSpReward>? SpRewards { get; init; }

    /// <summary>Buff item applied immediately on completion.</summary>
    public ItemTemplateId? BuffItemId { get; init; }

    /// <summary>Fame (popularity) reward granted on completion.</summary>
    public int? FameReward { get; init; }

    /// <summary>Ability point reward granted on completion.</summary>
    public int? ApReward { get; init; }

    /// <summary>NPC animation key triggered on completion.</summary>
    public string? NpcActKey { get; init; }

    /// <summary>Quest record (QR) value string written when the quest completes.</summary>
    public string? QrInfoSet { get; init; }
}
