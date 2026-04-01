namespace Maple.Models.Users;

/// <summary>
/// Character quick-slot bindings keyed by slot index.
/// No <c>GW_</c> struct is present in the V95 PDB; quickslot state is runtime-only
/// (<c>CUIStatusBar::CQuickSlot</c>) and not part of the persisted <c>CharacterData</c> layout.
/// This is a server-side persistence construct introduced by Edelstein.
/// See <c>docs/runtime-character-models.md</c> for details.
/// </summary>
public sealed class CharacterQuickslotKeys : ICharacterQuickslotKeys
{
    /// <summary>
    /// Bindings keyed by quickslot panel index (0-based);
    /// value is the skill or item template ID bound to that slot (0 = empty).
    /// </summary>
    public IReadOnlyDictionary<int, int> Records { get; init; } = new Dictionary<int, int>();

    /// <inheritdoc/>
    IReadOnlyDictionary<int, int> ICharacterQuickslotKeys.Records => Records;

    /// <inheritdoc/>
    int? ICharacterQuickslotKeys.this[int key] => Records.TryGetValue(key, out var v) ? v : null;
}
