namespace Maple.Models.Users;

/// <summary>
/// Read/write contract for a persisted character skill record.
/// Implemented by <see cref="CharacterSkillRecord"/>.
/// </summary>
public interface ICharacterSkillRecord
{
    /// <summary>Current skill level (<c>GW_SkillRecord::nInfo</c>).</summary>
    int Level { get; set; }

    /// <summary>
    /// Master level cap, or <see langword="null"/> for skills with a fixed template-defined cap.
    /// </summary>
    int? MasterLevel { get; set; }

    /// <summary>
    /// Expiry timestamp for time-limited skills, or <see langword="null"/> when permanent.
    /// </summary>
    DateTime? DateExpire { get; set; }
}
