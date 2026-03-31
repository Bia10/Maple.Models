namespace Maple.Models.Templates.Map;

/// <summary>
/// Purchasable Monster Carnival entry.
/// </summary>
/// <param name="EntryId">Runtime entry identifier when the source data exposes one.</param>
/// <param name="Name">Display name shown in the Monster Carnival UI.</param>
/// <param name="Description">Client-facing description shown in the Monster Carnival UI.</param>
/// <param name="CpCost">Carnival point cost required to purchase or summon the entry.</param>
public readonly record struct MonsterCarnivalShopEntry(int? EntryId, string Name, string Description, int CpCost);
