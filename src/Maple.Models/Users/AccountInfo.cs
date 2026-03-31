using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Users;

/// <summary>
/// Shared account record used by runtime services, persistence, and admin tooling.
/// </summary>
public sealed record AccountInfo
{
    /// <summary>Database identifier for the account.</summary>
    public AccountId Id { get; init; }

    /// <summary>Login name associated with the account.</summary>
    public string Username { get; init; } = string.Empty;

    /// <summary>BCrypt-hashed PIC value.</summary>
    public string? PIN { get; init; }

    /// <summary>BCrypt-hashed secondary password value.</summary>
    public string? SPW { get; init; }

    /// <summary>Primary privilege flags assigned to the account.</summary>
    public AccountGradeCode GradeCode { get; init; }

    /// <summary>Secondary privilege flags assigned to the account.</summary>
    public PrivateStatusFlag SubGradeCode { get; init; }

    /// <summary>Optional gender value stored for the account. <see langword="null"/> means not yet set; <see cref="Maple.Enums.Gender.None"/> means no restriction.</summary>
    public Gender? Gender { get; init; }

    /// <summary>Current NX cash balance.</summary>
    public int NexonCash { get; init; }

    /// <summary>Current Maple Point balance.</summary>
    public int MaplePoint { get; init; }

    /// <summary>Current prepaid NX balance.</summary>
    public int PrepaidNXCash { get; init; }
}
