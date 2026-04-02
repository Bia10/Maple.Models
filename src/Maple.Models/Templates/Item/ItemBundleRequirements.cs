using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Acceptance, restriction, and ownership requirements for a bundle item.
/// </summary>
/// <param name="MaxPerSlot">Maximum number of this item that can stack in one inventory slot.</param>
/// <param name="SellPrice">Shop sell price in mesos.</param>
/// <param name="IsCash">Whether the item is a cash shop item.</param>
/// <param name="IsQuest">Whether the item is a quest item.</param>
/// <param name="IsOnly">Whether only one copy may exist in the character's possession.</param>
/// <param name="IsTradeBlock">Whether the item cannot be traded between players.</param>
/// <param name="IsNotSale">Whether the item cannot be sold to NPC shops.</param>
/// <param name="ReqLevel">Minimum character level required to use the item.</param>
/// <param name="Max">Maximum total quantity allowed in the character's inventory across all slots.</param>
/// <param name="IsPartyQuest">Whether the item is restricted to party quest use.</param>
/// <param name="IsAccountSharable">Whether the item can be shared across characters on the same account.</param>
/// <param name="ReqFields">Field IDs in which the item may be used; empty means unrestricted.</param>
/// <param name="ReqQuestOnProgress">Quest that must be in the in-progress state for the item to be usable.</param>
/// <param name="UnitPrice">Per-unit sell price for stackable items (WZ key <c>unitPrice</c>, C++ field <c>dSellUnitPrice</c>). 0.0 means use <see cref="SellPrice"/> as a flat price.</param>
public sealed record ItemBundleRequirements(
    int MaxPerSlot,
    int SellPrice,
    bool IsCash,
    bool IsQuest,
    bool IsOnly,
    bool IsTradeBlock,
    bool IsNotSale,
    int ReqLevel,
    int Max = 0,
    bool IsPartyQuest = false,
    bool IsAccountSharable = false,
    IReadOnlyList<FieldTemplateId>? ReqFields = null,
    QuestTemplateId? ReqQuestOnProgress = null,
    double UnitPrice = 0.0
);
