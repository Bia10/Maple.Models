using System.Text.Json;
using Maple.Models.Users.Stats;

namespace Maple.Models.Serialization.Users;

/// <summary>
/// Serializes typed character temporary-stat graphs.
/// </summary>
public static class CharacterTemporaryStatsJsonSerializer
{
    /// <summary>Serializes a temporary-stat graph.</summary>
    public static string Serialize(CharacterTemporaryStats data) =>
        JsonSerializer.Serialize(data, TemporaryStatsJsonContext.Default.CharacterTemporaryStats);

    /// <summary>Deserializes a temporary-stat graph.</summary>
    public static CharacterTemporaryStats? Deserialize(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;

        return JsonSerializer.Deserialize(json, TemporaryStatsJsonContext.Default.CharacterTemporaryStats);
    }
}
