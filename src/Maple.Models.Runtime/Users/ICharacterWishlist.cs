namespace Maple.Models.Users;

/// <summary>
/// Contract for the character wishlist item template identifiers.
/// Implemented by <see cref="CharacterWishlist"/>.
/// </summary>
public interface ICharacterWishlist
{
    /// <summary>Ordered item template identifiers making up the wish list.</summary>
    IReadOnlyList<int> Records { get; }
}
