namespace Maple.Models.Users;

/// <summary>
/// Persisted completion record for a finished quest.
/// Maps to <c>GW_QuestComplete</c> (PDB): <c>usQRKey</c> (the quest ID, stored as the map key)
/// and <c>tEnd</c> (Unix timestamp of the moment the quest was completed).
/// </summary>
public sealed class QuestCompleteRecord : IQuestCompleteRecord
{
    /// <summary>
    /// UTC timestamp when the quest was completed (<c>GW_QuestComplete::tEnd</c>, a Unix time value in C++).
    /// </summary>
    public DateTime DateFinish { get; set; }
}
