using System.Text.Json.Serialization;
using Maple.StrongId;

namespace Maple.Models.Users;

/// <summary>
/// Shared login identity record containing the username and stored password hash.
/// </summary>
public sealed record IdentityInfo
{
    /// <summary>Database identifier for the identity row.</summary>
    public AccountId Id { get; init; }

    /// <summary>Login name associated with the identity.</summary>
    public string Username { get; init; } = string.Empty;

    /// <summary>Stored BCrypt password hash. Plaintext should never be persisted here.</summary>
    [JsonIgnore]
    public string Password { get; init; } = string.Empty;
}
