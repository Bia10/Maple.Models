using System.Text.Json;
using Maple.Models.Items.Storage;
using Maple.Models.Serialization.Inventory;

namespace Maple.Models.Users;

/// <summary>
/// Converts between the typed runtime <see cref="AccountWorld"/> aggregate and the persisted <see cref="AccountWorldInfo"/> snapshot.
/// </summary>
public static class AccountWorldSnapshotMapper
{
    /// <summary>Creates a persisted snapshot from a typed runtime account-world aggregate.</summary>
    public static AccountWorldInfo ToSnapshot(AccountWorld source) =>
        new()
        {
            Id = source.Id,
            AccountId = source.AccountId,
            WorldId = source.WorldId,
            Locker = ItemLockerJsonSerializer.Serialize(source.Locker),
            Trunk = ItemTrunkJsonSerializer.Serialize(source.Trunk),
            CharacterSlotMax = source.CharacterSlotMax,
        };

    /// <summary>
    /// Rehydrates a typed runtime account-world aggregate from a persisted snapshot.
    /// Throws when persisted storage payloads are invalid.
    /// </summary>
    public static AccountWorld ToRuntime(AccountWorldInfo source) =>
        new()
        {
            Id = source.Id,
            AccountId = source.AccountId,
            WorldId = source.WorldId,
            Locker = DeserializeRequired(
                source.Locker,
                ItemLockerJsonSerializer.Deserialize,
                nameof(AccountWorldInfo.Locker),
                () => new ItemLocker { SlotMax = AccountWorld.DefaultLockerSlotMax }
            ),
            Trunk = DeserializeRequired(
                source.Trunk,
                ItemTrunkJsonSerializer.Deserialize,
                nameof(AccountWorldInfo.Trunk),
                () => new ItemTrunk { SlotMax = AccountWorld.DefaultTrunkSlotMax }
            ),
            CharacterSlotMax = source.CharacterSlotMax,
        };

    private static T DeserializeRequired<T>(
        string? json,
        Func<string?, T?> deserialize,
        string propertyName,
        Func<T> defaultFactory
    )
        where T : class
    {
        try
        {
            T? value = deserialize(json);
            if (value is not null)
                return value;

            if (string.IsNullOrWhiteSpace(json))
                return defaultFactory();

            throw new InvalidDataException($"Account-world snapshot payload '{propertyName}' is malformed.");
        }
        catch (JsonException ex)
        {
            throw new InvalidDataException($"Account-world snapshot payload '{propertyName}' is malformed.", ex);
        }
    }
}
