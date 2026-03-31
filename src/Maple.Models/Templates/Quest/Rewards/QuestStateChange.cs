using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A quest state mutation triggered as part of another quest's reward or script action.</summary>
/// <param name="QuestId">Template ID of the quest whose state changes.</param>
/// <param name="State">Target quest state.</param>
public readonly record struct QuestStateChange(QuestTemplateId QuestId, QuestState State);
