namespace Maple.Models.Users;

/// <summary>
/// Contract for character quest-progress records keyed by quest identifier.
/// Implemented by <see cref="CharacterQuestRecords"/>.
/// </summary>
public interface ICharacterQuestRecords
{
    /// <summary>Returns the progress record for <paramref name="questId"/>, or <see langword="null"/> if absent.</summary>
    IQuestRecord? this[int questId] { get; }
}
