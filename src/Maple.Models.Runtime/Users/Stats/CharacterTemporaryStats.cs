using Maple.Enums;

namespace Maple.Models.Users.Stats;

/// <summary>
/// Persisted temporary-stat aggregate for a character.
/// Holds the <see cref="Records"/> dictionary for all standard stats plus dedicated
/// blocks for stat families whose runtime layout needs additional persisted fields
/// beyond the common option/reason/expiry triple.
/// Detailed runtime-schema notes are centralized in <c>docs/runtime-temporary-stats.md</c>.
/// </summary>
public sealed class CharacterTemporaryStats : ICharacterTemporaryStats
{
    /// <summary>
    /// Standard temporary-stat records keyed by stat type.
    /// Covers the majority of timed buffs; each entry stores a numeric payload,
    /// source skill/item ID, and an optional absolute expiry.
    /// </summary>
    public IReadOnlyDictionary<TemporaryStatType, TemporaryStatRecord> Records { get; init; } =
        new Dictionary<TemporaryStatType, TemporaryStatRecord>();

    /// <summary>
    /// Dice buff passive-rate bonus block (<c>SecondaryStat::nDice_</c>/<c>rDice_</c>).
    /// Kept separate because its layout is a flat struct of 22 named rate fields
    /// rather than the common option/reason/expiry triple.
    /// </summary>
    public TemporaryStatDiceInfo DiceInfo { get; init; } = new();

    /// <summary>
    /// Energy Charge timed section.
    /// Persists a dynamic term alongside the standard payload because charge expiry
    /// is tracked relative to the buff's wall-clock start rather than a fixed duration.
    /// </summary>
    public TemporaryStatTimedRecord EnergyCharged { get; init; } = new();

    /// <summary>
    /// Dash speed timed section.
    /// Uses a dynamic term because dash duration is configured per-skill rather than fixed.
    /// </summary>
    public TemporaryStatTimedRecord DashSpeed { get; init; } = new();

    /// <summary>
    /// Dash jump timed section.
    /// Uses a dynamic term for the same reason as <see cref="DashSpeed"/>.
    /// </summary>
    public TemporaryStatTimedRecord DashJump { get; init; } = new();

    /// <summary>
    /// Active mount / ride-vehicle state block.
    /// Kept separate because it stores a vehicle item ID in <c>Option</c> and
    /// expiry is driven by ride-state rules rather than the timed-buff term pattern.
    /// </summary>
    public TemporaryStatRideVehicleRecord RideVehicle { get; init; } = new();

    /// <summary>
    /// Party booster timing block.
    /// Kept separate because it additionally persists <c>DateStart</c> as the
    /// current-time anchor needed to resume the remaining duration across sessions.
    /// </summary>
    public TemporaryStatPartyBoosterRecord PartyBooster { get; init; } = new();

    /// <summary>
    /// Guided bullet lock-on block.
    /// Kept separate because it additionally persists <c>MobID</c> — the mob
    /// template ID currently targeted by the guided bullet.
    /// </summary>
    public TemporaryStatGuidedBulletRecord GuidedBullet { get; init; } = new();

    /// <summary>
    /// Undead timed section.
    /// Uses a dynamic term because undead duration is configured per-skill.
    /// </summary>
    public TemporaryStatTimedRecord Undead { get; init; } = new();

    /// <inheritdoc/>
    TemporaryStatRecord? ICharacterTemporaryStats.this[TemporaryStatType type] =>
        Records.TryGetValue(type, out var r) ? r : null;

    IReadOnlyDictionary<TemporaryStatType, TemporaryStatRecord> ICharacterTemporaryStats.Records => Records;
}
