namespace Maple.Models.Users;

/// <summary>
/// Persisted extended quest progress record.
/// Maps to <c>GW_QuestRecordEx</c> (PDB).
/// The struct holds a 101-byte fixed char array (<c>sQRValue[101]</c>), giving a maximum of 100
/// usable characters plus null-terminator. Used for quests that need longer tracking strings
/// than the standard <see cref="QuestRecord"/> allows (16 chars).
/// </summary>
public sealed class QuestRecordEx : IQuestRecordEx
{
    /// <summary>Maximum usable length of <see cref="Value"/> (<c>sQRValue[101]</c> = 100 chars + null-terminator).</summary>
    public const int MaxValueLength = 100;

    /// <summary>
    /// Extended quest progress string (<c>GW_QuestRecordEx::sQRValue</c>; max <see cref="MaxValueLength"/> chars).
    /// Format is quest-defined and may include multiple fields separated by semicolons or similar delimiters.
    /// </summary>
    public string Value
    {
        get => _value;
        set
        {
            if (value.Length > MaxValueLength)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    value,
                    $"Extended quest record value exceeds maximum length of {MaxValueLength}."
                );
            _value = value;
        }
    }
    private string _value = string.Empty;
}
