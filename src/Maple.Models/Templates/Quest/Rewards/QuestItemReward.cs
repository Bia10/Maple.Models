using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>An item reward granted when a quest phase completes.</summary>
/// <param name="ItemId">Template ID of the rewarded item.</param>
/// <param name="Count">Quantity awarded.</param>
/// <param name="Prop">Selection probability weight.</param>
/// <param name="Period">Expiry duration in days for time-limited rewards.</param>
/// <param name="Gender">Optional gender restriction.</param>
/// <param name="JobFilter">Optional job class restriction for receiving the reward; 0 = all jobs.</param>
public readonly record struct QuestItemReward(
    ItemTemplateId ItemId,
    int Count,
    int Prop,
    int? Period = null,
    Gender? Gender = null,
    JobId? JobFilter = null
);
