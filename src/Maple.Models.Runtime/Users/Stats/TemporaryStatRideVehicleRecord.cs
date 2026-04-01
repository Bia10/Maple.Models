namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted ride-vehicle temporary-stat section.
/// Expiry is driven by ride-state rules rather than a stored term, so no <c>Term</c> field is needed.
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatRideVehicleRecord
{
    /// <summary>Wall-clock timestamp of the last mount activation or refresh.</summary>
    public DateTime DateUpdated { get; set; }

    /// <summary>
    /// Active mount or vehicle item template ID.
    /// Identifies which mount skin or vehicle is currently in use.
    /// </summary>
    public int Option { get; set; }

    /// <summary>Skill or item template ID that triggered the mount state.</summary>
    public int Reason { get; set; }

    /// <summary>Absolute UTC expiry timestamp, or <see langword="null"/> when ride state is session-controlled.</summary>
    public DateTime? DateExpire { get; set; }
}
