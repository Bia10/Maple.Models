namespace Maple.Models.Users;

/// <summary>
/// Contract for character quick-slot bindings keyed by slot index.
/// Implemented by <see cref="CharacterQuickslotKeys"/>.
/// </summary>
public interface ICharacterQuickslotKeys
{
    /// <summary>Returns the skill or item template ID bound at <paramref name="key"/>, or <see langword="null"/> if empty.</summary>
    int? this[int key] { get; }

    /// <summary>All bindings keyed by slot index (0-based); value is a skill or item template ID.</summary>
    IReadOnlyDictionary<int, int> Records { get; }
}
