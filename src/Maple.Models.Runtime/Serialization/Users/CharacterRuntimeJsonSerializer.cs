using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Maple.Models.Users;

namespace Maple.Models.Serialization.Users;

/// <summary>
/// Serializes shared character runtime subgraphs to and from their persisted JSON payloads.
/// </summary>
public static class CharacterRuntimeJsonSerializer
{
    /// <summary>Serializes a <see cref="CharacterSkills"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterSkills data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterSkills);

    /// <summary>Serializes a <see cref="CharacterFuncKeys"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterFuncKeys data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterFuncKeys);

    /// <summary>Serializes a <see cref="CharacterQuickslotKeys"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterQuickslotKeys data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterQuickslotKeys);

    /// <summary>Serializes a <see cref="CharacterQuestCompletes"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterQuestCompletes data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterQuestCompletes);

    /// <summary>Serializes a <see cref="CharacterQuestRecords"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterQuestRecords data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterQuestRecords);

    /// <summary>Serializes a <see cref="CharacterQuestRecordsEx"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterQuestRecordsEx data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterQuestRecordsEx);

    /// <summary>Serializes a <see cref="CharacterWishlist"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterWishlist data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterWishlist);

    /// <summary>Serializes a <see cref="CharacterWildHunterInfo"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterWildHunterInfo data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterWildHunterInfo);

    /// <summary>Serializes a <see cref="CharacterExtendSP"/> to its persisted JSON payload.</summary>
    public static string Serialize(CharacterExtendSP data) =>
        Serialize(data, CharacterRuntimeJsonContext.Default.CharacterExtendSP);

    /// <summary>Deserializes a <see cref="CharacterSkills"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterSkills? DeserializeCharacterSkills(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterSkills);

    /// <summary>Deserializes a <see cref="CharacterFuncKeys"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterFuncKeys? DeserializeCharacterFuncKeys(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterFuncKeys);

    /// <summary>Deserializes a <see cref="CharacterQuickslotKeys"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterQuickslotKeys? DeserializeCharacterQuickslotKeys(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterQuickslotKeys);

    /// <summary>Deserializes a <see cref="CharacterQuestCompletes"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterQuestCompletes? DeserializeCharacterQuestCompletes(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterQuestCompletes);

    /// <summary>Deserializes a <see cref="CharacterQuestRecords"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterQuestRecords? DeserializeCharacterQuestRecords(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterQuestRecords);

    /// <summary>Deserializes a <see cref="CharacterQuestRecordsEx"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterQuestRecordsEx? DeserializeCharacterQuestRecordsEx(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterQuestRecordsEx);

    /// <summary>Deserializes a <see cref="CharacterWishlist"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterWishlist? DeserializeCharacterWishlist(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterWishlist);

    /// <summary>Deserializes a <see cref="CharacterWildHunterInfo"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterWildHunterInfo? DeserializeCharacterWildHunterInfo(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterWildHunterInfo);

    /// <summary>Deserializes a <see cref="CharacterExtendSP"/> from its persisted JSON payload, or returns <see langword="null"/> on empty or malformed input.</summary>
    public static CharacterExtendSP? DeserializeCharacterExtendSP(string? json) =>
        Deserialize(json, CharacterRuntimeJsonContext.Default.CharacterExtendSP);

    private static string Serialize<T>(T data, JsonTypeInfo<T> typeInfo) => JsonSerializer.Serialize(data, typeInfo);

    private static T? Deserialize<T>(string? json, JsonTypeInfo<T> typeInfo)
    {
        if (string.IsNullOrWhiteSpace(json))
            return default;

        return JsonSerializer.Deserialize(json, typeInfo);
    }
}
