using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>Basic properties of a non-equip (bundle) item.</summary>
public sealed record ItemBundleInfo
{
    /// <summary>Creates a bundle-item model from grouped requirement, effect, and special-behavior payloads.</summary>
    /// <param name="requirements">Acceptance, restriction, and ownership requirements.</param>
    /// <param name="effects">Direct stat changes and consumable effects.</param>
    /// <param name="special">Specialized item-side systems and replacement behavior.</param>
    /// <param name="petData">Pet-specific item data.</param>
    public ItemBundleInfo(
        ItemBundleRequirements requirements,
        ItemBundleEffectData effects,
        ItemBundleSpecialData special,
        ItemPetInfo? petData = null
    )
    {
        Requirements = requirements;
        Effects = effects;
        Special = special;
        PetData = petData;
    }

    /// <summary>Gets the acceptance, restriction, and ownership requirements.</summary>
    public ItemBundleRequirements Requirements { get; init; }

    /// <summary>Gets the direct stat changes and consumable effects.</summary>
    public ItemBundleEffectData Effects { get; init; }

    /// <summary>Gets the specialized item-side systems and replacement behavior.</summary>
    public ItemBundleSpecialData Special { get; init; }

    /// <summary>Gets the pet-specific item payload when the bundle item represents a pet.</summary>
    public ItemPetInfo? PetData { get; init; }

    /// <summary>Gets the maximum quantity that can stack in a single inventory slot.</summary>
    public int MaxPerSlot => Requirements.MaxPerSlot;

    /// <summary>Gets the sell price or base price value for the bundle item.</summary>
    public int SellPrice => Requirements.SellPrice;

    /// <summary>Gets whether the item is treated as a cash item.</summary>
    public bool IsCash => Requirements.IsCash;

    /// <summary>Gets whether the item is quest-only.</summary>
    public bool IsQuest => Requirements.IsQuest;

    /// <summary>Gets whether the item is unique.</summary>
    public bool IsOnly => Requirements.IsOnly;

    /// <summary>Gets whether trading is blocked.</summary>
    public bool IsTradeBlock => Requirements.IsTradeBlock;

    /// <summary>Gets whether the item cannot be sold.</summary>
    public bool IsNotSale => Requirements.IsNotSale;

    /// <summary>Gets the minimum character level required to use the item.</summary>
    public int ReqLevel => Requirements.ReqLevel;

    /// <summary>Gets the maximum stack or capacity value.</summary>
    public int Max => Requirements.Max;

    /// <summary>Gets whether the item is tied to party quest usage.</summary>
    public bool IsPartyQuest => Requirements.IsPartyQuest;

    /// <summary>Gets whether the item can be shared within the account.</summary>
    public bool IsAccountSharable => Requirements.IsAccountSharable;

    /// <summary>Gets the required field identifiers.</summary>
    public IReadOnlyList<FieldTemplateId>? ReqFields => Requirements.ReqFields;

    /// <summary>Gets the quest that must be in progress.</summary>
    public QuestTemplateId? ReqQuestOnProgress => Requirements.ReqQuestOnProgress;

    /// <summary>Gets the per-unit sell price for stackable items (WZ key <c>unitPrice</c>); 0.0 if unused.</summary>
    public double UnitPrice => Requirements.UnitPrice;

    /// <summary>Gets the physical attack value.</summary>
    public int Pad => Effects.Pad;

    /// <summary>Gets whether the bundle item is flagged as a Monster Book card.</summary>
    public bool IsMonsterBookCard => Effects.IsMonsterBookCard;

    /// <summary>Gets the Monster Carnival type value.</summary>
    public MonsterCarnivalMapType? McType => Effects.McType;

    /// <summary>Gets the HP value.</summary>
    public int Hp => Effects.Hp;

    /// <summary>Gets the MP value.</summary>
    public int Mp => Effects.Mp;

    /// <summary>Gets the HP percentage value.</summary>
    public int HpR => Effects.HpR;

    /// <summary>Gets the MP percentage value.</summary>
    public int MpR => Effects.MpR;

