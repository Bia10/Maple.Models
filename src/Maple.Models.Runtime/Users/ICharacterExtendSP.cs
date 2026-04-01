namespace Maple.Models.Users;

/// <summary>
/// Contract for per-job-level SP pools used by multi-advancement jobs.
/// Implemented by <see cref="CharacterExtendSP"/>.
/// </summary>
public interface ICharacterExtendSP
{
    /// <summary>Returns the available SP for the given job advancement level, or <see langword="null"/> if absent.</summary>
    byte? this[byte jobLevel] { get; }

    /// <summary>Available SP keyed by job advancement level (<c>SPSet::nJobLevel → nSP</c>).</summary>
    IReadOnlyDictionary<byte, byte> Records { get; }
}
