using System.Text.Json;
using Maple.Models.Items.Storage;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Serializes shared account locker data.
/// </summary>
public static class ItemLockerJsonSerializer
{
    /// <summary>Deserializes a locker JSON payload.</summary>
    public static ItemLocker? Deserialize(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
            return null;

        return JsonSerializer.Deserialize(json, LockerJsonContext.Default.ItemLocker);
    }

    /// <summary>Serializes a locker payload.</summary>
    public static string Serialize(ItemLocker locker) =>
        JsonSerializer.Serialize(locker, LockerJsonContext.Default.ItemLocker);
}
