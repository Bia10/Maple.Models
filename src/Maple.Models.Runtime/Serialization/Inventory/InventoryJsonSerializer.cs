using System.Text.Json;
using Maple.Models.Users;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Serializes typed character inventory aggregates to the persisted JSON format used across solutions.
/// </summary>
public static class InventoryJsonSerializer
{
    /// <summary>Deserializes a JSON string into a <see cref="CharacterInventories"/> graph.</summary>
    public static CharacterInventories? Deserialize(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;

        return JsonSerializer.Deserialize(json, InventoryJsonContext.Default.CharacterInventories);
    }

    /// <summary>Serializes a <see cref="CharacterInventories"/> graph to indented JSON.</summary>
    public static string Serialize(CharacterInventories data) =>
        JsonSerializer.Serialize(data, InventoryJsonContext.Default.CharacterInventories);
}
