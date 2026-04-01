namespace Maple.Models.Users;

/// <summary>
/// Contract for character function-key bindings keyed by keyboard slot index.
/// Implemented by <see cref="CharacterFuncKeys"/>.
/// </summary>
public interface ICharacterFuncKeys
{
    /// <summary>Returns the binding at <paramref name="key"/>, or <see langword="null"/> if unbound.</summary>
    ICharacterFuncKeyRecord? this[int key] { get; }

    /// <summary>All function-key bindings keyed by keyboard slot index.</summary>
    IReadOnlyDictionary<int, ICharacterFuncKeyRecord> Records { get; }
}
