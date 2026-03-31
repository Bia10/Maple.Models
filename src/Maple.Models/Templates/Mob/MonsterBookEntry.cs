namespace Maple.Models.Templates.Mob;

/// <summary>
/// Localized Monster Book text for a mob.
/// </summary>
/// <param name="Name">Display name shown in the Monster Book UI.</param>
/// <param name="Description">Short summary text for the entry.</param>
/// <param name="Detail">Long-form descriptive text for the entry.</param>
/// <param name="Catch">Capture-related text or flavor line, when present.</param>
public readonly record struct MonsterBookEntry(string? Name, string? Description, string? Detail, string? Catch = null);
