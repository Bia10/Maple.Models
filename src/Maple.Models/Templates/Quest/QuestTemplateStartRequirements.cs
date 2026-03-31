using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>
/// Requirements that govern whether a quest can be accepted.
/// </summary>
public sealed record QuestTemplateStartRequirements
{
    /// <summary>Presence = quest starts without NPC interaction when conditions are met.</summary>
    public bool AutoStart { get; init; }

    /// <summary>NPC template ID that offers or starts the quest.</summary>
    public NpcTemplateId? StartNpcId { get; init; }

    /// <summary>Minimum character level required (inclusive).</summary>
    public int? LvMin { get; init; }

    /// <summary>Maximum character level allowed (inclusive).</summary>
    public int? LvMax { get; init; }

    /// <summary>Items the player must hold before the quest can start.</summary>
    public IReadOnlyList<QuestItemReq>? StartItemReqs { get; init; }

    /// <summary>Prerequisite quests and their required states.</summary>
    public IReadOnlyList<QuestPrereqQuest>? PrereqQuests { get; init; }

    /// <summary>Job IDs allowed to accept the quest; absence = all jobs.</summary>
    public IReadOnlyList<JobId>? RequiredJobs { get; init; }

    /// <summary>Skills required before the quest can start.</summary>
    public IReadOnlyList<QuestSkillReq>? RequiredSkills { get; init; }

    /// <summary>Pet item template required for acceptance, if any.</summary>
    public ItemTemplateId? RequiredPet { get; init; }

    /// <summary>Map template IDs the player must be inside to accept the quest.</summary>
    public IReadOnlyList<FieldTemplateId>? FieldEnterReqs { get; init; }

    /// <summary>Cooldown in minutes between quest attempts (repeatable quests).</summary>
    public int? Interval { get; init; }

    /// <summary>Earliest in-game hour when the quest may be started.</summary>
    public int? StartHour { get; init; }

    /// <summary>Latest in-game hour when the quest may be started.</summary>
    public int? EndHour { get; init; }

    /// <summary>Minimum fame (popularity) value required to accept the quest.</summary>
    public int? FameRequired { get; init; }

    /// <summary>Allowed days-of-week for starting the quest (1=Mon … 7=Sun).</summary>
    public IReadOnlyList<QuestDayOfWeek>? DayOfWeek { get; init; }

    /// <summary>Minimum mount/taming mob level required.</summary>
    public int? TamingMobLevelMin { get; init; }

    /// <summary>Presence = quest is auto-accepted when its trigger NPC is used.</summary>
    public bool AutoAccept { get; init; }
}
