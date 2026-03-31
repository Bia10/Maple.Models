using Maple.Enums;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Level, stat, and job requirements to equip an item.
/// </summary>
/// <param name="ReqLevel">Minimum character level required to equip.</param>
/// <param name="ReqJob">Job-category bitmask; see <see cref="JobCategory"/> for bit definitions.</param>
/// <param name="ReqSTR">Minimum STR required to equip.</param>
/// <param name="ReqDEX">Minimum DEX required to equip.</param>
/// <param name="ReqINT">Minimum INT required to equip.</param>
/// <param name="ReqLUK">Minimum LUK required to equip.</param>
/// <param name="ReqFame">Minimum fame (popularity) required to equip.</param>
/// <param name="ReqMobLevel">Minimum mob level applicable to special equipment items.</param>
public readonly record struct ItemEquipRequirements(
    int ReqLevel,
    JobCategory ReqJob,
    int ReqSTR,
    int ReqDEX,
    int ReqINT,
    int ReqLUK,
    int ReqFame,
    int ReqMobLevel = 0
);
