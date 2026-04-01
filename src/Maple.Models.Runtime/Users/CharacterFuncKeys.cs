namespace Maple.Models.Users;

/// <summary>
/// Character function-key bindings keyed by keyboard slot index.
/// Maps the <c>GW_FuncKeyMapped</c> (PDB) per-entry layout; dictionary key corresponds to
/// <c>GW_FuncKeyMapped::nKeyID</c> (<c>unsigned __int8</c>, range 0–255).
/// See <c>docs/runtime-character-models.md</c> for the full field mapping.
/// </summary>
public sealed class CharacterFuncKeys : ICharacterFuncKeys
{
    /// <summary>
    /// Binding records keyed by keyboard slot index (<c>GW_FuncKeyMapped::nKeyID</c>).
    /// </summary>
    public IReadOnlyDictionary<int, CharacterFuncKeyRecord> Records { get; init; } =
        new Dictionary<int, CharacterFuncKeyRecord>();

    /// <inheritdoc/>
    IReadOnlyDictionary<int, ICharacterFuncKeyRecord> ICharacterFuncKeys.Records =>
        Records.ToDictionary(static kvp => kvp.Key, static kvp => (ICharacterFuncKeyRecord)kvp.Value);

    /// <inheritdoc/>
    ICharacterFuncKeyRecord? ICharacterFuncKeys.this[int key] => Records.TryGetValue(key, out var r) ? r : null;
}
