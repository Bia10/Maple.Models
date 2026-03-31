using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// A single item in an NPC shop.
/// Price 0 means the item sells at its default price.
/// TokenItemId/TokenPrice are set for token-currency shops (PQ tokens, event coins, etc.).
/// </summary>
/// <param name="ItemId">Item template identifier sold in this slot.</param>
/// <param name="Price">Meso price charged for the item; 0 means the item's own default price applies.</param>
/// <param name="Period">Rental period applied to the purchased item, in source-defined units.</param>
/// <param name="TokenItemId">Token-currency item required for token-exchange shops (PQ coins, event currency, etc.).</param>
/// <param name="TokenPrice">Token amount required when <paramref name="TokenItemId"/> is set.</param>
/// <param name="LimitPerDay">Daily purchase limit for this shop slot.</param>
/// <param name="MaxPerSlot">Maximum quantity granted per purchase.</param>
/// <param name="Stock">Configured stock count for the shop slot.</param>
/// <param name="NRunOut">Whether the item cannot run out of stock.</param>
/// <param name="TamingMob">Taming-mob template unlocked or associated with this purchase.</param>
public readonly record struct NpcShopEntry(
    ItemTemplateId ItemId,
    int Price,
    int? Period = null,
    ItemTemplateId? TokenItemId = null,
    int? TokenPrice = null,
    int? LimitPerDay = null,
    int? MaxPerSlot = null,
    int? Stock = null,
    bool NRunOut = false,
    TamingMobTemplateId? TamingMob = null
);
