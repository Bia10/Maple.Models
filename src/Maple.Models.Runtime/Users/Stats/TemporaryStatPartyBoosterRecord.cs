namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted party-booster temporary-stat section.
/// Requires both <see cref="DateStart"/> and <see cref="Term"/> to correctly resume
/// remaining duration across sessions — the booster timer runs independently of wall-clock
/// buff refresh, so the full start anchor plus total term must be persisted.
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatPartyBoosterRecord
{
    /// <summary>
    /// Wall-clock timestamp when the party booster was activated.
    /// Combined with <see cref="Term"/> to compute elapsed and remaining duration on reload.
    /// </summary>
    public DateTime DateStart { get; set; }

    /// <summary>
    /// Configured total run-time of the party booster.
    /// Subtracted from elapsed time since <see cref="DateStart"/> to determine remaining duration.
    /// </summary>
    public TimeSpan Term { get; set; }

    /// <summary>Wall-clock timestamp of the last application or refresh of this buff.</summary>
    public DateTime DateUpdated { get; set; }

    /// <summary>Numeric stat payload (booster magnitude or flag value).</summary>
    public int Option { get; set; }

    /// <summary>Skill or item template ID that applied the party booster.</summary>
    public int Reason { get; set; }

    /// <summary>Absolute UTC expiry timestamp, or <see langword="null"/> when expiry is derived from <see cref="DateStart"/> + <see cref="Term"/>.</summary>
    public DateTime? DateExpire { get; set; }
}
