namespace Maple.Models.Users;

/// <summary>
/// Read/write contract for a persisted quest progress record.
/// Implemented by <see cref="QuestRecord"/>.
/// </summary>
public interface IQuestRecord
{
    /// <summary>Quest progress string (<c>GW_QuestRecord::sQRValue</c>; max 16 chars).</summary>
    string Value { get; set; }
}
