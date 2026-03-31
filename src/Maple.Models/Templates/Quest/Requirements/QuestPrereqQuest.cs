using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A prerequisite quest state check; specifies a quest and the state it must be in.</summary>
/// <param name="QuestId">Template ID of the prerequisite quest.</param>
/// <param name="RequiredState">Required quest state.</param>
public readonly record struct QuestPrereqQuest(QuestTemplateId QuestId, QuestState RequiredState);
