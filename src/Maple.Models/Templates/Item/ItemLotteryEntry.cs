using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>Single prize entry in a lottery item's reward table.</summary>
/// <param name="ItemId">Item template identifier for this prize.</param>
/// <param name="Prob">Probability weight relative to <c>TotalProb</c>.</param>
/// <param name="Quantity">Count of the item granted when selected.</param>
/// <param name="Period">Expiry duration of the reward in days.</param>
/// <param name="Effect">Visual effect name shown on win.</param>
/// <param name="WorldMsg">Server-wide announcement broadcast on win.</param>
public readonly record struct ItemLotteryEntry(
    ItemTemplateId ItemId,
    int Prob,
    int Quantity = 1,
    int Period = 0,
    string? Effect = null,
    string? WorldMsg = null
);
