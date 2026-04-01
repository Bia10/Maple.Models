namespace Maple.Models.Users;

/// <summary>
/// Character quest-completion records keyed by quest identifier.
/// Maps <c>CharacterData::mQuestComplete</c> (PDB) — a
/// <c>ZMap&lt;unsigned short, _FILETIME, unsigned short&gt;</c>.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </summary>
public sealed class CharacterQuestCompletes : ICharacterQuestCompletes
{
    /// <summary>Completion records keyed by quest identifier (<c>usQRKey</c>).</summary>
    public IReadOnlyDictionary<int, QuestCompleteRecord> Records { get; init; } =
        new Dictionary<int, QuestCompleteRecord>();

    /// <inheritdoc/>
    IQuestCompleteRecord? ICharacterQuestCompletes.this[int questId] =>
        Records.TryGetValue(questId, out var r) ? r : null;
}
