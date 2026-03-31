namespace Maple.Models.Templates.Map;

/// <summary>
/// Optional event sub-sections embedded in a map.
/// All fields are <see langword="null"/> when the corresponding event section is absent.
/// </summary>
/// <param name="Ship">Ferry or ship event widget data.</param>
/// <param name="Clock">Countdown clock widget data.</param>
/// <param name="Healer">Healer beam object data.</param>
/// <param name="Pulley">Pulley/lift ride object data.</param>
/// <param name="MonsterCarnival">Monster Carnival phase and reward configuration.</param>
public sealed record MapEventData(
    MapShipData? Ship = null,
    MapClockData? Clock = null,
    MapHealerData? Healer = null,
    MapPulleyData? Pulley = null,
    MonsterCarnivalData? MonsterCarnival = null
);
