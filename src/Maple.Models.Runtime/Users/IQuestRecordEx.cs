namespace Maple.Models.Users;

/// <summary>
/// Read/write contract for a persisted extended quest progress record.
/// Implemented by <see cref="QuestRecordEx"/>.
/// </summary>
public interface IQuestRecordEx
{
    /// <summary>Extended quest progress string (<c>GW_QuestRecordEx::sQRValue</c>; max 100 chars).</summary>
    string Value { get; set; }
}
