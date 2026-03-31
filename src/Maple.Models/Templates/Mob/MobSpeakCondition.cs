using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// A single speak trigger condition for a mob chat-bubble entry.
/// </summary>
/// <param name="QuestId">Quest template ID that gates the speak entry.</param>
/// <param name="RequiredState">Required quest-state value for the condition to pass.</param>
/// <param name="PetId">Pet template ID that gates the speak entry.</param>
public readonly record struct MobSpeakCondition(QuestTemplateId? QuestId, int? RequiredState, PetTemplateId? PetId);