    /// <summary>Gets the HP quantity value.</summary>
    public int HpQ => Effects.HpQ;

    /// <summary>Gets the MP quantity value.</summary>
    public int MpQ => Effects.MpQ;

    /// <summary>Gets the effect or buff duration; see <see cref="ItemBundleEffectData.Time"/> for units.</summary>
    public int Time => Effects.Time;

    /// <summary>Gets the scroll success chance in percent (0–100).</summary>
    public int Success => Effects.Success;

    /// <summary>Gets the curse rate value.</summary>
    public int Cursed => Effects.Cursed;

    /// <summary>Gets the recovery value.</summary>
    public int Recover => Effects.Recover;

    /// <summary>Gets the slip-prevention value.</summary>
    public int PreventSlip => Effects.PreventSlip;

    /// <summary>Gets the buff item template identifier.</summary>
    public ItemTemplateId? BuffItemId => Effects.BuffItemId;

    /// <summary>Gets the destination field identifier.</summary>
    public FieldTemplateId? MoveTo => Effects.MoveTo;

    /// <summary>Gets the speed bonus granted by the item.</summary>
    public int Speed => Effects.Speed;

    /// <summary>Gets the jump bonus granted by the item.</summary>
    public int Jump => Effects.Jump;

    /// <summary>Gets the physical defense bonus granted by the item.</summary>
    public int Pdd => Effects.Pdd;

    /// <summary>Gets the scroll classification item identifier.</summary>
    public ItemTemplateId? ScrollId => Special.ScrollId;

    /// <summary>Gets the slot exhaustion warning threshold.</summary>
    public int? WarningState => Special.WarningState;

    /// <summary>Gets the partner item identifier for couple chairs.</summary>
    public ItemTemplateId? CoupleId => Special.CoupleId;

    /// <summary>Gets the number of character levels granted on use.</summary>
    public int? IncLevel => Special.IncLevel;

    /// <summary>Gets the consumable buff specification applied on use.</summary>
    public ItemConsumeSpec? ConsumeSpec => Special.ConsumeSpec;

    /// <summary>Gets the quest delivery token type.</summary>
    public ItemQuestDeliveryType? QuestDeliveryType => Special.QuestDeliveryType;

    /// <summary>Gets the quest delivery effect name.</summary>
    public string? QuestDeliveryEffect => Special.QuestDeliveryEffect;

    /// <summary>Gets the bridle or mount-capture item data.</summary>
    public ItemBridleInfo? BridleInfo => Special.BridleInfo;

    /// <summary>Gets the lottery or gacha reward data.</summary>
    public ItemLotteryInfo? Lottery => Special.Lottery;

    /// <summary>Gets the skill granted or required by the item.</summary>
    public SkillTemplateId? GrantedSkillId => Special.GrantedSkillId;

    /// <summary>Gets the required skill level for item use.</summary>
    public int? ReqSkillLevel => Special.ReqSkillLevel;

    /// <summary>Gets the applicable karma scissors type.</summary>
    public int AppliableKarmaType => Special.AppliableKarmaType;

    /// <summary>Gets whether right-click cancellation is disabled.</summary>
    public bool NoCancelMouse => Special.NoCancelMouse;

    /// <summary>Gets whether the item uses enlarged visuals.</summary>
    public bool IsBigSize => Special.IsBigSize;

    /// <summary>Gets whether the item expires on logout.</summary>
    public bool IsExpireOnLogout => Special.IsExpireOnLogout;

    /// <summary>Gets whether the item is time-limited.</summary>
    public bool IsTimeLimited => Special.IsTimeLimited;

    /// <summary>Gets the replacement item template identifier on expiry.</summary>
    public ItemTemplateId ReplaceItemId => Special.ReplaceItemId;

    /// <summary>Gets the message shown when the item is replaced.</summary>
    public string? ReplaceMsg => Special.ReplaceMsg;

    /// <summary>Gets the replacement cycle length in minutes.</summary>
    public int ReplacePeriod => Special.ReplacePeriod;
}
