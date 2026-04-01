namespace Maple.Models.Users;

/// <summary>
/// Default JSON literal values used by persisted snapshot records.
/// </summary>
internal static class JsonDefaults
{
    /// <summary>Default empty JSON object literal.</summary>
    public const string EmptyObject = "{}";

    /// <summary>Default empty JSON array literal.</summary>
    public const string EmptyArray = "[]";

    /// <summary>Default empty inventory payload with the standard 24-slot tabs materialized.</summary>
    public const string EmptyCharacterInventories =
        "{\"Equip\":{\"SlotMax\":24,\"Items\":{}},\"Consume\":{\"SlotMax\":24,\"Items\":{}},\"Install\":{\"SlotMax\":24,\"Items\":{}},\"Etc\":{\"SlotMax\":24,\"Items\":{}},\"Cash\":{\"SlotMax\":24,\"Items\":{}}}";

    /// <summary>Default empty locker payload with the documented 24-slot capacity.</summary>
    public const string EmptyItemLocker = "{\"SlotMax\":24,\"Items\":[]}";

    /// <summary>Default empty trunk payload with the documented 4-slot capacity.</summary>
    public static readonly string EmptyItemTrunk =
        "{\"Money\":0,\"SlotMax\":" + AccountWorld.DefaultTrunkSlotMax + ",\"Items\":[]}";
}
