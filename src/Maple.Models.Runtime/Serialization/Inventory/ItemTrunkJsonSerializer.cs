using System.Text.Json;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Serializes shared account trunk data.
/// </summary>
public static class ItemTrunkJsonSerializer
{
    /// <summary>Deserializes a trunk JSON payload.</summary>
    public static ItemTrunk? Deserialize(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;

        return JsonSerializer.Deserialize(json, TrunkJsonContext.Default.ItemTrunk);
    }

    /// <summary>Serializes a trunk payload.</summary>
    public static string Serialize(ItemTrunk trunk) =>
        JsonSerializer.Serialize(trunk, TrunkJsonContext.Default.ItemTrunk);
}
