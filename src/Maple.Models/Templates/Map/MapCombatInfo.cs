namespace Maple.Models.Templates.Map;

/// <summary>Mob-spawn and party-access settings for the map.</summary>
/// <param name="MobRate">Mob spawn-rate multiplier.</param>
/// <param name="FixedMobCapacity">Hard cap on simultaneous mob count.</param>
/// <param name="PartyOnly">Whether entry requires a party.</param>
public readonly record struct MapCombatInfo(float MobRate = 1.0f, int FixedMobCapacity = 0, bool PartyOnly = false);
