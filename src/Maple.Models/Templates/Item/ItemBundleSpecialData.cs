using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Specialized side systems and replacement behavior attached to a bundle item. All fields are optional.
/// </summary>
/// <param name="ScrollId">Scroll classification item ID linking this item to a scroll category.</param>
/// <param name="WarningState">Item slot exhaustion warning threshold that triggers a client alert.</param>
/// <param name="CoupleId">Partner item ID for couple-chair items; both partners must each own the corresponding item.</param>
/// <param name="IncLevel">Character levels granted immediately on use.</param>
/// <param name="ConsumeSpec">Buff and scroll effect specification; see <see cref="ItemConsumeSpec"/>.</param>
/// <param name="QuestDeliveryType">Quest delivery token type; controls how the item interacts with the quest system on use.</param>
/// <param name="QuestDeliveryEffect">Effect name played during quest delivery animation.</param>
/// <param name="BridleInfo">Mount-capture data; present only on Taming items.</param>
/// <param name="Lottery">Gacha / lottery reward table; present only on random-reward items.</param>
/// <param name="GrantedSkillId">Skill ID granted or required by this item.</param>
/// <param name="ReqSkillLevel">Minimum level the character must have in <see cref="GrantedSkillId"/> to use the item.</param>
/// <param name="AppliableKarmaType">Karma scissors type code for bundle items.</param>
/// <param name="NoCancelMouse">When true, right-click cannot cancel this item's use.</param>
/// <param name="IsBigSize">Whether the item uses enlarged icon rendering in the UI.</param>
/// <param name="IsExpireOnLogout">Whether the item expires when the character logs out.</param>
/// <param name="IsTimeLimited">Whether the item has a time-based expiry.</param>
/// <param name="ReplaceItemId">Replacement item granted when this item expires.</param>
/// <param name="ReplaceMsg">Message displayed to the player when the replacement occurs.</param>
/// <param name="ReplacePeriod">Replacement cycle length in minutes.</param>
public sealed record ItemBundleSpecialData(
    ItemTemplateId? ScrollId = null,
    int? WarningState = null,
    ItemTemplateId? CoupleId = null,
    int? IncLevel = null,
    ItemConsumeSpec? ConsumeSpec = null,
    ItemQuestDeliveryType? QuestDeliveryType = null,
    string? QuestDeliveryEffect = null,
    ItemBridleInfo? BridleInfo = null,
    ItemLotteryInfo? Lottery = null,
    SkillTemplateId? GrantedSkillId = null,
    int? ReqSkillLevel = null,
    int AppliableKarmaType = 0,
    bool NoCancelMouse = false,
    bool IsBigSize = false,
    bool IsExpireOnLogout = false,
    bool IsTimeLimited = false,
    ItemTemplateId ReplaceItemId = default,
    string? ReplaceMsg = null,
    int ReplacePeriod = 0
);
