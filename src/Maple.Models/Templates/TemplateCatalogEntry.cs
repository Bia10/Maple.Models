namespace Maple.Models.Templates;

/// <summary>
/// Base type for human-readable catalog rows exposed by template loaders.
/// Invariants: <see cref="Id"/> must be &gt;= 0; <see cref="Name"/> must not be null or empty.
/// </summary>
/// <remarks>
/// Intentionally not sealed — all first-party subtypes in this package are <c>sealed record</c> types
/// that extend this base through positional or property constructors.
/// Third-party subtypes must honour the same Id/Name invariants by delegating to this base constructor.
/// </remarks>
/// <param name="Id">Numeric catalog identifier supplied by the owning loader.</param>
/// <param name="Name">Human-readable label associated with the catalog row.</param>
/// <param name="Description">Optional secondary descriptive text carried by the catalog row.</param>
/// <param name="Category">Optional grouping label used by picker UIs and search results.</param>
public record TemplateCatalogEntry(int Id, string Name, string? Description = null, string? Category = null)
{
    /// <summary>Gets the numeric identifier used for this catalog entry.</summary>
    /// <remarks>Validated at construction: must be &gt;= 0 (non-negative). Negative IDs have no meaning in this catalog; 0 is valid for entries such as gender (0 = Male, 1 = Female).</remarks>
    public int Id { get; init; } =
        Id >= 0 ? Id : throw new ArgumentOutOfRangeException(nameof(Id), Id, "Catalog entry Id must be non-negative.");

    /// <summary>Gets the display name associated with this catalog entry.</summary>
    /// <remarks>Validated at construction: must not be null or empty.</remarks>
    public string Name { get; init; } =
        !string.IsNullOrEmpty(Name)
            ? Name
            : throw new ArgumentException("Catalog entry Name cannot be null or empty.", nameof(Name));
}
