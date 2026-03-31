using Maple.StrongId;

namespace Maple.Models.Servers;

/// <summary>
/// Shared active-session record linking an account and optional character to a server instance.
/// </summary>
public sealed record SessionInfo
{
    /// <summary>Currently authenticated account identifier.</summary>
    public AccountId ActiveAccount { get; init; }

    /// <summary>Server identifier that owns the session.</summary>
    public string ServerId { get; init; } = string.Empty;

    /// <summary>Currently selected character identifier, if one is active.</summary>
    public CharacterId? ActiveCharacter { get; init; }

    /// <summary>Session secret used to validate reconnect or migration flows.</summary>
    public long Secret { get; init; }
}
