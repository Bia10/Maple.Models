using System.Text.Json.Serialization;
using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Storage;

/// <summary>
/// Metadata for a single item locker entry, including the stored item and associated
/// purchase / delivery bookkeeping fields.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ItemLockerSlot))]
public interface IItemLockerSlot
{
    /// <summary>Owning account identifier.</summary>
    int AccountId { get; init; }

    /// <summary>Purchasing or associated character identifier.</summary>
    int CharacterId { get; init; }

    /// <summary>Commodity identifier associated with the locked item.</summary>
    int CommodityId { get; init; }

    /// <summary>Name of the character associated with the purchase, if any.</summary>
    string? BuyCharacterName { get; init; }

    /// <summary>Payback rate stored for the locker entry.</summary>
    int PaybackRate { get; init; }

    /// <summary>Discount rate stored for the locker entry.</summary>
    int DiscountRate { get; init; }

    /// <summary>Stored item payload, or <see langword="null"/> when the slot is empty.</summary>
    IItemSlot? Item { get; init; }
}
