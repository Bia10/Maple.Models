namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted guided-bullet temporary-stat section.
/// Extends the standard payload with <see cref="MobID"/> — the mob currently locked
/// by the Mechanic's Guided Bullet skill.
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class TemporaryStatGuidedBulletRecord
{
    /// <summary>
    /// Mob template ID currently targeted and tracked by the guided bullet.
    /// 0 when no target is locked.
    /// </summary>
    public int MobID { get; set; }

    /// <summary>Wall-clock timestamp of the last application or refresh of this buff.</summary>
    public DateTime DateUpdated { get; set; }

    /// <summary>Numeric stat payload (guided bullet damage or effect magnitude).</summary>
    public int Option { get; set; }

    /// <summary>Skill template ID that applied the guided bullet buff.</summary>
    public int Reason { get; set; }

    /// <summary>Absolute UTC expiry timestamp, or <see langword="null"/> when the buff does not expire independently of session state.</summary>
    public DateTime? DateExpire { get; set; }
}
