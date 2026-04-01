namespace Maple.Models.Users;

/// <summary>
/// Persisted account-per-world snapshot containing locker, trunk, and slot-capacity state.
/// No <c>GW_</c> PDB struct maps to this record — it is a server-side persistence construct introduced by Edelstein.
/// See <c>docs/runtime-character-models.md</c> for the field inventory.
/// </summary>
public sealed record AccountWorldInfo
{
    /// <summary>Database identifier for the account-world row.</summary>
    public int Id { get; init; }

    /// <summary>Owning account identifier.</summary>
    public int AccountId { get; init; }

    /// <summary>World identifier associated with the account.</summary>
    public int WorldId { get; init; }

    /// <summary>Serialized locker payload.</summary>
    public string Locker { get; init; } = JsonDefaults.EmptyItemLocker;

    /// <summary>Serialized trunk payload.</summary>
    public string Trunk { get; init; } = JsonDefaults.EmptyItemTrunk;

    /// <summary>Maximum number of character slots unlocked for this world.</summary>
    public int CharacterSlotMax { get; init; } = AccountWorld.DefaultCharacterSlotMax;
}
