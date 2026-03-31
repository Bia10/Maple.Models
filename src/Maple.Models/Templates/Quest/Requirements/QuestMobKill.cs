using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A mob kill objective for a quest completion check.</summary>
/// <param name="MobId">Template ID of the mob to defeat.</param>
/// <param name="Count">Required kill count.</param>
public readonly record struct QuestMobKill(MobTemplateId MobId, int Count);
