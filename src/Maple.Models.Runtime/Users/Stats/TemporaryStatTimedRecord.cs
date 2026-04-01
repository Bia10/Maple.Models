namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted timed temporary-stat section for stats that store an explicit duration
/// alongside the standard payload (e.g. Energy Charge, Dash, Undead).
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatTimedRecord
{
    /// <summary>
    /// Configured per-skill duration for this buff instance.
    /// Used to resume the remaining duration correctly after a server restart.
    /// </summary>
    public TimeSpan Term { get; set; }

    /// <summary>
    /// Wall-clock timestamp of the last application or refresh of this buff.
    /// Combined with <see cref="Term"/> to derive remaining duration on reload.
    /// </summary>
    public DateTime DateUpdated { get; set; }

    /// <summary>Numeric stat payload (magnitude or flag value for this buff).</summary>
    public int Option { get; set; }

    /// <summary>Skill or item template ID that applied this buff.</summary>
    public int Reason { get; set; }

    /// <summary>Absolute UTC expiry timestamp, or <see langword="null"/> when expiry is computed from <see cref="DateUpdated"/> + <see cref="Term"/>.</summary>
    public DateTime? DateExpire { get; set; }
}
