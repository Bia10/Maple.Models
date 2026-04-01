namespace Maple.Models.Users;

/// <summary>
/// Contract for character extended quest-progress records keyed by quest identifier.
/// Implemented by <see cref="CharacterQuestRecordsEx"/>.
/// </summary>
public interface ICharacterQuestRecordsEx
{
    /// <summary>Returns the extended progress record for <paramref name="questId"/>, or <see langword="null"/> if absent.</summary>
    IQuestRecordEx? this[int questId] { get; }
}
