namespace Maple.Models.Templates.SetItem;

/// <summary>Bonus stats granted when a minimum number of set pieces are simultaneously equipped.</summary>
/// <param name="PieceCount">Required number of equipped set pieces to unlock this bonus tier.</param>
/// <param name="Stats">Stat bonus entries for this tier.</param>
public sealed record SetItemEffect(int PieceCount, IReadOnlyList<SetItemStatBonus> Stats);
