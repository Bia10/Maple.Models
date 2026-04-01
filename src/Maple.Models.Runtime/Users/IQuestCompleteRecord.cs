namespace Maple.Models.Users;

/// <summary>
/// Read/write contract for a persisted quest completion record.
/// Implemented by <see cref="QuestCompleteRecord"/>.
/// </summary>
public interface IQuestCompleteRecord
{
    /// <summary>UTC timestamp when the quest was completed (<c>GW_QuestComplete::tEnd</c>).</summary>
    DateTime DateFinish { get; set; }
}
