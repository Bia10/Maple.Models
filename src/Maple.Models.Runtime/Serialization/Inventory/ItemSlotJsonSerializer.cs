using System.Text.Json;
using Maple.Models.Items.Slots;

namespace Maple.Models.Serialization.Inventory;

/// <summary>
/// Serializes shared item-slot runtime graphs.
/// </summary>
public static class ItemSlotJsonSerializer
{
    /// <summary>Serializes an item slot using the shared polymorphic slot context.</summary>
    public static string Serialize(IItemSlot slot) =>
        JsonSerializer.Serialize(slot, typeof(IItemSlot), ItemSlotJsonContext.Default);
}
