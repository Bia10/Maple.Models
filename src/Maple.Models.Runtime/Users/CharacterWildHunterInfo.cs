namespace Maple.Models.Users;

/// <summary>
/// Wild-Hunter-specific persisted capture state.
/// Maps to <c>GW_WildHunterInfo</c> (PDB).
/// </summary>
/// <remarks>
/// The C++ struct also contains <c>nIdx</c> (int), a server-internal taming-mob manager
/// index that is transient session state and is not persisted here.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </remarks>
public sealed class CharacterWildHunterInfo : ICharacterWildHunterInfo
{
    /// <summary>Maximum number of captured mobs (<c>GW_WildHunterInfo::adwCapturedMob[5]</c> is a fixed 5-element array).</summary>
    public const int MaxCapturedMobs = 5;

    /// <summary>
    /// Active mount / riding type (<c>GW_WildHunterInfo::nRidingType</c>).
    /// 0 = jaguar not active; non-zero values indicate the jaguar skin/type in use.
    /// </summary>
    public byte RidingType { get; set; }

    /// <summary>
    /// Captured mob template identifiers (<c>GW_WildHunterInfo::adwCapturedMob[5]</c>).
    /// The C++ struct holds a fixed 5-slot array; must not exceed <see cref="MaxCapturedMobs"/> entries.
    /// </summary>
    public IReadOnlyList<int> CaptureMob
    {
        get => _captureMob;
        init
        {
            if (value.Count > MaxCapturedMobs)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    value.Count,
                    $"Captured mob list exceeds maximum capacity of {MaxCapturedMobs}."
                );
            _captureMob = new List<int>(value).AsReadOnly();
        }
    }
    private IReadOnlyList<int> _captureMob = [];

    IReadOnlyList<int> ICharacterWildHunterInfo.CaptureMob => CaptureMob;
}
