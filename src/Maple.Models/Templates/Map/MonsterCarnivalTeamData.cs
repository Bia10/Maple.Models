namespace Maple.Models.Templates.Map;

/// <summary>
/// Team-specific purchase lists for a Monster Carnival field.
/// </summary>
/// <param name="Skills">Skill entries available to the team.</param>
/// <param name="MobSummons">Mob summon entries available to the team.</param>
public sealed record MonsterCarnivalTeamData(
    IReadOnlyList<MonsterCarnivalShopEntry> Skills,
    IReadOnlyList<MonsterCarnivalShopEntry> MobSummons
);
