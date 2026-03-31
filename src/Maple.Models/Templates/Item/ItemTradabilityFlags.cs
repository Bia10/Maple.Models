namespace Maple.Models.Templates.Item;

/// <summary>
/// Tradability and access-restriction flags for an equip item.
/// </summary>
/// <param name="IsCash">Whether the item is a cash shop item.</param>
/// <param name="IsOnly">Whether only one copy may exist in the character's possession at a time.</param>
/// <param name="IsTradeBlock">Whether the item cannot be traded between players.</param>
/// <param name="IsQuest">Whether the item is a quest item and cannot be traded.</param>
/// <param name="IsNotSale">Whether the item cannot be sold to NPC shops.</param>
/// <param name="IsTimeLimited">Whether the item has a time-based expiry.</param>
/// <param name="IsPartyQuest">Whether the item is restricted to party quest use.</param>
/// <param name="IsExpireOnLogout">Whether the item expires when the character logs out.</param>
/// <param name="IsAccountSharable">Whether the item can be shared across characters on the same account.</param>
/// <param name="IsOnlyEquip">Whether only one equipped instance is allowed simultaneously.</param>
/// <param name="IsNotExtend">Whether the item's expiry cannot be extended.</param>
/// <param name="IsBindedWhenEquipped">Binds the item to the character upon equipping, preventing subsequent trades.</param>
/// <param name="IsSharableOnce">Whether the item may be account-shared exactly once before becoming account-bound.</param>
/// <param name="IsWeekly">Whether the item resets on a weekly basis.</param>
/// <param name="IsTradeAvailable">Explicit opt-in flag marking the item as tradeable (overrides default restrictions).</param>
public readonly record struct ItemTradabilityFlags(
    bool IsCash = false,
    bool IsOnly = false,
    bool IsTradeBlock = false,
    bool IsQuest = false,
    bool IsNotSale = false,
    bool IsTimeLimited = false,
    bool IsPartyQuest = false,
    bool IsExpireOnLogout = false,
    bool IsAccountSharable = false,
    bool IsOnlyEquip = false,
    bool IsNotExtend = false,
    bool IsBindedWhenEquipped = false,
    bool IsSharableOnce = false,
    bool IsWeekly = false,
    bool IsTradeAvailable = false
);
