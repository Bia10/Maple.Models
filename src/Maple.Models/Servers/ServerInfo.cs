namespace Maple.Models.Servers;

/// <summary>
/// Shared server registry record describing a world, channel, or service endpoint.
/// </summary>
public sealed record ServerInfo
{
    /// <summary>Stable identifier for the server row.</summary>
    public string Id { get; init; } = string.Empty;

    /// <summary>Hostname or address clients and services connect to.</summary>
    public string Host { get; init; } = string.Empty;

    /// <summary>Listening port for the server.</summary>
    public int Port { get; init; }

    /// <summary>Server discriminator used to identify the runtime service type.</summary>
    public string Discriminator { get; init; } = string.Empty;

    /// <summary>Expiration timestamp for time-bound registrations.</summary>
    public DateTime DateExpire { get; init; }

    /// <summary>Last update timestamp for the registration.</summary>
    public DateTime DateUpdated { get; init; }

    /// <summary>Shared secret used for inter-service validation.</summary>
    public long Secret { get; init; }

    /// <summary>Optional channel identifier when the row represents a channel server.</summary>
    public int? ChannelId { get; init; }

    /// <summary>Indicates whether the channel is restricted to adult access.</summary>
    public bool? IsAdultChannel { get; init; }

    /// <summary>Optional world identifier associated with the server.</summary>
    public int? WorldId { get; init; }
}
