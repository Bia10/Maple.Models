using System.Text.Json.Serialization;
using Maple.Enums;
using Maple.Models.Users.Stats;

namespace Maple.Models.Serialization.Users;

[JsonSerializable(typeof(CharacterTemporaryStats))]
[JsonSerializable(typeof(Dictionary<TemporaryStatType, TemporaryStatRecord>))]
[JsonSerializable(typeof(TemporaryStatRecord))]
[JsonSerializable(typeof(TemporaryStatDiceInfo))]
[JsonSerializable(typeof(TemporaryStatTimedRecord))]
[JsonSerializable(typeof(TemporaryStatRideVehicleRecord))]
[JsonSerializable(typeof(TemporaryStatPartyBoosterRecord))]
[JsonSerializable(typeof(TemporaryStatGuidedBulletRecord))]
[JsonSourceGenerationOptions(WriteIndented = true, UseStringEnumConverter = true)]
internal sealed partial class TemporaryStatsJsonContext : JsonSerializerContext;
