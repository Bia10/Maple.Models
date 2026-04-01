using System.Text.Json.Serialization;
using Maple.Models.Users;

namespace Maple.Models.Serialization.Users;

[JsonSourceGenerationOptions(WriteIndented = true, UseStringEnumConverter = true)]
[JsonSerializable(typeof(CharacterSkills))]
[JsonSerializable(typeof(CharacterSkillRecord))]
[JsonSerializable(typeof(CharacterFuncKeys))]
[JsonSerializable(typeof(CharacterFuncKeyRecord))]
[JsonSerializable(typeof(CharacterQuickslotKeys))]
[JsonSerializable(typeof(CharacterQuestCompletes))]
[JsonSerializable(typeof(QuestCompleteRecord))]
[JsonSerializable(typeof(CharacterQuestRecords))]
[JsonSerializable(typeof(QuestRecord))]
[JsonSerializable(typeof(CharacterQuestRecordsEx))]
[JsonSerializable(typeof(QuestRecordEx))]
[JsonSerializable(typeof(CharacterWishlist))]
[JsonSerializable(typeof(CharacterWildHunterInfo))]
[JsonSerializable(typeof(CharacterExtendSP))]
internal sealed partial class CharacterRuntimeJsonContext : JsonSerializerContext;
