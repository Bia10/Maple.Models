namespace Maple.Models.Users;

/// <summary>
/// Contract for the character skill-record aggregate.
/// Implemented by <see cref="CharacterSkills"/>.
/// </summary>
public interface ICharacterSkills
{
    /// <summary>Returns the skill record for <paramref name="skillId"/>, or <see langword="null"/> if not learned.</summary>
    ICharacterSkillRecord? this[int skillId] { get; }
}
