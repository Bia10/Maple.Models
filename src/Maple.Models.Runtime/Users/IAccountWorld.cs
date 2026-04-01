using Maple.Models.Items.Storage;

namespace Maple.Models.Users;

/// <summary>
/// Contract for a mutable account-per-world runtime aggregate.
/// Implemented by <see cref="AccountWorld"/>.
/// </summary>
public interface IAccountWorld
{
    /// <summary>Database identifier for the account-world row.</summary>
    int Id { get; set; }

    /// <summary>Owning account identifier.</summary>
    int AccountId { get; set; }

    /// <summary>World identifier associated with the account.</summary>
    int WorldId { get; set; }

    /// <summary>Shared-item locker for the world.</summary>
    IItemLocker Locker { get; set; }

    /// <summary>Shared-item trunk for the world.</summary>
    IItemTrunk Trunk { get; set; }

    /// <summary>Unlocked character-slot capacity for the world.</summary>
    int CharacterSlotMax { get; set; }
}
