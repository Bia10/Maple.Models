namespace Maple.Models.Users;

/// <summary>
/// Persisted quest progress record.
/// Maps to <c>GW_QuestRecord</c> (PDB).
/// The struct holds an 17-byte fixed char array (<c>sQRValue[17]</c>), giving a maximum of 16
/// usable characters plus null-terminator. Progress is formatted as a game-specific string
/// (e.g. comma-separated kill counts like <c>"003000"</c>).
/// </summary>
public sealed class QuestRecord : IQuestRecord
{
    /// <summary>Maximum usable length of <see cref="Value"/> (<c>sQRValue[17]</c> = 16 chars + null-terminator).</summary>
    public const int MaxValueLength = 16;

    /// <summary>
    /// Quest progress string (<c>GW_QuestRecord::sQRValue</c>; max <see cref="MaxValueLength"/> chars).
    /// Format is quest-defined; typically numeric counters or flag characters.
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
                    $"Quest record value exceeds maximum length of {MaxValueLength}."
                );
            _value = value;
        }
    }
    private string _value = string.Empty;
}
