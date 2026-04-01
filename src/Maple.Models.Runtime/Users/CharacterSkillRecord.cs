namespace Maple.Models.Users;

/// <summary>
/// Mutable persisted skill state for a single character skill slot.
/// Maps to <c>GW_SkillRecord</c> (PDB), which is stored in
/// <c>CharacterData::m_mSkillRecord</c> keyed by <c>nSkillID</c>.
/// </summary>
public sealed class CharacterSkillRecord : ICharacterSkillRecord
{
    /// <summary>
    /// Current skill level (<c>GW_SkillRecord::nInfo</c>).
    /// The PDB field is named <c>nInfo</c> rather than <c>nLevel</c>; in practice it always stores the level.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Master level cap for skills that can be upgraded by a master book
    /// (<c>GW_SkillRecord::nMasterLevel</c>).
    /// <see langword="null"/> for skills that have a fixed master level defined in the skill template.
    /// </summary>
    public int? MasterLevel { get; set; }

    /// <summary>
    /// Expiry timestamp for time-limited skills such as Silver/Master scrolls
    /// (<c>GW_SkillRecord::dateExpire</c>, a <c>_FILETIME</c> in C++).
    /// <see langword="null"/> when the skill is permanent.
    /// </summary>
    public DateTime? DateExpire { get; set; }
}
