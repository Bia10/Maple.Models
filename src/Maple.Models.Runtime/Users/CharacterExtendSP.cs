namespace Maple.Models.Users;

/// <summary>
/// Per-job-level SP pools for multi-advancement jobs.
/// Maps to <c>ExtendSP</c> (PDB), a list of <c>SPSet</c> entries (<c>SPSet::nJobLevel</c>, <c>SPSet::nSP</c>).
/// Used from 4th job onward where each advancement tier maintains its own SP pool.
/// Single-advancement characters use <c>GW_CharacterStat::nSP</c> directly instead.
/// </summary>
public sealed class CharacterExtendSP : ICharacterExtendSP
{
    /// <summary>
    /// Available SP keyed by job advancement level (<c>SPSet::nJobLevel</c> → <c>SPSet::nSP</c>).
    /// Key is the job level (1, 2, 3…); value is the remaining SP in that tier's pool.
    /// </summary>
    public IReadOnlyDictionary<byte, byte> Records { get; init; } = new Dictionary<byte, byte>();

    /// <inheritdoc/>
    IReadOnlyDictionary<byte, byte> ICharacterExtendSP.Records => Records;

    /// <inheritdoc/>
    public byte? this[byte jobLevel] => Records.TryGetValue(jobLevel, out var sp) ? sp : null;
}
