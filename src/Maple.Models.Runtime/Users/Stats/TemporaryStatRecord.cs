namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted standard temporary-stat entry covering the common case: a numeric payload,
/// a source ID, and an optional absolute expiry.
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatRecord
{
    /// <summary>
    /// Numeric stat payload (e.g. speed delta, buff magnitude, flag value).
    /// Interpretation depends on the <c>TemporaryStatType</c> key used to store this record.
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Skill or item template ID that applied this stat.
    /// </summary>
    public int Reason { get; set; }

    /// <summary>
    /// Absolute UTC expiry timestamp, or <see langword="null"/> for non-expiring buffs.
    /// </summary>
    public DateTime? DateExpire { get; set; }
}
