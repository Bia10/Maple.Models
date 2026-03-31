using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// A dialogue line under an NPC animation action node.
/// </summary>
/// <param name="Action">Animation action name.</param>
/// <param name="Text">Dialogue text string for this speak entry.</param>
/// <param name="JobCategory">Job class category restriction for conditional speak entries.</param>
/// <param name="Job">From conditional speak entry. Specific job ID restriction.</param>
/// <param name="SpeakQuestId">From conditional speak entry. Quest gate for this dialogue line.</param>
public readonly record struct NpcActionSpeakEntry(
    string Action,
    string Text,
    JobClass? JobCategory = null,
    JobId? Job = null,
    QuestTemplateId? SpeakQuestId = null
);
