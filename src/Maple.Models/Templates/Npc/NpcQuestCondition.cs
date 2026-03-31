using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// A quest-state condition for triggering a conditional NPC behavior branch.
/// Defines a required NpcQuestState for the conditional branch to activate.
/// </summary>
/// <param name="QuestId">Quest template ID that this condition evaluates.</param>
/// <param name="State">Required quest-state value.</param>
public readonly record struct NpcQuestCondition(QuestTemplateId QuestId, QuestState State);
