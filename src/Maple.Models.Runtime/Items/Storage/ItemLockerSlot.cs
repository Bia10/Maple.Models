using Maple.Models.Items.Slots;

namespace Maple.Models.Items.Storage;

/// <summary>
/// Concrete locker entry containing bookkeeping metadata plus the stored item payload.
/// </summary>
public sealed class ItemLockerSlot : IItemLockerSlot
{
    /// <summary>Owning account identifier.</summary>
    public int AccountId { get; init; }

    /// <summary>Purchasing or associated character identifier.</summary>
    public int CharacterId { get; init; }

    /// <summary>Commodity identifier associated with the locked item.</summary>
    public int CommodityId { get; init; }

    /// <summary>Name of the character associated with the purchase, if any.</summary>
    public string? BuyCharacterName { get; init; }

    /// <summary>Payback rate stored for the locker entry.</summary>
    public int PaybackRate { get; init; }

    /// <summary>Discount rate stored for the locker entry.</summary>
    public int DiscountRate { get; init; }

    /// <summary>Stored item payload, or <see langword="null"/> when the slot is empty.</summary>
    public IItemSlot? Item { get; init; }

    /// <summary>
    /// Creates a detached copy of this locker slot.
    /// The stored item reference remains shared because locker entries are treated as shallow payload wrappers.
    /// </summary>
    public ItemLockerSlot Clone() =>
        new()
        {
            AccountId = AccountId,
            CharacterId = CharacterId,
            CommodityId = CommodityId,
            BuyCharacterName = BuyCharacterName,
            PaybackRate = PaybackRate,
            DiscountRate = DiscountRate,
            Item = Item,
        };
}
