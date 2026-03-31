using System.Collections.Frozen;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Per-level stat data for a skill template.
/// </summary>
/// <remarks>
/// Implemented as a <c>sealed class</c> rather than a <c>sealed record</c> because it holds a mutable lazy cache
/// (<see cref="_statLookupCache"/>). A record's synthesized copy-constructor would copy a stale cache reference
/// when <see cref="Stats"/> changes via a <c>with</c> expression, producing incorrect lookups.
/// </remarks>
public sealed class SkillTemplateLevel(int Level, IReadOnlyList<SkillTemplateStat> Stats)
{
    /// <summary>1-based level index this stat block describes.</summary>
    public int Level { get; } = Level;

    /// <summary>Stat entries for this level; each entry maps a stat name to its resolved integer value.</summary>
    public IReadOnlyList<SkillTemplateStat> Stats { get; } = Stats;

    private FrozenDictionary<string, int>? _statLookupCache;

    /// <summary>
    /// Returns a flat stat dictionary keyed by stat name.
    /// The result is cached on first call; subsequent calls return the same instance.
    /// Uses <see cref="FrozenDictionary{TKey,TValue}"/> for optimal read-only lookup performance.
    /// Thread-safe: uses <see cref="LazyInitializer.EnsureInitialized{T}(ref T, Func{T})"/>
    /// to guarantee at most one stored result is returned to all callers.
    /// The factory may execute more than once under a race, but only the first non-null result is kept.
    /// </summary>
    public IReadOnlyDictionary<string, int> BuildStatLookup() =>
        LazyInitializer.EnsureInitialized(ref _statLookupCache, BuildStatLookupCore);

    private FrozenDictionary<string, int> BuildStatLookupCore() =>
        Stats.ToFrozenDictionary(static s => s.Name, static s => s.Value, StringComparer.Ordinal);

    /// <inheritdoc />
    public override bool Equals(object? obj) =>
        obj is SkillTemplateLevel other && Level == other.Level && Stats.SequenceEqual(other.Stats);

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(Level);
        foreach (var stat in Stats)
            hash.Add(stat);
        return hash.ToHashCode();
    }
}
