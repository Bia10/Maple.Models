namespace Maple.Models.Users;

/// <summary>
/// Character wishlist item template identifiers.
/// No <c>GW_WishList</c> struct is present in the V95 PDB; wishlist functionality is UI-only
/// (<c>CUIUserInfoWishList</c>) and not part of the persisted <c>CharacterData</c> layout.
/// This is a server-side persistence construct introduced by Edelstein.
/// See <c>docs/runtime-character-models.md</c> for details.
/// </summary>
public sealed class CharacterWishlist : ICharacterWishlist
{
    /// <summary>
    /// Ordered item template identifiers making up the wish list
    /// (used by the in-game gift / trade system).
    /// </summary>
    public IList<int> Records { get; init; } = [];

    IReadOnlyList<int> ICharacterWishlist.Records => [.. Records];
}
