using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>Movement and access rules for the map.</summary>
/// <param name="IsTown">Whether the map is a safe-zone town (enables return-to-town logic).</param>
/// <param name="IsSwim">Whether swimming movement mode is active throughout the map.</param>
/// <param name="IsFly">Whether free-flight movement is enabled.</param>
/// <param name="FieldLimit">Bitmask of disabled actions in the map (drop, portal, mount, etc.).</param>
/// <param name="ReturnMapId">Default return destination map.</param>
/// <param name="LvLimit">Minimum entry level required.</param>
/// <param name="LvForceMove">Level threshold that auto-kicks the player from the map.</param>
/// <param name="MoveLimit">Movement restriction value configured for the map.</param>
/// <param name="HideMinimap">Whether the minimap panel is hidden.</param>
/// <param name="NeedSkillForFly">Whether a flight skill must be active before flying is allowed.</param>
/// <param name="PersonalShopAvailable">Whether personal shops may be opened.</param>
/// <param name="DropEverlast">Whether item drops persist indefinitely.</param>
/// <param name="ForcedReturn">Whether the map forces a return when conditions are met.</param>
/// <param name="CannotUseCashWeather">Whether cash weather items are disabled in the map.</param>
/// <param name="ExpeditionOnly">Whether entry is restricted to expedition parties.</param>
/// <param name="AutoLieDetector">Whether automatic lie-detector checks are enabled.</param>
/// <param name="NoMapCmd">Whether map commands are disabled.</param>
/// <param name="PqStay">Whether party-quest participants should remain in the map on disconnect.</param>
/// <param name="AllowedItems">Whitelist of item template IDs permitted in the map.</param>
/// <param name="ForbiddenSkills">Skills explicitly blocked inside the map.</param>
public sealed record MapConstraints(
    bool IsTown,
    bool IsSwim,
    bool IsFly,
    MapFieldLimit FieldLimit,
    FieldTemplateId ReturnMapId,
    int LvLimit = 0,
    int LvForceMove = 0,
    int MoveLimit = 0,
    bool HideMinimap = false,
    bool NeedSkillForFly = false,
    bool PersonalShopAvailable = false,
    bool DropEverlast = false,
    bool ForcedReturn = false,
    bool CannotUseCashWeather = false,
    bool ExpeditionOnly = false,
    bool AutoLieDetector = false,
    bool NoMapCmd = false,
    bool PqStay = false,
    IReadOnlyList<ItemTemplateId>? AllowedItems = null,
    IReadOnlyList<SkillTemplateId>? ForbiddenSkills = null
);
