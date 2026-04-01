using Maple.Models.Items.Storage;

namespace Maple.Models.Users;

/// <summary>
/// Mutable account-per-world runtime aggregate with shared storage state.
/// No <c>GW_</c> PDB struct maps to this class — it is a server-side persistence construct introduced by Edelstein.
/// See <c>docs/runtime-character-models.md</c> for the field inventory.
/// </summary>
public sealed class AccountWorld : IAccountWorld
{
    /// <summary>Default slot capacity for a newly materialized locker.</summary>
    public const short DefaultLockerSlotMax = 24;

    /// <summary>Default slot capacity for a newly materialized trunk.</summary>
    public const short DefaultTrunkSlotMax = 4;

    /// <summary>Default number of character slots for a newly created account-world.</summary>
    public const int DefaultCharacterSlotMax = 3;

    /// <summary>Database identifier for the account-world row.</summary>
    public int Id { get; set; }

    /// <summary>Owning account identifier.</summary>
    public int AccountId { get; set; }

    /// <summary>World identifier associated with the account.</summary>
    public int WorldId { get; set; }

    /// <summary>Shared-item locker for the world.</summary>
    public ItemLocker Locker { get; set; } = new() { SlotMax = DefaultLockerSlotMax };

    /// <summary>Shared-item trunk for the world.</summary>
    public ItemTrunk Trunk { get; set; } = new() { SlotMax = DefaultTrunkSlotMax };

    /// <summary>Unlocked character-slot capacity for the world.</summary>
    public int CharacterSlotMax { get; set; } = DefaultCharacterSlotMax;

    IItemLocker IAccountWorld.Locker
    {
        get => Locker;
        set => Locker = (ItemLocker)value;
    }
    IItemTrunk IAccountWorld.Trunk
    {
        get => Trunk;
        set => Trunk = (ItemTrunk)value;
    }
}
