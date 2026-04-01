namespace Maple.Models.Users;

/// <summary>
/// Character extended quest-progress records keyed by quest identifier.
/// Maps <c>CharacterData::mQuestRecordEx</c> (PDB) — a
/// <c>ZMap&lt;unsigned short, CSimpleStrMap, unsigned short&gt;</c>.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </summary>
public sealed class CharacterQuestRecordsEx : ICharacterQuestRecordsEx
{
    /// <summary>Extended quest records keyed by quest identifier (<c>usQRKey</c>).</summary>
    public IReadOnlyDictionary<int, QuestRecordEx> Records { get; init; } = new Dictionary<int, QuestRecordEx>();

    /// <inheritdoc/>
    IQuestRecordEx? ICharacterQuestRecordsEx.this[int questId] => Records.TryGetValue(questId, out var r) ? r : null;
}
