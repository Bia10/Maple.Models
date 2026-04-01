namespace Maple.Models.Users;

/// <summary>
/// Contract for character quest-completion records keyed by quest identifier.
/// Implemented by <see cref="CharacterQuestCompletes"/>.
/// </summary>
public interface ICharacterQuestCompletes
{
    /// <summary>Returns the completion record for <paramref name="questId"/>, or <see langword="null"/> if not completed.</summary>
    IQuestCompleteRecord? this[int questId] { get; }
}
