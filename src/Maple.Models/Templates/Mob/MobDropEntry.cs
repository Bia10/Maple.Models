using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// A drop entry for a mob reward.
/// </summary>
/// <param name="ItemId">Item template identifier.</param>
/// <param name="Min">Minimum drop quantity.</param>
/// <param name="Max">Maximum drop quantity.</param>
/// <param name="Prop">Drop probability value.</param>
public readonly record struct MobDropEntry(ItemTemplateId ItemId, int Min, int Max, int Prop);
