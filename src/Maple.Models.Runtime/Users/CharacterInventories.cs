using System.Text.Json.Serialization;
using Maple.Enums;
using Maple.Models.Items.Inventory;

namespace Maple.Models.Users;

/// <summary>
/// Typed character inventory aggregate for the five persisted inventory tabs.
/// </summary>
public sealed class CharacterInventories : ICharacterInventories
{
    /// <summary>Standard slot capacity used for newly materialized character inventory tabs.</summary>
    public const short DefaultSlotMax = 24;

    /// <summary>Equip inventory.</summary>
    [JsonPropertyName("Equip")]
    public ItemInventory? Equip { get; init; }

    /// <summary>Consume inventory.</summary>
    [JsonPropertyName("Consume")]
    public ItemInventory? Consume { get; init; }

    /// <summary>Install inventory.</summary>
    [JsonPropertyName("Install")]
    public ItemInventory? Install { get; init; }

    /// <summary>Etc inventory.</summary>
    [JsonPropertyName("Etc")]
    public ItemInventory? Etc { get; init; }

    /// <summary>Cash inventory.</summary>
    [JsonPropertyName("Cash")]
    public ItemInventory? Cash { get; init; }

    IItemInventory? ICharacterInventories.Equip => Equip;
    IItemInventory? ICharacterInventories.Consume => Consume;
    IItemInventory? ICharacterInventories.Install => Install;
    IItemInventory? ICharacterInventories.Etc => Etc;
    IItemInventory? ICharacterInventories.Cash => Cash;

    IItemInventory? ICharacterInventories.this[ItemInventoryType type] =>
        type switch
        {
            ItemInventoryType.Equip => Equip,
            ItemInventoryType.Consume => Consume,
            ItemInventoryType.Install => Install,
            ItemInventoryType.Etc => Etc,
            ItemInventoryType.Cash => Cash,
            _ => null,
        };

    /// <summary>Creates a fully initialised empty inventory aggregate.</summary>
    public static CharacterInventories CreateEmpty() =>
        new()
        {
            Equip = new ItemInventory { SlotMax = DefaultSlotMax },
            Consume = new ItemInventory { SlotMax = DefaultSlotMax },
            Install = new ItemInventory { SlotMax = DefaultSlotMax },
            Etc = new ItemInventory { SlotMax = DefaultSlotMax },
            Cash = new ItemInventory { SlotMax = DefaultSlotMax },
        };
}
