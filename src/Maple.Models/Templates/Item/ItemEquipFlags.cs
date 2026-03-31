using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>Tradability/upgrade flags, economy data, and visual overrides for an equip item.</summary>
/// <param name="Tradability">Tradability and restriction flags for the equip.</param>
/// <param name="Upgrade">Upgrade-related data for the equip.</param>
/// <param name="SellPrice">Base NPC sell value in mesos.</param>
/// <param name="IsBigSize">Whether the equip uses enlarged character sprite scale.</param>
/// <param name="IsEpic">Whether the equip is an epic-grade item (golden border UI treatment).</param>
/// <param name="IsTransform">Whether equipping this item triggers a character transformation effect.</param>
/// <param name="NameTag">Item template ID of the name-tag cosmetic applied to the equip; <see langword="null"/> = none.</param>
/// <param name="ChatBalloon">Item template ID of the chat-balloon cosmetic applied to the equip; <see langword="null"/> = none.</param>
/// <param name="Durability">Current durability value.</param>
/// <param name="SpecialId">Secondary item template ID used for special-linked equip mechanics; <see langword="null"/> = none.</param>
/// <param name="ReplaceItemId">Item template ID that replaces this equip on expiry or special condition; <see langword="null"/> = none.</param>
/// <param name="ReplaceMsg">System message displayed when the replacement occurs.</param>
/// <param name="Gender">Equip gender restriction.</param>
/// <param name="AttackSpeed">Weapon attack-speed category enum; <see langword="null"/> for non-weapons.</param>
/// <param name="IsInvisibleCash">Whether this cash cosmetic equip renders invisibly on the character model (hidden override slot).</param>
/// <param name="AfterImage">Weapon after-image trail animation name; absent on non-weapons.</param>
/// <param name="ISlot">Inventory slot type string.</param>
/// <param name="VSlot">Visual slot type string.</param>
/// <param name="Sfx">Sound effect played on equip or use actions.</param>
/// <param name="WalkAnim">Walk animation set index override for weapon-category characters.</param>
/// <param name="StandAnim">Stand/idle animation set index.</param>
/// <param name="AttackAnim">Attack animation set index.</param>
/// <param name="NAttackSpeed">Attack-speed animation frame rate index used by the animation system.</param>
public sealed record ItemEquipFlags(
    ItemTradabilityFlags Tradability,
    ItemUpgradeData Upgrade,
    int SellPrice,
    bool IsBigSize = false,
    bool IsEpic = false,
    bool IsTransform = false,
    ItemTemplateId? NameTag = null,
    ItemTemplateId? ChatBalloon = null,
    int Durability = 0,
    ItemTemplateId? SpecialId = null,
    ItemTemplateId? ReplaceItemId = null,
    string? ReplaceMsg = null,
    Gender Gender = Gender.None,
    ItemAttackSpeed? AttackSpeed = null,
    bool IsInvisibleCash = false,
    string? AfterImage = null,
    string? ISlot = null,
    string? VSlot = null,
    string? Sfx = null,
    string? WalkAnim = null,
    string? StandAnim = null,
    string? AttackAnim = null,
    int NAttackSpeed = 0
);
