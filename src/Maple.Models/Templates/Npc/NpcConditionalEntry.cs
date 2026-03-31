using Maple.Enums;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// A single condition branch for a conditional NPC behavior.
/// Conditional behavior is typically triggered by quest state.
/// </summary>
/// <param name="NodeName">Source node name for the conditional branch.</param>
/// <param name="Action">Animation action to play when this conditional triggers.</param>
/// <param name="QuestConditions">Required quest-state conditions; all must be satisfied for the branch to activate.</param>
/// <param name="SpeakLines">Dialogue lines displayed when this conditional branch is active.</param>
/// <param name="Gender">Gender restriction for the branch; <see langword="null"/> means any gender.</param>
/// <param name="IsHidden">Hides the NPC sprite while this conditional branch is active.</param>
public sealed record NpcConditionalEntry(
    string NodeName,
    string? Action,
    IReadOnlyList<NpcQuestCondition>? QuestConditions = null,
    IReadOnlyList<string>? SpeakLines = null,
    Gender? Gender = null,
    bool IsHidden = false
);
