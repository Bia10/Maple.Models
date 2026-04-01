namespace Maple.Models.Users;

/// <summary>
/// Read/write contract for Wild-Hunter-specific persisted capture state.
/// Implemented by <see cref="CharacterWildHunterInfo"/>.
/// </summary>
public interface ICharacterWildHunterInfo
{
    /// <summary>Active mount / riding type (<c>GW_WildHunterInfo::nRidingType</c>).</summary>
    byte RidingType { get; set; }

    /// <summary>Captured mob template identifiers (<c>GW_WildHunterInfo::adwCapturedMob[5]</c>).</summary>
    IReadOnlyList<int> CaptureMob { get; }
}
