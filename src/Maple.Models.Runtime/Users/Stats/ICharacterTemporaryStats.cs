using Maple.Enums;

namespace Maple.Models.Users.Stats;

/// <summary>
/// Contract for the persisted temporary-stat aggregate.
/// Implemented by <see cref="CharacterTemporaryStats"/>.
/// </summary>
public interface ICharacterTemporaryStats
{
    /// <summary>Returns the standard stat record for <paramref name="type"/>, or <see langword="null"/> if inactive.</summary>
    TemporaryStatRecord? this[TemporaryStatType type] { get; }

    /// <summary>Standard temporary-stat records keyed by stat type.</summary>
    IReadOnlyDictionary<TemporaryStatType, TemporaryStatRecord> Records { get; }

    /// <summary>Dice buff passive-rate bonus block.</summary>
    TemporaryStatDiceInfo DiceInfo { get; }

    /// <summary>Energy Charge timed section.</summary>
    TemporaryStatTimedRecord EnergyCharged { get; }

    /// <summary>Dash speed timed section.</summary>
    TemporaryStatTimedRecord DashSpeed { get; }

    /// <summary>Dash jump timed section.</summary>
    TemporaryStatTimedRecord DashJump { get; }

    /// <summary>Active mount / ride-vehicle state block.</summary>
    TemporaryStatRideVehicleRecord RideVehicle { get; }

    /// <summary>Party booster timing block.</summary>
    TemporaryStatPartyBoosterRecord PartyBooster { get; }

    /// <summary>Guided bullet lock-on block.</summary>
    TemporaryStatGuidedBulletRecord GuidedBullet { get; }

    /// <summary>Undead timed section.</summary>
    TemporaryStatTimedRecord Undead { get; }
}
