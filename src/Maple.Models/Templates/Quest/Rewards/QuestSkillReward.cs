using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A skill reward granted when a quest phase completes.</summary>
/// <param name="SkillId">Template ID of the skill being awarded or updated.</param>
/// <param name="SkillLevel">Skill level granted by the reward.</param>
/// <param name="MasterLevel">Master level override granted.</param>
/// <param name="JobFilter">Optional job class restriction for receiving the reward; 0 = all jobs.</param>
public readonly record struct QuestSkillReward(
    SkillTemplateId SkillId,
    int SkillLevel,
    int MasterLevel,
    JobId? JobFilter = null
);
