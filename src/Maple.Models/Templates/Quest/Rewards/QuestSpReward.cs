using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A skill point reward granted when a quest phase completes.</summary>
/// <param name="JobId">Job category that scopes the SP reward; null when uncategorized.</param>
/// <param name="Amount">Amount of SP granted.</param>
public readonly record struct QuestSpReward(JobId? JobId, int Amount);
