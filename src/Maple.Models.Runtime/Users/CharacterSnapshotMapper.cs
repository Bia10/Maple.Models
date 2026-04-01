using System.Text.Json;
using Maple.Models.Serialization.Inventory;
using Maple.Models.Serialization.Users;

namespace Maple.Models.Users;

/// <summary>
/// Converts between the typed runtime <see cref="Character"/> aggregate and the persisted <see cref="CharacterInfo"/> snapshot.
/// </summary>
public static class CharacterSnapshotMapper
{
    /// <summary>Creates a persisted snapshot from a typed runtime character aggregate.</summary>
    public static CharacterInfo ToSnapshot(Character source) =>
        new()
        {
            Id = source.Id,
            AccountWorldDataId = source.AccountWorldDataId,
            Name = source.Name,
            Gender = source.Gender,
            Skin = source.Skin,
            Face = source.Face,
            Hair = source.Hair,
            Level = source.Level,
            Job = source.Job,
            STR = source.STR,
            DEX = source.DEX,
            INT = source.INT,
            LUK = source.LUK,
            HP = source.HP,
            MaxHP = source.MaxHP,
            MP = source.MP,
            MaxMP = source.MaxMP,
            AP = source.AP,
            SP = source.SP,
            EXP = source.EXP,
            POP = source.POP,
            Money = source.Money,
            TempEXP = source.TempEXP,
            FieldId = source.FieldId,
            FieldPortal = source.FieldPortal,
            PlayTime = source.PlayTime,
            SubJob = source.SubJob,
            Inventories = InventoryJsonSerializer.Serialize(source.Inventories),
            TemporaryStats = CharacterTemporaryStatsJsonSerializer.Serialize(source.TemporaryStats),
            Skills = CharacterRuntimeJsonSerializer.Serialize(source.Skills),
            FuncKeys = CharacterRuntimeJsonSerializer.Serialize(source.FuncKeys),
            QuickslotKeys = CharacterRuntimeJsonSerializer.Serialize(source.QuickslotKeys),
            QuestCompletes = CharacterRuntimeJsonSerializer.Serialize(source.QuestCompletes),
            QuestRecords = CharacterRuntimeJsonSerializer.Serialize(source.QuestRecords),
            QuestRecordsEx = CharacterRuntimeJsonSerializer.Serialize(source.QuestRecordsEx),
            Wishlist = CharacterRuntimeJsonSerializer.Serialize(source.Wishlist),
            WildHunterInfo = CharacterRuntimeJsonSerializer.Serialize(source.WildHunterInfo),
            ExtendSP = CharacterRuntimeJsonSerializer.Serialize(source.ExtendSP),
            FriendMax = source.FriendMax,
        };

    /// <summary>
    /// Rehydrates a typed runtime character aggregate from a persisted snapshot.
    /// Throws when persisted scalar ranges or nested JSON payloads are invalid.
    /// </summary>
    public static Character ToRuntime(CharacterInfo source) =>
        new()
        {
            Id = source.Id,
            AccountWorldDataId = source.AccountWorldDataId,
            Name = source.Name,
            Gender = source.Gender,
            Skin = source.Skin,
            Face = source.Face,
            Hair = source.Hair,
            Level = source.Level,
            Job = source.Job,
            STR = source.STR,
            DEX = source.DEX,
            INT = source.INT,
            LUK = source.LUK,
            HP = source.HP,
            MaxHP = source.MaxHP,
            MP = source.MP,
            MaxMP = source.MaxMP,
            AP = source.AP,
            SP = source.SP,
            EXP = source.EXP,
            POP = source.POP,
            Money = source.Money,
            TempEXP = source.TempEXP,
            FieldId = source.FieldId,
            FieldPortal = source.FieldPortal is >= 0 and <= byte.MaxValue
                ? (byte)source.FieldPortal
                : throw new InvalidDataException(
                    $"Character snapshot field portal '{source.FieldPortal}' is out of range (0–255)."
                ),
            PlayTime = source.PlayTime,
            SubJob = source.SubJob,
            Inventories = DeserializeRequired(
                source.Inventories,
                InventoryJsonSerializer.Deserialize,
                nameof(CharacterInfo.Inventories)
            ),
            TemporaryStats = DeserializeRequired(
                source.TemporaryStats,
                CharacterTemporaryStatsJsonSerializer.Deserialize,
                nameof(CharacterInfo.TemporaryStats)
            ),
            Skills = DeserializeRequired(
                source.Skills,
                CharacterRuntimeJsonSerializer.DeserializeCharacterSkills,
                nameof(CharacterInfo.Skills)
            ),
            FuncKeys = DeserializeRequired(
                source.FuncKeys,
                CharacterRuntimeJsonSerializer.DeserializeCharacterFuncKeys,
                nameof(CharacterInfo.FuncKeys)
            ),
            QuickslotKeys = DeserializeRequired(
                source.QuickslotKeys,
                CharacterRuntimeJsonSerializer.DeserializeCharacterQuickslotKeys,
                nameof(CharacterInfo.QuickslotKeys)
            ),
            QuestCompletes = DeserializeRequired(
                source.QuestCompletes,
                CharacterRuntimeJsonSerializer.DeserializeCharacterQuestCompletes,
                nameof(CharacterInfo.QuestCompletes)
            ),
            QuestRecords = DeserializeRequired(
                source.QuestRecords,
                CharacterRuntimeJsonSerializer.DeserializeCharacterQuestRecords,
                nameof(CharacterInfo.QuestRecords)
            ),
            QuestRecordsEx = DeserializeRequired(
                source.QuestRecordsEx,
                CharacterRuntimeJsonSerializer.DeserializeCharacterQuestRecordsEx,
                nameof(CharacterInfo.QuestRecordsEx)
            ),
            Wishlist = DeserializeRequired(
                source.Wishlist,
                CharacterRuntimeJsonSerializer.DeserializeCharacterWishlist,
                nameof(CharacterInfo.Wishlist)
            ),
            WildHunterInfo = DeserializeRequired(
                source.WildHunterInfo,
                CharacterRuntimeJsonSerializer.DeserializeCharacterWildHunterInfo,
                nameof(CharacterInfo.WildHunterInfo)
            ),
            ExtendSP = DeserializeRequired(
                source.ExtendSP,
                CharacterRuntimeJsonSerializer.DeserializeCharacterExtendSP,
                nameof(CharacterInfo.ExtendSP)
            ),
            FriendMax = source.FriendMax,
        };

    private static T DeserializeRequired<T>(string? json, Func<string?, T?> deserialize, string propertyName)
        where T : class
    {
        try
        {
            return deserialize(json)
                ?? throw new InvalidDataException(
                    $"Character snapshot payload '{propertyName}' is missing or malformed."
                );
        }
        catch (JsonException ex)
        {
            throw new InvalidDataException($"Character snapshot payload '{propertyName}' is missing or malformed.", ex);
        }
    }
}
