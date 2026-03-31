using Maple.StrongId;

namespace Maple.Models.Servers;

/// <summary>
/// Shared migration snapshot record used when transferring a character between servers.
/// </summary>
public sealed record MigrationInfo
{
    /// <summary>Account identifier being migrated.</summary>
    public AccountId AccountId { get; init; }

    /// <summary>Account-world row identifier associated with the migration.</summary>
    public int AccountWorldDataId { get; init; }

    /// <summary>Character identifier being migrated.</summary>
    public CharacterId CharacterId { get; init; }

    /// <summary>Last update timestamp for the migration record.</summary>
    public DateTime DateUpdated { get; init; }

    /// <summary>Expiration timestamp after which the migration snapshot is invalid.</summary>
    public DateTime DateExpire { get; init; }

    /// <summary>Source server identifier.</summary>
    public string FromServerId { get; init; } = string.Empty;

    /// <summary>Destination server identifier.</summary>
    public string ToServerId { get; init; } = string.Empty;

    /// <summary>Serialized account snapshot payload.</summary>
    public string AccountSnapshot { get; init; } = string.Empty;

    /// <summary>Serialized account-world snapshot payload.</summary>
    public string AccountWorldDataSnapshot { get; init; } = string.Empty;

    /// <summary>Serialized character snapshot payload.</summary>
    public string CharacterSnapshot { get; init; } = string.Empty;
}
