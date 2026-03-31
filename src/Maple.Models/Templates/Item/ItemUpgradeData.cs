using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Upgrade and enchantment metadata for an equip item.
/// </summary>
/// <param name="RemainingUpgrades">Total scroll upgrade slots the item was created with; at template level this equals the initial remaining count before any scrolling.</param>
/// <param name="TotalUpgrades">Total scroll upgrade slots the item started with.</param>
/// <param name="ItemUpgradeCount">Number of spell-trace upgrades (Star Force / Spell Trace applications) already applied.</param>
/// <param name="ItemUpgradeCountMax">Maximum number of spell-trace upgrades allowed on the item.</param>
/// <param name="MinGrade">Minimum item potential grade required to equip.</param>
/// <param name="KarmaType">Applicable karma scissors type code for this equip.</param>
/// <param name="EnchantCategory">Enchantment system category this item belongs to.</param>
/// <param name="SetItemId">Set-item group identifier; non-zero activates set-bonus lookup.</param>
public readonly record struct ItemUpgradeData(
    int RemainingUpgrades = 0,
    int TotalUpgrades = 0,
    int ItemUpgradeCount = 0,
    int ItemUpgradeCountMax = 0,
    ItemGrade MinGrade = ItemGrade.Normal,
    int KarmaType = 0,
    ItemEnchantCategory EnchantCategory = ItemEnchantCategory.None,
    SetItemTemplateId SetItemId = default
);
