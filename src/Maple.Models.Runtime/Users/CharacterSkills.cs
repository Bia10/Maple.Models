namespace Maple.Models.Users;

/// <summary>
/// Character skill records keyed by skill template identifier.
/// Unifies four separate <c>CharacterData</c> maps (<c>mSkillRecord</c>, <c>mSkillMasterLev</c>,
/// <c>mSkillExpired</c>) into one C# record per skill.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </summary>
public sealed class CharacterSkills : ICharacterSkills
{
    /// <summary>Skill records keyed by skill template identifier.</summary>
    public IReadOnlyDictionary<int, CharacterSkillRecord> Records { get; init; } =
        new Dictionary<int, CharacterSkillRecord>();

    /// <inheritdoc/>
    ICharacterSkillRecord? ICharacterSkills.this[int skillId] => Records.TryGetValue(skillId, out var r) ? r : null;
}
