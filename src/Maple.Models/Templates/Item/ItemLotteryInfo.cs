namespace Maple.Models.Templates.Item;

/// <summary>Lottery/gacha prize table for a lottery item.</summary>
/// <param name="Rewards">Reward entries available from the lottery item.</param>
/// <param name="TotalProb">Total probability value.</param>
public sealed record ItemLotteryInfo(IReadOnlyList<ItemLotteryEntry> Rewards, int TotalProb);
