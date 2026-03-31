using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>NPC dialogue lines for a quest (loaded on-demand).</summary>
/// <param name="StartLines">Dialogue lines shown when the quest starts.</param>
/// <param name="EndLines">Dialogue lines shown when the quest ends.</param>
/// <param name="StartNpcId">Portrait NPC template ID shown during the start dialogue.</param>
/// <param name="StartAsk">When true, the start dialogue uses an ask-mode bubble instead of a say bubble.</param>
/// <param name="EndNpcId">Portrait NPC template ID shown during the end dialogue.</param>
/// <param name="EndAsk">When true, the end dialogue uses an ask-mode bubble instead of a say bubble.</param>
public sealed record QuestSayEntry(
    IReadOnlyList<string>? StartLines,
    IReadOnlyList<string>? EndLines,
    NpcTemplateId? StartNpcId = null,
    bool StartAsk = false,
    NpcTemplateId? EndNpcId = null,
    bool EndAsk = false
);
