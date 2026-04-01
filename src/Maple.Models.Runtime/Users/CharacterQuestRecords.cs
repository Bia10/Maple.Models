namespace Maple.Models.Users;

/// <summary>
/// Character quest-progress records keyed by quest identifier.
/// Maps <c>CharacterData::mQuestRecord</c> (PDB) — a
/// <c>ZMap&lt;unsigned short, ZXString&lt;char&gt;, unsigned short&gt;</c>.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </summary>
public sealed class CharacterQuestRecords : ICharacterQuestRecords
{
    /// <summary>
    /// Quest records keyed by quest identifier.
    /// The PDB key type is <c>unsigned short</c> (<c>usQRKey</c>), but <c>int</c> is used here
    /// for JSON and ORM compatibility; quest IDs are always non-negative and within ushort range.
    /// </summary>
    public IReadOnlyDictionary<int, QuestRecord> Records { get; init; } = new Dictionary<int, QuestRecord>();

    /// <inheritdoc/>
    IQuestRecord? ICharacterQuestRecords.this[int questId] => Records.TryGetValue(questId, out var r) ? r : null;
}
