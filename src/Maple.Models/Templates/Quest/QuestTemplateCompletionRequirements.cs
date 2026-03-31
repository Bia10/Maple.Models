using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>
/// Requirements that govern quest completion, plus lifecycle flags.
/// </summary>
public sealed record QuestTemplateCompletionRequirements
{
    /// <summary>Presence = quest completes without NPC interaction when conditions are met.</summary>
    public bool AutoComplete { get; init; }

    /// <summary>NPC template ID that finalizes or accepts the quest completion.</summary>
    public NpcTemplateId? CompleteNpcId { get; init; }

    /// <summary>Primary quest timer duration in seconds; 0 = no limit.</summary>
    public int? TimeLimit { get; init; }

    /// <summary>Secondary quest timer duration in seconds; 0 = no limit.</summary>
    public int? TimeLimit2 { get; init; }

    /// <summary>Mob kill counts required before the quest can complete.</summary>
    public IReadOnlyList<QuestMobKill>? MobKills { get; init; }

    /// <summary>Items consumed or required at completion time.</summary>
    public IReadOnlyList<QuestItemReq>? CompleteItemReqs { get; init; }

    /// <summary>Quest record (QR) value pattern that must exist for completion; empty string = any.</summary>
    public string? CompleteQrInfo { get; init; }

    /// <summary>Accumulated experience threshold required before the quest can complete.</summary>
    public long? CompleteExpRequired { get; init; }

    /// <summary>Meso amount the player must have on hand for completion.</summary>
    public long? CompleteMesoRequired { get; init; }

    /// <summary>Presence = quest auto-cancels when failure conditions are met.</summary>
    public bool AutoCancel { get; init; }

    /// <summary>Presence = quest auto-completes after a single trigger event.</summary>
    public bool OneShot { get; init; }

    /// <summary>Presence = pre-complete evaluation runs automatically.</summary>
    public bool AutoPreComplete { get; init; }
}
