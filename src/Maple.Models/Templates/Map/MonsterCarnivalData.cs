namespace Maple.Models.Templates.Map;

/// <summary>
/// Monster Carnival field configuration.
/// </summary>
/// <param name="TimeLimit">Match duration in seconds.</param>
/// <param name="MaxGuardianCount">Maximum simultaneous guardian count.</param>
/// <param name="UsesUpgradedPointSystem">Whether the upgraded carnival point system is active.</param>
/// <param name="CarnivalPointThresholds">CP threshold values for the point-tier tiers; <see langword="null"/> when absent.</param>
/// <param name="GuardianSpawnPositions">Guardian spawn positions; <see langword="null"/> when absent.</param>
/// <param name="Guardians">Guardian shop entries; <see langword="null"/> when absent.</param>
/// <param name="Team0">Purchase lists for team 0.</param>
/// <param name="Team1">Purchase lists for team 1.</param>
public sealed record MonsterCarnivalData(
    int TimeLimit,
    int MaxGuardianCount,
    bool UsesUpgradedPointSystem,
    IReadOnlyList<int>? CarnivalPointThresholds = null,
    IReadOnlyList<MapPoint>? GuardianSpawnPositions = null,
    IReadOnlyList<MonsterCarnivalShopEntry>? Guardians = null,
    MonsterCarnivalTeamData? Team0 = null,
    MonsterCarnivalTeamData? Team1 = null
);
