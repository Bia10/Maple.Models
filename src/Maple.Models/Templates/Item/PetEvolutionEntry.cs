using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>A single pet evolution target and its duration requirement.</summary>
/// <param name="ItemId">Template ID of the evolved pet item.</param>
/// <param name="PeriodMs">Required active time, in milliseconds, before the evolution unlocks.</param>
public readonly record struct PetEvolutionEntry(ItemTemplateId ItemId, int PeriodMs);
