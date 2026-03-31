using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Map;

/// <summary>
/// Map-level environment properties including audio, rendering, hazards, and event scripting.
/// </summary>
/// <param name="Bgm">Background music path.</param>
/// <param name="FieldType">Field-type discriminator that controls which game logic class handles this map (see <see cref="MapFieldType"/> enum).</param>
/// <param name="ViewBounds">Camera clamp rectangle in world-space pixels; <see langword="null"/> = unclamped.</param>
/// <param name="TimeLimit">Time limit in seconds for timed instances.</param>
/// <param name="Recovery">HP/MP recovery rate multiplier for town maps.</param>
/// <param name="ReduceHPAmount">Flat HP removed per tick on hazard maps (e.g. lava, poison).</param>
/// <param name="ConsumeItemCoolTime">Global cooldown applied between consumable item uses on this map.</param>
/// <param name="WeatherItemId">Item that triggers a persistent weather visual effect on map entry.</param>
/// <param name="ProtectItem">Item that shields the player from the map's hazard damage (pairs with <see cref="ReduceHPAmount"/>).</param>
/// <param name="HasBoat">Whether a boat object is visible and interactive on the map.</param>
/// <param name="BoatType">Boat behavior sub-type; interpretation is map-type specific.</param>
/// <param name="Everlast">Whether the map never automatically resets its state (persistent instanced maps).</param>
/// <param name="LinkedMapId">Another map whose data is merged into this one before load (shared section inheritance); <see langword="null"/> = standalone.</param>
/// <param name="Combat">Combat-specific overrides such as mob rate and carnival settings.</param>
/// <param name="UserEnterScript">NPC-script name executed each time any player enters the map instance.</param>
/// <param name="FirstUserEnterScript">NPC-script name executed only when the very first player enters the map (once per instance lifetime).</param>
/// <param name="Description">Narrative description text displayed in the map info panel.</param>
/// <param name="MapSpecificEffect">Map-specific visual overlay effect path played for all players in the map.</param>
/// <param name="Version">Map data version tag; used by the server to detect stale cached map entries.</param>
/// <param name="MapMark">Marker sprite identifier used in the world-map UI; empty = no mark.</param>
/// <param name="PhaseIndex">Phase index for phase-aware map visuals (multi-stage boss or event maps).</param>
/// <param name="PhaseOverlayAlpha">Alpha of the phase overlay sprite blended over the map at the given <see cref="PhaseIndex"/> (0–255).</param>
public sealed record MapEnvironmentData(
    string? Bgm = null,
    MapFieldType FieldType = default,
    MapRect? ViewBounds = null,
    int TimeLimit = 0,
    int Recovery = 0,
    int ReduceHPAmount = 0,
    int ConsumeItemCoolTime = 0,
    ItemTemplateId WeatherItemId = default,
    ItemTemplateId ProtectItem = default,
    bool HasBoat = false,
    MapBoatType BoatType = MapBoatType.None,
    bool Everlast = false,
    FieldTemplateId? LinkedMapId = null,
    MapCombatInfo? Combat = null,
    string? UserEnterScript = null,
    string? FirstUserEnterScript = null,
    string? Description = null,
    string? MapSpecificEffect = null,
    int? Version = null,
    string? MapMark = null,
    int PhaseIndex = 0,
    byte PhaseOverlayAlpha = 255
);
