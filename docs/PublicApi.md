# Maple.Models Public API

```csharp
[assembly: System.Reflection.AssemblyMetadata("IsAotCompatible", "True")]
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/Bia10/Maple.Models/")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Models.Benchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Models.ComparisonBenchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Models.Test")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.Models.XyzTest")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v10.0", FrameworkDisplayName=".NET 10.0")]
namespace Maple.Models.Common
{
    public readonly struct ArgbColor : System.IEquatable<Maple.Models.Common.ArgbColor>
    {
        public ArgbColor(uint Value) { }
        public byte Alpha { get; }
        public byte Blue { get; }
        public byte Green { get; }
        public byte Red { get; }
        public uint Value { get; init; }
        public string ToHexString() { }
        public override string ToString() { }
        public static Maple.Models.Common.ArgbColor FromInt32(int value) { }
    }
}
namespace Maple.Models.Items.Stats
{
    public readonly struct CharacterBaseStats : System.IEquatable<Maple.Models.Items.Stats.CharacterBaseStats>
    {
        public CharacterBaseStats(short STR, short DEX, short INT, short LUK) { }
        public short DEX { get; init; }
        public short INT { get; init; }
        public short LUK { get; init; }
        public short STR { get; init; }
    }
    public readonly struct CombatStats : System.IEquatable<Maple.Models.Items.Stats.CombatStats>
    {
        public CombatStats(short PAD, short MAD, short ACC, short EVA) { }
        public short ACC { get; init; }
        public short EVA { get; init; }
        public short MAD { get; init; }
        public short PAD { get; init; }
    }
    public readonly struct DefenseStats : System.IEquatable<Maple.Models.Items.Stats.DefenseStats>
    {
        public DefenseStats(short PDD, short MDD) { }
        public short MDD { get; init; }
        public short PDD { get; init; }
    }
}
namespace Maple.Models
{
    public static class MapleModels
    {
        public static void Empty() { }
    }
}
namespace Maple.Models.Servers
{
    public sealed class MigrationInfo : System.IEquatable<Maple.Models.Servers.MigrationInfo>
    {
        public MigrationInfo() { }
        public Maple.StrongId.AccountId AccountId { get; init; }
        public string AccountSnapshot { get; init; }
        public int AccountWorldDataId { get; init; }
        public string AccountWorldDataSnapshot { get; init; }
        public Maple.StrongId.CharacterId CharacterId { get; init; }
        public string CharacterSnapshot { get; init; }
        public System.DateTime DateExpire { get; init; }
        public System.DateTime DateUpdated { get; init; }
        public string FromServerId { get; init; }
        public string ToServerId { get; init; }
    }
    public sealed class ServerInfo : System.IEquatable<Maple.Models.Servers.ServerInfo>
    {
        public ServerInfo() { }
        public int? ChannelId { get; init; }
        public System.DateTime DateExpire { get; init; }
        public System.DateTime DateUpdated { get; init; }
        public string Discriminator { get; init; }
        public string Host { get; init; }
        public string Id { get; init; }
        public bool? IsAdultChannel { get; init; }
        public int Port { get; init; }
        public long Secret { get; init; }
        public int? WorldId { get; init; }
    }
    public sealed class SessionInfo : System.IEquatable<Maple.Models.Servers.SessionInfo>
    {
        public SessionInfo() { }
        public Maple.StrongId.AccountId ActiveAccount { get; init; }
        public Maple.StrongId.CharacterId? ActiveCharacter { get; init; }
        public long Secret { get; init; }
        public string ServerId { get; init; }
    }
}
namespace Maple.Models.Templates.Appearance
{
    public static class AvatarSlotDefaults
    {
        public static readonly Maple.StrongId.ItemTemplateId DefaultCap;
        public static readonly Maple.StrongId.ItemTemplateId DefaultCape;
        public static readonly Maple.StrongId.ItemTemplateId DefaultEarring;
        public static readonly Maple.StrongId.ItemTemplateId DefaultEyeAccessory;
        public static readonly Maple.StrongId.ItemTemplateId DefaultFemaleBottom;
        public static readonly Maple.StrongId.ItemTemplateId DefaultFemaleTop;
        public static readonly Maple.StrongId.ItemTemplateId DefaultGloves;
        public static readonly Maple.StrongId.ItemTemplateId DefaultMaleBottom;
        public static readonly Maple.StrongId.ItemTemplateId DefaultMaleTop;
        public static readonly Maple.StrongId.ItemTemplateId DefaultShield;
        public static readonly Maple.StrongId.ItemTemplateId DefaultShoes;
    }
    public static class CharacterAppearanceDefaults
    {
        public static System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Appearance.SkinTemplateEntry> SkinEntries { get; }
        public static bool IsReservedSkinId(int skinId) { }
        public static bool IsSupportedSkinId(int skinId) { }
    }
    public static class CharacterZLayer
    {
        public const int FaceSplitIndex = 21;
        public static readonly System.Collections.Generic.IReadOnlyList<string> Layers;
    }
    public sealed class HairFaceTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Appearance.HairFaceTemplateEntry>
    {
        public HairFaceTemplateEntry(int Id, string Name) { }
        public Maple.StrongId.ItemTemplateId ItemId { get; }
    }
    public sealed class MakeCharInfoGenderEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Appearance.MakeCharInfoGenderEntry>
    {
        public MakeCharInfoGenderEntry(int Id, string Name, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Faces = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Hairs = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Skins = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Tops = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Bottoms = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Shoes = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Weapons = null) { }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Bottoms { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Faces { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Hairs { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Shoes { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Skins { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Tops { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? Weapons { get; init; }
    }
    public sealed class SkinTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Appearance.SkinTemplateEntry>
    {
        public SkinTemplateEntry(int Id, string Name) { }
    }
}
namespace Maple.Models.Templates.Etc
{
    public sealed class MorphTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Etc.MorphTemplateEntry>
    {
        public MorphTemplateEntry(int Id, string Name, int Speed, int Jump, float Fs, int Swim, bool MorphEffect, bool SuperMan, bool Hide, bool Attackable, int Movability = 0) { }
        public bool Attackable { get; init; }
        public float Fs { get; init; }
        public bool Hide { get; init; }
        public int Jump { get; init; }
        public bool MorphEffect { get; init; }
        public Maple.StrongId.MorphTemplateId MorphId { get; }
        public int Movability { get; init; }
        public int Speed { get; init; }
        public bool SuperMan { get; init; }
        public int Swim { get; init; }
    }
    public sealed class TitleItemEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Etc.TitleItemEntry>
    {
        public TitleItemEntry(int Id, string Name, System.DateOnly? DateExpire, Maple.StrongId.FieldTemplateId? OnlyUseInField = default) { }
        public System.DateOnly? DateExpire { get; init; }
        public Maple.StrongId.FieldTemplateId? OnlyUseInField { get; init; }
        public Maple.StrongId.ItemTemplateId TitleItemId { get; }
    }
}
namespace Maple.Models.Templates.Item
{
    public readonly struct AdditionBoss : System.IEquatable<Maple.Models.Templates.Item.AdditionBoss>
    {
        public AdditionBoss(Maple.Models.Templates.Item.AdditionCondition? Condition, int Prob, int Damage) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public int Damage { get; init; }
        public int Prob { get; init; }
    }
    public readonly struct AdditionCondition : System.IEquatable<Maple.Models.Templates.Item.AdditionCondition>
    {
        public AdditionCondition(int Level = 0, Maple.StrongId.JobId? Job = default, int Str = 0, int Dex = 0, int Int = 0, int Luk = 0, int Craft = 0, int ItemQuality = -2) { }
        public int Craft { get; init; }
        public int Dex { get; init; }
        public int Int { get; init; }
        public int ItemQuality { get; init; }
        public Maple.StrongId.JobId? Job { get; init; }
        public int Level { get; init; }
        public int Luk { get; init; }
        public int Str { get; init; }
    }
    public readonly struct AdditionCritical : System.IEquatable<Maple.Models.Templates.Item.AdditionCritical>
    {
        public AdditionCritical(Maple.Models.Templates.Item.AdditionCondition? Condition, int Prob, int Damage) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public int Damage { get; init; }
        public int Prob { get; init; }
    }
    public readonly struct AdditionElemBoost : System.IEquatable<Maple.Models.Templates.Item.AdditionElemBoost>
    {
        public AdditionElemBoost(Maple.Models.Templates.Item.AdditionCondition? Condition, Maple.Enums.Element ElemType, int Volume) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public Maple.Enums.Element ElemType { get; init; }
        public int Volume { get; init; }
    }
    public readonly struct AdditionHpMpChange : System.IEquatable<Maple.Models.Templates.Item.AdditionHpMpChange>
    {
        public AdditionHpMpChange(Maple.Models.Templates.Item.AdditionCondition? Condition, int HpChangePerTime, int MpChangePerTime) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public int HpChangePerTime { get; init; }
        public int MpChangePerTime { get; init; }
    }
    public readonly struct AdditionMobCategory : System.IEquatable<Maple.Models.Templates.Item.AdditionMobCategory>
    {
        public AdditionMobCategory(Maple.Models.Templates.Item.AdditionCondition? Condition, Maple.Enums.MobCategory Category, int Damage) { }
        public Maple.Enums.MobCategory Category { get; init; }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public int Damage { get; init; }
    }
    public readonly struct AdditionMobDie : System.IEquatable<Maple.Models.Templates.Item.AdditionMobDie>
    {
        public AdditionMobDie(Maple.Models.Templates.Item.AdditionCondition? Condition, int HpIncOnMobDie = 0, int MpIncOnMobDie = 0, int HpProp = 100, int MpProp = 100, int HpIncRatioOnMobDie = 0, int MpIncRatioOnMobDie = 0, int HpRatioProp = 0, int MpRatioProp = 0) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public int HpIncOnMobDie { get; init; }
        public int HpIncRatioOnMobDie { get; init; }
        public int HpProp { get; init; }
        public int HpRatioProp { get; init; }
        public int MpIncOnMobDie { get; init; }
        public int MpIncRatioOnMobDie { get; init; }
        public int MpProp { get; init; }
        public int MpRatioProp { get; init; }
    }
    public readonly struct AdditionSkill : System.IEquatable<Maple.Models.Templates.Item.AdditionSkill>
    {
        public AdditionSkill(Maple.Models.Templates.Item.AdditionCondition? Condition, Maple.StrongId.SkillTemplateId SkillId, int SkillLevel) { }
        public Maple.Models.Templates.Item.AdditionCondition? Condition { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
        public int SkillLevel { get; init; }
    }
    public readonly struct ItemAdditionData : System.IEquatable<Maple.Models.Templates.Item.ItemAdditionData>
    {
        public ItemAdditionData(Maple.Models.Templates.Item.AdditionSkill? Skill = default, Maple.Models.Templates.Item.AdditionMobCategory? MobCategory = default, Maple.Models.Templates.Item.AdditionElemBoost? ElemBoost = default, Maple.Models.Templates.Item.AdditionCritical? Critical = default, Maple.Models.Templates.Item.AdditionBoss? Boss = default, Maple.Models.Templates.Item.AdditionMobDie? MobDie = default, Maple.Models.Templates.Item.AdditionHpMpChange? HpMpChange = default) { }
        public Maple.Models.Templates.Item.AdditionBoss? Boss { get; init; }
        public Maple.Models.Templates.Item.AdditionCritical? Critical { get; init; }
        public Maple.Models.Templates.Item.AdditionElemBoost? ElemBoost { get; init; }
        public Maple.Models.Templates.Item.AdditionHpMpChange? HpMpChange { get; init; }
        public Maple.Models.Templates.Item.AdditionMobCategory? MobCategory { get; init; }
        public Maple.Models.Templates.Item.AdditionMobDie? MobDie { get; init; }
        public Maple.Models.Templates.Item.AdditionSkill? Skill { get; init; }
    }
    public sealed class ItemBridleInfo : System.IEquatable<Maple.Models.Templates.Item.ItemBridleInfo>
    {
        public ItemBridleInfo(Maple.StrongId.MobTemplateId TargetMobId, Maple.StrongId.ItemTemplateId CreateItemId = default, int CreateItemPeriod = 0, int CatchPercentageHp = 0, float BridleProb = 0, float BridleProbAdj = 0, int UseDelay = 0, string? DelayMsg = null, string? NoMobMsg = null) { }
        public float BridleProb { get; init; }
        public float BridleProbAdj { get; init; }
        public int CatchPercentageHp { get; init; }
        public Maple.StrongId.ItemTemplateId CreateItemId { get; init; }
        public int CreateItemPeriod { get; init; }
        public string? DelayMsg { get; init; }
        public string? NoMobMsg { get; init; }
        public Maple.StrongId.MobTemplateId TargetMobId { get; init; }
        public int UseDelay { get; init; }
    }
    public sealed class ItemBundleEffectData : System.IEquatable<Maple.Models.Templates.Item.ItemBundleEffectData>
    {
        public ItemBundleEffectData(
                    int Pad = 0,
                    bool IsMonsterBookCard = false,
                    Maple.Enums.MonsterCarnivalMapType? McType = default,
                    int Hp = 0,
                    int Mp = 0,
                    int HpR = 0,
                    int MpR = 0,
                    int HpQ = 0,
                    int MpQ = 0,
                    int Time = 0,
                    int Success = 0,
                    int Cursed = 0,
                    int Recover = 0,
                    int PreventSlip = 0,
                    Maple.StrongId.ItemTemplateId? BuffItemId = default,
                    Maple.StrongId.FieldTemplateId? MoveTo = default,
                    int Speed = 0,
                    int Jump = 0,
                    int Pdd = 0) { }
        public Maple.StrongId.ItemTemplateId? BuffItemId { get; init; }
        public int Cursed { get; init; }
        public int Hp { get; init; }
        public int HpQ { get; init; }
        public int HpR { get; init; }
        public bool IsMonsterBookCard { get; init; }
        public int Jump { get; init; }
        public Maple.Enums.MonsterCarnivalMapType? McType { get; init; }
        public Maple.StrongId.FieldTemplateId? MoveTo { get; init; }
        public int Mp { get; init; }
        public int MpQ { get; init; }
        public int MpR { get; init; }
        public int Pad { get; init; }
        public int Pdd { get; init; }
        public int PreventSlip { get; init; }
        public int Recover { get; init; }
        public int Speed { get; init; }
        public int Success { get; init; }
        public int Time { get; init; }
    }
    public sealed class ItemBundleInfo : System.IEquatable<Maple.Models.Templates.Item.ItemBundleInfo>
    {
        public ItemBundleInfo(Maple.Models.Templates.Item.ItemBundleRequirements requirements, Maple.Models.Templates.Item.ItemBundleEffectData effects, Maple.Models.Templates.Item.ItemBundleSpecialData special, Maple.Models.Templates.Item.ItemPetInfo? petData = null) { }
        public int AppliableKarmaType { get; }
        public Maple.Models.Templates.Item.ItemBridleInfo? BridleInfo { get; }
        public Maple.StrongId.ItemTemplateId? BuffItemId { get; }
        public Maple.Models.Templates.Item.ItemConsumeSpec? ConsumeSpec { get; }
        public Maple.StrongId.ItemTemplateId? CoupleId { get; }
        public int Cursed { get; }
        public Maple.Models.Templates.Item.ItemBundleEffectData Effects { get; init; }
        public Maple.StrongId.SkillTemplateId? GrantedSkillId { get; }
        public int Hp { get; }
        public int HpQ { get; }
        public int HpR { get; }
        public int? IncLevel { get; }
        public bool IsAccountSharable { get; }
        public bool IsBigSize { get; }
        public bool IsCash { get; }
        public bool IsExpireOnLogout { get; }
        public bool IsMonsterBookCard { get; }
        public bool IsNotSale { get; }
        public bool IsOnly { get; }
        public bool IsPartyQuest { get; }
        public bool IsQuest { get; }
        public bool IsTimeLimited { get; }
        public bool IsTradeBlock { get; }
        public int Jump { get; }
        public Maple.Models.Templates.Item.ItemLotteryInfo? Lottery { get; }
        public int Max { get; }
        public int MaxPerSlot { get; }
        public Maple.Enums.MonsterCarnivalMapType? McType { get; }
        public Maple.StrongId.FieldTemplateId? MoveTo { get; }
        public int Mp { get; }
        public int MpQ { get; }
        public int MpR { get; }
        public bool NoCancelMouse { get; }
        public int Pad { get; }
        public int Pdd { get; }
        public Maple.Models.Templates.Item.ItemPetInfo? PetData { get; init; }
        public int PreventSlip { get; }
        public string? QuestDeliveryEffect { get; }
        public Maple.Enums.ItemQuestDeliveryType? QuestDeliveryType { get; }
        public int Recover { get; }
        public Maple.StrongId.ItemTemplateId ReplaceItemId { get; }
        public string? ReplaceMsg { get; }
        public int ReplacePeriod { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId>? ReqFields { get; }
        public int ReqLevel { get; }
        public Maple.StrongId.QuestTemplateId? ReqQuestOnProgress { get; }
        public int? ReqSkillLevel { get; }
        public Maple.Models.Templates.Item.ItemBundleRequirements Requirements { get; init; }
        public Maple.StrongId.ItemTemplateId? ScrollId { get; }
        public int SellPrice { get; }
        public Maple.Models.Templates.Item.ItemBundleSpecialData Special { get; init; }
        public int Speed { get; }
        public int Success { get; }
        public int Time { get; }
        public int? WarningState { get; }
    }
    public sealed class ItemBundleRequirements : System.IEquatable<Maple.Models.Templates.Item.ItemBundleRequirements>
    {
        public ItemBundleRequirements(int MaxPerSlot, int SellPrice, bool IsCash, bool IsQuest, bool IsOnly, bool IsTradeBlock, bool IsNotSale, int ReqLevel, int Max = 0, bool IsPartyQuest = false, bool IsAccountSharable = false, System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId>? ReqFields = null, Maple.StrongId.QuestTemplateId? ReqQuestOnProgress = default) { }
        public bool IsAccountSharable { get; init; }
        public bool IsCash { get; init; }
        public bool IsNotSale { get; init; }
        public bool IsOnly { get; init; }
        public bool IsPartyQuest { get; init; }
        public bool IsQuest { get; init; }
        public bool IsTradeBlock { get; init; }
        public int Max { get; init; }
        public int MaxPerSlot { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId>? ReqFields { get; init; }
        public int ReqLevel { get; init; }
        public Maple.StrongId.QuestTemplateId? ReqQuestOnProgress { get; init; }
        public int SellPrice { get; init; }
    }
    public sealed class ItemBundleSpecialData : System.IEquatable<Maple.Models.Templates.Item.ItemBundleSpecialData>
    {
        public ItemBundleSpecialData(
                    Maple.StrongId.ItemTemplateId? ScrollId = default,
                    int? WarningState = default,
                    Maple.StrongId.ItemTemplateId? CoupleId = default,
                    int? IncLevel = default,
                    Maple.Models.Templates.Item.ItemConsumeSpec? ConsumeSpec = null,
                    Maple.Enums.ItemQuestDeliveryType? QuestDeliveryType = default,
                    string? QuestDeliveryEffect = null,
                    Maple.Models.Templates.Item.ItemBridleInfo? BridleInfo = null,
                    Maple.Models.Templates.Item.ItemLotteryInfo? Lottery = null,
                    Maple.StrongId.SkillTemplateId? GrantedSkillId = default,
                    int? ReqSkillLevel = default,
                    int AppliableKarmaType = 0,
                    bool NoCancelMouse = false,
                    bool IsBigSize = false,
                    bool IsExpireOnLogout = false,
                    bool IsTimeLimited = false,
                    Maple.StrongId.ItemTemplateId ReplaceItemId = default,
                    string? ReplaceMsg = null,
                    int ReplacePeriod = 0) { }
        public int AppliableKarmaType { get; init; }
        public Maple.Models.Templates.Item.ItemBridleInfo? BridleInfo { get; init; }
        public Maple.Models.Templates.Item.ItemConsumeSpec? ConsumeSpec { get; init; }
        public Maple.StrongId.ItemTemplateId? CoupleId { get; init; }
        public Maple.StrongId.SkillTemplateId? GrantedSkillId { get; init; }
        public int? IncLevel { get; init; }
        public bool IsBigSize { get; init; }
        public bool IsExpireOnLogout { get; init; }
        public bool IsTimeLimited { get; init; }
        public Maple.Models.Templates.Item.ItemLotteryInfo? Lottery { get; init; }
        public bool NoCancelMouse { get; init; }
        public string? QuestDeliveryEffect { get; init; }
        public Maple.Enums.ItemQuestDeliveryType? QuestDeliveryType { get; init; }
        public Maple.StrongId.ItemTemplateId ReplaceItemId { get; init; }
        public string? ReplaceMsg { get; init; }
        public int ReplacePeriod { get; init; }
        public int? ReqSkillLevel { get; init; }
        public Maple.StrongId.ItemTemplateId? ScrollId { get; init; }
        public int? WarningState { get; init; }
    }
    public sealed class ItemConsumeSpec : System.IEquatable<Maple.Models.Templates.Item.ItemConsumeSpec>
    {
        public ItemConsumeSpec(
                    int? Pad = default,
                    int? Pdd = default,
                    int? Mad = default,
                    int? Mdd = default,
                    int? Acc = default,
                    int? Eva = default,
                    int? Craft = default,
                    int? Speed = default,
                    int? Jump = default,
                    int? Time = default,
                    int? Hp = default,
                    int? Mp = default,
                    int? HpR = default,
                    int? MpR = default,
                    int? AreaBuffType = default,
                    int? IncStr = default,
                    int? IncDex = default,
                    int? IncInt = default,
                    int? IncLuk = default) { }
        public int? Acc { get; init; }
        public int? AreaBuffType { get; init; }
        public int? Craft { get; init; }
        public int? Eva { get; init; }
        public int? Hp { get; init; }
        public int? HpR { get; init; }
        public int? IncDex { get; init; }
        public int? IncInt { get; init; }
        public int? IncLuk { get; init; }
        public int? IncStr { get; init; }
        public int? Jump { get; init; }
        public int? Mad { get; init; }
        public int? Mdd { get; init; }
        public int? Mp { get; init; }
        public int? MpR { get; init; }
        public int? Pad { get; init; }
        public int? Pdd { get; init; }
        public int? Speed { get; init; }
        public int? Time { get; init; }
    }
    public sealed class ItemCraftingInfo : System.IEquatable<Maple.Models.Templates.Item.ItemCraftingInfo>
    {
        public ItemCraftingInfo(System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingRecipeEntry> ProducedBy, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingRecipeEntry> UsedIn) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingRecipeEntry> ProducedBy { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingRecipeEntry> UsedIn { get; init; }
    }
    public readonly struct ItemCraftingIngredient : System.IEquatable<Maple.Models.Templates.Item.ItemCraftingIngredient>
    {
        public ItemCraftingIngredient(Maple.StrongId.ItemTemplateId ItemId, int Count) { }
        public int Count { get; init; }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
    }
    public sealed class ItemCraftingRecipeEntry : System.IEquatable<Maple.Models.Templates.Item.ItemCraftingRecipeEntry>
    {
        public ItemCraftingRecipeEntry(int RecipeId, Maple.StrongId.ItemTemplateId ResultItemId, int ResultCount, int ReqLevel = 0, Maple.StrongId.SkillTemplateId ReqSkillId = default, int ReqSkillLevel = 0, int ReqSkillProficiency = 0, int ReqMeso = 0, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingIngredient>? Ingredients = null, int ResultProb = 0) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemCraftingIngredient>? Ingredients { get; init; }
        public int RecipeId { get; init; }
        public int ReqLevel { get; init; }
        public int ReqMeso { get; init; }
        public Maple.StrongId.SkillTemplateId ReqSkillId { get; init; }
        public int ReqSkillLevel { get; init; }
        public int ReqSkillProficiency { get; init; }
        public int ResultCount { get; init; }
        public Maple.StrongId.ItemTemplateId ResultItemId { get; init; }
        public int ResultProb { get; init; }
    }
    public readonly struct ItemEquipElementResist : System.IEquatable<Maple.Models.Templates.Item.ItemEquipElementResist>
    {
        public ItemEquipElementResist(int Poison, int Ice, int Fire, int Lightning, int Holy) { }
        public int Fire { get; init; }
        public int Holy { get; init; }
        public int Ice { get; init; }
        public int Lightning { get; init; }
        public int Poison { get; init; }
    }
    public sealed class ItemEquipFlags : System.IEquatable<Maple.Models.Templates.Item.ItemEquipFlags>
    {
        public ItemEquipFlags(
                    Maple.Models.Templates.Item.ItemTradabilityFlags Tradability,
                    Maple.Models.Templates.Item.ItemUpgradeData Upgrade,
                    int SellPrice,
                    bool IsBigSize = false,
                    bool IsEpic = false,
                    bool IsTransform = false,
                    Maple.StrongId.ItemTemplateId? NameTag = default,
                    Maple.StrongId.ItemTemplateId? ChatBalloon = default,
                    int Durability = 0,
                    Maple.StrongId.ItemTemplateId? SpecialId = default,
                    Maple.StrongId.ItemTemplateId? ReplaceItemId = default,
                    string? ReplaceMsg = null,
                    Maple.Enums.Gender Gender = 2,
                    Maple.Enums.ItemAttackSpeed? AttackSpeed = default,
                    bool IsInvisibleCash = false,
                    string? AfterImage = null,
                    string? ISlot = null,
                    string? VSlot = null,
                    string? Sfx = null,
                    string? WalkAnim = null,
                    string? StandAnim = null,
                    string? AttackAnim = null,
                    int NAttackSpeed = 0) { }
        public string? AfterImage { get; init; }
        public string? AttackAnim { get; init; }
        public Maple.Enums.ItemAttackSpeed? AttackSpeed { get; init; }
        public Maple.StrongId.ItemTemplateId? ChatBalloon { get; init; }
        public int Durability { get; init; }
        public Maple.Enums.Gender Gender { get; init; }
        public string? ISlot { get; init; }
        public bool IsBigSize { get; init; }
        public bool IsEpic { get; init; }
        public bool IsInvisibleCash { get; init; }
        public bool IsTransform { get; init; }
        public int NAttackSpeed { get; init; }
        public Maple.StrongId.ItemTemplateId? NameTag { get; init; }
        public Maple.StrongId.ItemTemplateId? ReplaceItemId { get; init; }
        public string? ReplaceMsg { get; init; }
        public int SellPrice { get; init; }
        public string? Sfx { get; init; }
        public Maple.StrongId.ItemTemplateId? SpecialId { get; init; }
        public string? StandAnim { get; init; }
        public Maple.Models.Templates.Item.ItemTradabilityFlags Tradability { get; init; }
        public Maple.Models.Templates.Item.ItemUpgradeData Upgrade { get; init; }
        public string? VSlot { get; init; }
        public string? WalkAnim { get; init; }
    }
    public readonly struct ItemEquipRequirements : System.IEquatable<Maple.Models.Templates.Item.ItemEquipRequirements>
    {
        public ItemEquipRequirements(int ReqLevel, Maple.Enums.JobCategory ReqJob, int ReqSTR, int ReqDEX, int ReqINT, int ReqLUK, int ReqFame, int ReqMobLevel = 0) { }
        public int ReqDEX { get; init; }
        public int ReqFame { get; init; }
        public int ReqINT { get; init; }
        public Maple.Enums.JobCategory ReqJob { get; init; }
        public int ReqLUK { get; init; }
        public int ReqLevel { get; init; }
        public int ReqMobLevel { get; init; }
        public int ReqSTR { get; init; }
    }
    public sealed class ItemLevelInfo : System.IEquatable<Maple.Models.Templates.Item.ItemLevelInfo>
    {
        public ItemLevelInfo(int Level, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelStat> Stats) { }
        public int Level { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelStat> Stats { get; init; }
    }
    public readonly struct ItemLevelStat : System.IEquatable<Maple.Models.Templates.Item.ItemLevelStat>
    {
        public ItemLevelStat(string Name, int Value) { }
        public string Name { get; init; }
        public int Value { get; init; }
    }
    public readonly struct ItemLotteryEntry : System.IEquatable<Maple.Models.Templates.Item.ItemLotteryEntry>
    {
        public ItemLotteryEntry(Maple.StrongId.ItemTemplateId ItemId, int Prob, int Quantity = 1, int Period = 0, string? Effect = null, string? WorldMsg = null) { }
        public string? Effect { get; init; }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public int Period { get; init; }
        public int Prob { get; init; }
        public int Quantity { get; init; }
        public string? WorldMsg { get; init; }
    }
    public sealed class ItemLotteryInfo : System.IEquatable<Maple.Models.Templates.Item.ItemLotteryInfo>
    {
        public ItemLotteryInfo(System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLotteryEntry> Rewards, int TotalProb) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLotteryEntry> Rewards { get; init; }
        public int TotalProb { get; init; }
    }
    public sealed class ItemOptionEntry : System.IEquatable<Maple.Models.Templates.Item.ItemOptionEntry>
    {
        public ItemOptionEntry(int OptionId, Maple.Models.Templates.Item.ItemOptionInfo Info, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemOptionLevelData> Levels) { }
        public Maple.Models.Templates.Item.ItemOptionInfo Info { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemOptionLevelData> Levels { get; init; }
        public int OptionId { get; init; }
    }
    public readonly struct ItemOptionInfo : System.IEquatable<Maple.Models.Templates.Item.ItemOptionInfo>
    {
        public ItemOptionInfo(int ReqLevel, Maple.Enums.ItemOptionType OptionType) { }
        public Maple.Enums.ItemOptionType OptionType { get; init; }
        public int ReqLevel { get; init; }
    }
    public readonly struct ItemOptionLevelData : System.IEquatable<Maple.Models.Templates.Item.ItemOptionLevelData>
    {
        public ItemOptionLevelData(
                    int Prob = 0,
                    int Time = 0,
                    int IncStr = 0,
                    int IncDex = 0,
                    int IncInt = 0,
                    int IncLuk = 0,
                    int IncHp = 0,
                    int IncMp = 0,
                    int IncMhp = 0,
                    int IncMmp = 0,
                    int IncAcc = 0,
                    int IncEva = 0,
                    int IncSpeed = 0,
                    int IncJump = 0,
                    int IncPad = 0,
                    int IncMad = 0,
                    int IncPdd = 0,
                    int IncMdd = 0,
                    int IncStrR = 0,
                    int IncDexR = 0,
                    int IncIntR = 0,
                    int IncLukR = 0,
                    int IncMhpR = 0,
                    int IncMmpR = 0,
                    int IncAccR = 0,
                    int IncEvaR = 0,
                    int IncPadR = 0,
                    int IncMadR = 0,
                    int IncPddR = 0,
                    int IncMddR = 0,
                    int IncCr = 0,
                    int IncCDr = 0,
                    int IncMamR = 0,
                    int IncSkill = 0,
                    int IncAllSkill = 0,
                    int RecoveryHp = 0,
                    int RecoveryMp = 0,
                    int RecoveryUp = 0,
                    int MpConReduce = 0,
                    int MpConRestore = 0,
                    int IgnoreTargetDef = 0,
                    int IgnoreDam = 0,
                    int IgnoreDamR = 0,
                    int IncDamR = 0,
                    int DamReflect = 0,
                    int AttackType = 0,
                    int IncMesoProb = 0,
                    int IncRewardProb = 0,
                    int Level = 0,
                    int Boss = 0,
                    bool EmotionAngry = false,
                    bool EmotionCheer = false,
                    bool EmotionLove = false,
                    bool EmotionBlaze = false,
                    bool EmotionGlitter = false,
                    bool HasEmotion = false) { }
        public int AttackType { get; init; }
        public int Boss { get; init; }
        public int DamReflect { get; init; }
        public bool EmotionAngry { get; init; }
        public bool EmotionBlaze { get; init; }
        public bool EmotionCheer { get; init; }
        public bool EmotionGlitter { get; init; }
        public bool EmotionLove { get; init; }
        public bool HasEmotion { get; init; }
        public int IgnoreDam { get; init; }
        public int IgnoreDamR { get; init; }
        public int IgnoreTargetDef { get; init; }
        public int IncAcc { get; init; }
        public int IncAccR { get; init; }
        public int IncAllSkill { get; init; }
        public int IncCDr { get; init; }
        public int IncCr { get; init; }
        public int IncDamR { get; init; }
        public int IncDex { get; init; }
        public int IncDexR { get; init; }
        public int IncEva { get; init; }
        public int IncEvaR { get; init; }
        public int IncHp { get; init; }
        public int IncInt { get; init; }
        public int IncIntR { get; init; }
        public int IncJump { get; init; }
        public int IncLuk { get; init; }
        public int IncLukR { get; init; }
        public int IncMad { get; init; }
        public int IncMadR { get; init; }
        public int IncMamR { get; init; }
        public int IncMdd { get; init; }
        public int IncMddR { get; init; }
        public int IncMesoProb { get; init; }
        public int IncMhp { get; init; }
        public int IncMhpR { get; init; }
        public int IncMmp { get; init; }
        public int IncMmpR { get; init; }
        public int IncMp { get; init; }
        public int IncPad { get; init; }
        public int IncPadR { get; init; }
        public int IncPdd { get; init; }
        public int IncPddR { get; init; }
        public int IncRewardProb { get; init; }
        public int IncSkill { get; init; }
        public int IncSpeed { get; init; }
        public int IncStr { get; init; }
        public int IncStrR { get; init; }
        public int Level { get; init; }
        public int MpConReduce { get; init; }
        public int MpConRestore { get; init; }
        public int Prob { get; init; }
        public int RecoveryHp { get; init; }
        public int RecoveryMp { get; init; }
        public int RecoveryUp { get; init; }
        public int Time { get; init; }
    }
    public sealed class ItemPetInfo : System.IEquatable<Maple.Models.Templates.Item.ItemPetInfo>
    {
        public ItemPetInfo(
                    Maple.StrongId.MobTemplateId Pet,
                    int? Life = default,
                    int? Hungry = default,
                    bool NoRevive = false,
                    bool NoMoveToLocker = false,
                    Maple.StrongId.ItemTemplateId? NameTag = default,
                    Maple.StrongId.ItemTemplateId? ChatBalloon = default,
                    bool PickUpItem = false,
                    bool ConsumeHp = false,
                    bool ConsumeMp = false,
                    bool SweepForDrop = false,
                    bool LongRange = false,
                    bool IgnorePickup = false,
                    bool Recall = false,
                    bool AutoSpeaking = false,
                    bool AutoReact = false,
                    bool InteractByUser = false,
                    System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.PetEvolutionEntry>? Evolutions = null) { }
        public bool AutoReact { get; init; }
        public bool AutoSpeaking { get; init; }
        public Maple.StrongId.ItemTemplateId? ChatBalloon { get; init; }
        public bool ConsumeHp { get; init; }
        public bool ConsumeMp { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.PetEvolutionEntry>? Evolutions { get; init; }
        public int? Hungry { get; init; }
        public bool IgnorePickup { get; init; }
        public bool InteractByUser { get; init; }
        public int? Life { get; init; }
        public bool LongRange { get; init; }
        public Maple.StrongId.ItemTemplateId? NameTag { get; init; }
        public bool NoMoveToLocker { get; init; }
        public bool NoRevive { get; init; }
        public Maple.StrongId.MobTemplateId Pet { get; init; }
        public bool PickUpItem { get; init; }
        public bool Recall { get; init; }
        public bool SweepForDrop { get; init; }
    }
    public readonly struct ItemSkillEntry : System.IEquatable<Maple.Models.Templates.Item.ItemSkillEntry>
    {
        public ItemSkillEntry(Maple.StrongId.SkillTemplateId SkillId, int SkillLevel) { }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
        public int SkillLevel { get; init; }
    }
    public sealed class ItemTemplateBundleData : System.IEquatable<Maple.Models.Templates.Item.ItemTemplateBundleData>
    {
        public ItemTemplateBundleData() { }
        public required Maple.Models.Templates.Item.ItemBundleInfo BundleInfo { get; init; }
    }
    public sealed class ItemTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Item.ItemTemplateEntry>
    {
        public ItemTemplateEntry(int id, string name, Maple.Models.Templates.Item.ItemTemplateTextData? text = null, Maple.Models.Templates.Item.ItemTemplateEquipData? equip = null, Maple.Models.Templates.Item.ItemTemplateBundleData? bundle = null) { }
        public Maple.Models.Templates.Item.ItemAdditionData? Addition { get; }
        public string? AutoDesc { get; }
        public Maple.Models.Templates.Item.ItemTemplateBundleData? Bundle { get; }
        public Maple.Models.Templates.Item.ItemBundleInfo? BundleInfo { get; }
        public Maple.Models.Templates.Item.ItemEquipElementResist? ElementResist { get; }
        public Maple.Models.Templates.Item.ItemTemplateEquipData? Equip { get; }
        public Maple.Models.Templates.Item.ItemEquipFlags? Flags { get; }
        public bool IsBundle { get; }
        public bool IsEquip { get; }
        public Maple.StrongId.ItemTemplateId ItemId { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemSkillEntry>? ItemSkills { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelInfo>? LevelInfos { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelInfo>? RandomStatPotentials { get; }
        public Maple.Models.Templates.Item.ItemEquipRequirements? Requirements { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemSkillEntry>? SkillLevelBonuses { get; }
        public Maple.Models.Templates.Item.ItemTemplateStats? Stats { get; }
        public string? SubCategory { get; }
        public Maple.Models.Templates.Item.ItemTemplateTextData? Text { get; }
    }
    public sealed class ItemTemplateEquipData : System.IEquatable<Maple.Models.Templates.Item.ItemTemplateEquipData>
    {
        public ItemTemplateEquipData() { }
        public Maple.Models.Templates.Item.ItemAdditionData? Addition { get; init; }
        public Maple.Models.Templates.Item.ItemEquipElementResist? ElementResist { get; init; }
        public Maple.Models.Templates.Item.ItemEquipFlags? Flags { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemSkillEntry>? ItemSkills { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelInfo>? LevelInfos { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemLevelInfo>? RandomStatPotentials { get; init; }
        public Maple.Models.Templates.Item.ItemEquipRequirements? Requirements { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Item.ItemSkillEntry>? SkillLevelBonuses { get; init; }
        public Maple.Models.Templates.Item.ItemTemplateStats? Stats { get; init; }
    }
    public sealed class ItemTemplateStats : System.IEquatable<Maple.Models.Templates.Item.ItemTemplateStats>
    {
        public ItemTemplateStats() { }
        public int DamR { get; init; }
        public int Fs { get; init; }
        public int Hp { get; init; }
        public short IncACC { get; init; }
        public short IncBDR { get; init; }
        public short IncCraft { get; init; }
        public short IncDEX { get; init; }
        public short IncEVA { get; init; }
        public short IncFatigue { get; init; }
        public short IncIMDR { get; init; }
        public short IncINT { get; init; }
        public short IncJump { get; init; }
        public short IncLUK { get; init; }
        public short IncMAD { get; init; }
        public short IncMDD { get; init; }
        public int IncMaxHP { get; init; }
        public short IncMaxHPr { get; init; }
        public int IncMaxMP { get; init; }
        public short IncMaxMPr { get; init; }
        public short IncPAD { get; init; }
        public short IncPDD { get; init; }
        public short IncRDamage { get; init; }
        public short IncSTR { get; init; }
        public short IncSpeed { get; init; }
        public short IncSwim { get; init; }
        public int Knockback { get; init; }
        public int MddR { get; init; }
        public int Mp { get; init; }
        public int PddR { get; init; }
        public int Recovery { get; init; }
        public int Swim { get; init; }
        public Maple.StrongId.TamingMobTemplateId? TamingMob { get; init; }
    }
    public sealed class ItemTemplateTextData : System.IEquatable<Maple.Models.Templates.Item.ItemTemplateTextData>
    {
        public ItemTemplateTextData() { }
        public string? AutoDescription { get; init; }
        public string? Category { get; init; }
        public string? Description { get; init; }
        public string? SubCategory { get; init; }
    }
    public readonly struct ItemTradabilityFlags : System.IEquatable<Maple.Models.Templates.Item.ItemTradabilityFlags>
    {
        public ItemTradabilityFlags(bool IsCash = false, bool IsOnly = false, bool IsTradeBlock = false, bool IsQuest = false, bool IsNotSale = false, bool IsTimeLimited = false, bool IsPartyQuest = false, bool IsExpireOnLogout = false, bool IsAccountSharable = false, bool IsOnlyEquip = false, bool IsNotExtend = false, bool IsBindedWhenEquipped = false, bool IsSharableOnce = false, bool IsWeekly = false, bool IsTradeAvailable = false) { }
        public bool IsAccountSharable { get; init; }
        public bool IsBindedWhenEquipped { get; init; }
        public bool IsCash { get; init; }
        public bool IsExpireOnLogout { get; init; }
        public bool IsNotExtend { get; init; }
        public bool IsNotSale { get; init; }
        public bool IsOnly { get; init; }
        public bool IsOnlyEquip { get; init; }
        public bool IsPartyQuest { get; init; }
        public bool IsQuest { get; init; }
        public bool IsSharableOnce { get; init; }
        public bool IsTimeLimited { get; init; }
        public bool IsTradeAvailable { get; init; }
        public bool IsTradeBlock { get; init; }
        public bool IsWeekly { get; init; }
    }
    public readonly struct ItemUpgradeData : System.IEquatable<Maple.Models.Templates.Item.ItemUpgradeData>
    {
        public ItemUpgradeData(int RemainingUpgrades = 0, int TotalUpgrades = 0, int ItemUpgradeCount = 0, int ItemUpgradeCountMax = 0, Maple.Enums.ItemGrade MinGrade = 0, int KarmaType = 0, Maple.Enums.ItemEnchantCategory EnchantCategory = 0, Maple.StrongId.SetItemTemplateId SetItemId = default) { }
        public Maple.Enums.ItemEnchantCategory EnchantCategory { get; init; }
        public int ItemUpgradeCount { get; init; }
        public int ItemUpgradeCountMax { get; init; }
        public int KarmaType { get; init; }
        public Maple.Enums.ItemGrade MinGrade { get; init; }
        public int RemainingUpgrades { get; init; }
        public Maple.StrongId.SetItemTemplateId SetItemId { get; init; }
        public int TotalUpgrades { get; init; }
    }
    public readonly struct PetEvolutionEntry : System.IEquatable<Maple.Models.Templates.Item.PetEvolutionEntry>
    {
        public PetEvolutionEntry(Maple.StrongId.ItemTemplateId ItemId, int PeriodMs) { }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public int PeriodMs { get; init; }
    }
}
namespace Maple.Models.Templates.Life
{
    public sealed class LifeEntry : System.IEquatable<Maple.Models.Templates.Life.LifeEntry>
    {
        public LifeEntry(int Index, Maple.Enums.LifeType Type, int RawTemplateId, int X, int Y, int Foothold, int CeilingY, int RoamXMin, int RoamXMax, int FaceDirection, bool Hide, int? RespawnSeconds, int? Team) { }
        public Maple.StrongId.MobTemplateId AsMob { get; }
        public Maple.StrongId.NpcTemplateId AsNpc { get; }
        public int CeilingY { get; init; }
        public int FaceDirection { get; init; }
        public int Foothold { get; init; }
        public bool Hide { get; init; }
        public int Index { get; init; }
        public bool IsMob { get; }
        public bool IsNpc { get; }
        public Maple.StrongId.MobTemplateId? MobId { get; }
        public Maple.StrongId.NpcTemplateId? NpcId { get; }
        public int RawTemplateId { get; init; }
        public int? RespawnSeconds { get; init; }
        public int RoamXMax { get; init; }
        public int RoamXMin { get; init; }
        public int? Team { get; init; }
        [System.Obsolete("TemplateId exposes a raw int with no type context. Use NpcId or MobId (nullable) " +
            "for safe access, or TryGetNpcId / TryGetMobId for the try-pattern.", DiagnosticId="MAPLE001")]
        public int TemplateId { get; }
        public Maple.Enums.LifeType Type { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
        public bool TryGetMobId(out Maple.StrongId.MobTemplateId mobId) { }
        public bool TryGetNpcId(out Maple.StrongId.NpcTemplateId npcId) { }
        public static Maple.Models.Templates.Life.LifeEntry CreateMob(int index, Maple.StrongId.MobTemplateId mobId, int x, int y, int foothold, int ceilingY, int roamXMin, int roamXMax, int faceDirection, bool hide, int? respawnSeconds, int? team) { }
        public static Maple.Models.Templates.Life.LifeEntry CreateNpc(int index, Maple.StrongId.NpcTemplateId npcId, int x, int y, int foothold, int ceilingY, int roamXMin, int roamXMax, int faceDirection, bool hide, int? respawnSeconds, int? team) { }
    }
}
namespace Maple.Models.Templates.Map
{
    public sealed class ContinentMoveRouteEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Map.ContinentMoveRouteEntry>
    {
        public ContinentMoveRouteEntry(int Id, string Name, int ContinentId, int DestId, int TBoardBefore = 0, int TBoardAfter = 0, int TMove = 0, int TIngame = 0, int TEventBefore = 0, int TEventAfter = 0) { }
        public int ContinentId { get; init; }
        public int DestId { get; init; }
        public int TBoardAfter { get; init; }
        public int TBoardBefore { get; init; }
        public int TEventAfter { get; init; }
        public int TEventBefore { get; init; }
        public int TIngame { get; init; }
        public int TMove { get; init; }
    }
    public sealed class GlobalPhysicsEntry : System.IEquatable<Maple.Models.Templates.Map.GlobalPhysicsEntry>
    {
        public GlobalPhysicsEntry(
                    float? WalkForce = default,
                    float? WalkSpeed = default,
                    float? WalkDrag = default,
                    float? SlipForce = default,
                    float? SlipSpeed = default,
                    float? FloatDrag = default,
                    float? FloatDrag2 = default,
                    float? FloatCoefficient = default,
                    float? SwimForce = default,
                    float? SwimSpeed = default,
                    float? FlyForce = default,
                    float? FlySpeed = default,
                    float? GravityAcc = default,
                    float? FallSpeed = default,
                    float? JumpSpeed = default,
                    float? MaxFriction = default,
                    float? MinFriction = default,
                    float? SwimJumpSpeed = default,
                    float? FlyJumpSpeed = default) { }
        public float? FallSpeed { get; init; }
        public float? FloatCoefficient { get; init; }
        public float? FloatDrag { get; init; }
        public float? FloatDrag2 { get; init; }
        public float? FlyForce { get; init; }
        public float? FlyJumpSpeed { get; init; }
        public float? FlySpeed { get; init; }
        public float? GravityAcc { get; init; }
        public float? JumpSpeed { get; init; }
        public float? MaxFriction { get; init; }
        public float? MinFriction { get; init; }
        public float? SlipForce { get; init; }
        public float? SlipSpeed { get; init; }
        public float? SwimForce { get; init; }
        public float? SwimJumpSpeed { get; init; }
        public float? SwimSpeed { get; init; }
        public float? WalkDrag { get; init; }
        public float? WalkForce { get; init; }
        public float? WalkSpeed { get; init; }
    }
    public readonly struct MapAreaEntry : System.IEquatable<Maple.Models.Templates.Map.MapAreaEntry>
    {
        public MapAreaEntry(int Id, Maple.Models.Templates.Map.MapRect Bounds) { }
        public Maple.Models.Templates.Map.MapRect Bounds { get; init; }
        public int Id { get; init; }
    }
    public sealed class MapBackgroundEntry : System.IEquatable<Maple.Models.Templates.Map.MapBackgroundEntry>
    {
        public MapBackgroundEntry(int No, string? BgSet, Maple.Enums.BackgroundType BgType, bool IsFront, bool IsAnimated, int X = 0, int Y = 0, int Rx = 0, int Ry = 0, int Cx = 0, int Cy = 0, bool Flip = false, byte Alpha = 255, int Back = 0) { }
        public byte Alpha { get; init; }
        public int Back { get; init; }
        public string? BgSet { get; init; }
        public Maple.Enums.BackgroundType BgType { get; init; }
        public int Cx { get; init; }
        public int Cy { get; init; }
        public bool Flip { get; init; }
        public bool IsAnimated { get; init; }
        public bool IsFront { get; init; }
        public int No { get; init; }
        public int Rx { get; init; }
        public int Ry { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public readonly struct MapClockData : System.IEquatable<Maple.Models.Templates.Map.MapClockData>
    {
        public MapClockData(int X, int Y, int Width, int Height) { }
        public int Height { get; init; }
        public int Width { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public readonly struct MapCombatInfo : System.IEquatable<Maple.Models.Templates.Map.MapCombatInfo>
    {
        public MapCombatInfo(float MobRate = 1, int FixedMobCapacity = 0, bool PartyOnly = false) { }
        public int FixedMobCapacity { get; init; }
        public float MobRate { get; init; }
        public bool PartyOnly { get; init; }
    }
    public sealed class MapConstraints : System.IEquatable<Maple.Models.Templates.Map.MapConstraints>
    {
        public MapConstraints(
                    bool IsTown,
                    bool IsSwim,
                    bool IsFly,
                    Maple.Enums.MapFieldLimit FieldLimit,
                    Maple.StrongId.FieldTemplateId ReturnMapId,
                    int LvLimit = 0,
                    int LvForceMove = 0,
                    int MoveLimit = 0,
                    bool HideMinimap = false,
                    bool NeedSkillForFly = false,
                    bool PersonalShopAvailable = false,
                    bool DropEverlast = false,
                    bool ForcedReturn = false,
                    bool CannotUseCashWeather = false,
                    bool ExpeditionOnly = false,
                    bool AutoLieDetector = false,
                    bool NoMapCmd = false,
                    bool PqStay = false,
                    System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? AllowedItems = null,
                    System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? ForbiddenSkills = null) { }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId>? AllowedItems { get; init; }
        public bool AutoLieDetector { get; init; }
        public bool CannotUseCashWeather { get; init; }
        public bool DropEverlast { get; init; }
        public bool ExpeditionOnly { get; init; }
        public Maple.Enums.MapFieldLimit FieldLimit { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? ForbiddenSkills { get; init; }
        public bool ForcedReturn { get; init; }
        public bool HideMinimap { get; init; }
        public bool IsFly { get; init; }
        public bool IsSwim { get; init; }
        public bool IsTown { get; init; }
        public int LvForceMove { get; init; }
        public int LvLimit { get; init; }
        public int MoveLimit { get; init; }
        public bool NeedSkillForFly { get; init; }
        public bool NoMapCmd { get; init; }
        public bool PersonalShopAvailable { get; init; }
        public bool PqStay { get; init; }
        public Maple.StrongId.FieldTemplateId ReturnMapId { get; init; }
    }
    public sealed class MapEnvironmentData : System.IEquatable<Maple.Models.Templates.Map.MapEnvironmentData>
    {
        public MapEnvironmentData(
                    string? Bgm = null,
                    Maple.Enums.MapFieldType FieldType = 0,
                    Maple.Models.Templates.Map.MapRect? ViewBounds = default,
                    int TimeLimit = 0,
                    int Recovery = 0,
                    int ReduceHPAmount = 0,
                    int ConsumeItemCoolTime = 0,
                    Maple.StrongId.ItemTemplateId WeatherItemId = default,
                    Maple.StrongId.ItemTemplateId ProtectItem = default,
                    bool HasBoat = false,
                    Maple.Enums.MapBoatType BoatType = 0,
                    bool Everlast = false,
                    Maple.StrongId.FieldTemplateId? LinkedMapId = default,
                    Maple.Models.Templates.Map.MapCombatInfo? Combat = default,
                    string? UserEnterScript = null,
                    string? FirstUserEnterScript = null,
                    string? Description = null,
                    string? MapSpecificEffect = null,
                    int? Version = default,
                    string? MapMark = null,
                    int PhaseIndex = 0,
                    byte PhaseOverlayAlpha = 255) { }
        public string? Bgm { get; init; }
        public Maple.Enums.MapBoatType BoatType { get; init; }
        public Maple.Models.Templates.Map.MapCombatInfo? Combat { get; init; }
        public int ConsumeItemCoolTime { get; init; }
        public string? Description { get; init; }
        public bool Everlast { get; init; }
        public Maple.Enums.MapFieldType FieldType { get; init; }
        public string? FirstUserEnterScript { get; init; }
        public bool HasBoat { get; init; }
        public Maple.StrongId.FieldTemplateId? LinkedMapId { get; init; }
        public string? MapMark { get; init; }
        public string? MapSpecificEffect { get; init; }
        public int PhaseIndex { get; init; }
        public byte PhaseOverlayAlpha { get; init; }
        public Maple.StrongId.ItemTemplateId ProtectItem { get; init; }
        public int Recovery { get; init; }
        public int ReduceHPAmount { get; init; }
        public int TimeLimit { get; init; }
        public string? UserEnterScript { get; init; }
        public int? Version { get; init; }
        public Maple.Models.Templates.Map.MapRect? ViewBounds { get; init; }
        public Maple.StrongId.ItemTemplateId WeatherItemId { get; init; }
    }
    public sealed class MapEventData : System.IEquatable<Maple.Models.Templates.Map.MapEventData>
    {
        public MapEventData(Maple.Models.Templates.Map.MapShipData? Ship = null, Maple.Models.Templates.Map.MapClockData? Clock = default, Maple.Models.Templates.Map.MapHealerData? Healer = default, Maple.Models.Templates.Map.MapPulleyData? Pulley = default, Maple.Models.Templates.Map.MonsterCarnivalData? MonsterCarnival = null) { }
        public Maple.Models.Templates.Map.MapClockData? Clock { get; init; }
        public Maple.Models.Templates.Map.MapHealerData? Healer { get; init; }
        public Maple.Models.Templates.Map.MonsterCarnivalData? MonsterCarnival { get; init; }
        public Maple.Models.Templates.Map.MapPulleyData? Pulley { get; init; }
        public Maple.Models.Templates.Map.MapShipData? Ship { get; init; }
    }
    public readonly struct MapFootholdEntry : System.IEquatable<Maple.Models.Templates.Map.MapFootholdEntry>
    {
        public MapFootholdEntry(int Id, int X1, int Y1, int X2, int Y2, bool CantThrough = false, int? Prev = default, int? Next = default, int? Force = default, int? Piece = default, int Layer = 0, int Group = 0, float Drag = 0.2, bool Walk = true, bool ForbidFallDown = false) { }
        public bool CantThrough { get; init; }
        public float Drag { get; init; }
        public bool ForbidFallDown { get; init; }
        public int? Force { get; init; }
        public int Group { get; init; }
        public int Id { get; init; }
        public bool IsWall { get; }
        public int Layer { get; init; }
        public int? Next { get; init; }
        public int? Piece { get; init; }
        public int? Prev { get; init; }
        public bool Walk { get; init; }
        public int X1 { get; init; }
        public int X2 { get; init; }
        public int Y1 { get; init; }
        public int Y2 { get; init; }
    }
    public readonly struct MapHealerData : System.IEquatable<Maple.Models.Templates.Map.MapHealerData>
    {
        public MapHealerData(int X, int Y) { }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public sealed class MapInfoEntry : System.IEquatable<Maple.Models.Templates.Map.MapInfoEntry>
    {
        public MapInfoEntry(Maple.Models.Templates.Map.MapConstraints Constraints, Maple.Models.Templates.Map.MapEnvironmentData Environment, Maple.Models.Templates.Map.MapPhysicsData PhysicsData, Maple.Models.Templates.Map.MapEventData Events, System.Collections.Generic.IReadOnlyList<string>? HelpMessages = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPortalEntry>? Portals = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPoint>? SeatPositions = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapRect>? SwimRects = null, int FootholdCount = 0, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapBackgroundEntry>? Backgrounds = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapAreaEntry>? Areas = null) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapAreaEntry>? Areas { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapBackgroundEntry>? Backgrounds { get; init; }
        public Maple.Models.Templates.Map.MapConstraints Constraints { get; init; }
        public Maple.Models.Templates.Map.MapEnvironmentData Environment { get; init; }
        public Maple.Models.Templates.Map.MapEventData Events { get; init; }
        public int FootholdCount { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? HelpMessages { get; init; }
        public Maple.Models.Templates.Map.MapPhysicsData PhysicsData { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPortalEntry>? Portals { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPoint>? SeatPositions { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapRect>? SwimRects { get; init; }
    }
    public readonly struct MapLadderEntry : System.IEquatable<Maple.Models.Templates.Map.MapLadderEntry>
    {
        public MapLadderEntry(int Id, int X, int Y1, int Y2, int Page, bool IsLadder, int? UpperFootholdId = default) { }
        public int Id { get; init; }
        public bool IsLadder { get; init; }
        public int Page { get; init; }
        public int? UpperFootholdId { get; init; }
        public int X { get; init; }
        public int Y1 { get; init; }
        public int Y2 { get; init; }
    }
    public readonly struct MapObjectEntry : System.IEquatable<Maple.Models.Templates.Map.MapObjectEntry>
    {
        public MapObjectEntry(
                    int X,
                    int Y,
                    string ObjSet,
                    string L0,
                    string L1,
                    string L2,
                    int Z,
                    int ZM,
                    int Layer,
                    bool FlipH = false,
                    bool IsReactive = false,
                    int MoveType = 0,
                    bool IsDynamic = false,
                    int? Piece = default,
                    string? ObjName = null,
                    bool IsHidden = false,
                    bool HasFlow = false,
                    Maple.StrongId.QuestTemplateId? QuestId = default,
                    Maple.Models.Templates.Map.MapPoint? MovePoint = default) { }
        public bool FlipH { get; init; }
        public bool HasFlow { get; init; }
        public bool IsDynamic { get; init; }
        public bool IsHidden { get; init; }
        public bool IsReactive { get; init; }
        public string L0 { get; init; }
        public string L1 { get; init; }
        public string L2 { get; init; }
        public int Layer { get; init; }
        public Maple.Models.Templates.Map.MapPoint? MovePoint { get; init; }
        public int MoveType { get; init; }
        public string? ObjName { get; init; }
        public string ObjSet { get; init; }
        public int? Piece { get; init; }
        public Maple.StrongId.QuestTemplateId? QuestId { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
        public int Z { get; init; }
        public int ZM { get; init; }
    }
    public sealed class MapPhysicsData : System.IEquatable<Maple.Models.Templates.Map.MapPhysicsData>
    {
        public MapPhysicsData(Maple.Models.Templates.Map.MapPhysicsInfo? Physics = null, bool MirrorBottom = false, bool ReactorShuffle = false, bool Cloud = false) { }
        public bool Cloud { get; init; }
        public bool MirrorBottom { get; init; }
        public Maple.Models.Templates.Map.MapPhysicsInfo? Physics { get; init; }
        public bool ReactorShuffle { get; init; }
    }
    public sealed class MapPhysicsInfo : System.IEquatable<Maple.Models.Templates.Map.MapPhysicsInfo>
    {
        public MapPhysicsInfo(float? Fs = default, Maple.Models.Templates.Map.GlobalPhysicsEntry? Override = null) { }
        public float? Fs { get; init; }
        public Maple.Models.Templates.Map.GlobalPhysicsEntry? Override { get; init; }
    }
    public readonly struct MapPoint : System.IEquatable<Maple.Models.Templates.Map.MapPoint>
    {
        public MapPoint(int X, int Y) { }
        public int X { get; init; }
        public int Y { get; init; }
        public override string ToString() { }
    }
    public sealed class MapPortalEntry : System.IEquatable<Maple.Models.Templates.Map.MapPortalEntry>
    {
        public MapPortalEntry(
                    string Name,
                    Maple.Enums.MapPortalType Type,
                    Maple.Models.Templates.Map.MapPoint Position,
                    Maple.StrongId.FieldTemplateId? TargetMapId = default,
                    string? TargetName = null,
                    string? Script = null,
                    bool OnlyOnce = false,
                    int Delay = 0,
                    bool HideTooltip = false,
                    string? ReactorName = null,
                    string? SessionValueKey = null,
                    string? SessionValue = null,
                    int? HorizontalRange = default,
                    int? VerticalRange = default,
                    string? Image = null,
                    int? VerticalImpact = default,
                    int? HorizontalImpact = default) { }
        public int Delay { get; init; }
        public bool HideTooltip { get; init; }
        public int? HorizontalImpact { get; init; }
        public int? HorizontalRange { get; init; }
        public string? Image { get; init; }
        public string Name { get; init; }
        public bool OnlyOnce { get; init; }
        public Maple.Models.Templates.Map.MapPoint Position { get; init; }
        public string? ReactorName { get; init; }
        public string? Script { get; init; }
        public string? SessionValue { get; init; }
        public string? SessionValueKey { get; init; }
        public Maple.StrongId.FieldTemplateId? TargetMapId { get; init; }
        public string? TargetName { get; init; }
        public Maple.Enums.MapPortalType Type { get; init; }
        public int? VerticalImpact { get; init; }
        public int? VerticalRange { get; init; }
    }
    public readonly struct MapPulleyData : System.IEquatable<Maple.Models.Templates.Map.MapPulleyData>
    {
        public MapPulleyData(int X, int Y, int? Hp) { }
        public int? Hp { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public readonly struct MapReactorEntry : System.IEquatable<Maple.Models.Templates.Map.MapReactorEntry>
    {
        public MapReactorEntry(Maple.StrongId.ReactorTemplateId TemplateId, int X, int Y, int FaceDirection, string? Name = null, int? ReactorTime = default) { }
        public int FaceDirection { get; init; }
        public string? Name { get; init; }
        public int? ReactorTime { get; init; }
        public Maple.StrongId.ReactorTemplateId TemplateId { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public readonly struct MapRect : System.IEquatable<Maple.Models.Templates.Map.MapRect>
    {
        public MapRect(int Left, int Top, int Right, int Bottom) { }
        public int Bottom { get; init; }
        public int Height { get; }
        public int Left { get; init; }
        public int Right { get; init; }
        public int Top { get; init; }
        public int Width { get; }
        public override string ToString() { }
    }
    public sealed class MapShipData : System.IEquatable<Maple.Models.Templates.Map.MapShipData>
    {
        public MapShipData(string? ShipObj, int? ShipKind, int? TMove, int? X, int? X0, int? Y, int? Z, int? TAppear, bool Flip, int? LimitX0, int? LimitX, int? LimitY0, int? LimitY) { }
        public bool Flip { get; init; }
        public int? LimitX { get; init; }
        public int? LimitX0 { get; init; }
        public int? LimitY { get; init; }
        public int? LimitY0 { get; init; }
        public int? ShipKind { get; init; }
        public string? ShipObj { get; init; }
        public int? TAppear { get; init; }
        public int? TMove { get; init; }
        public int? X { get; init; }
        public int? X0 { get; init; }
        public int? Y { get; init; }
        public int? Z { get; init; }
    }
    public sealed class MapTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Map.MapTemplateEntry>
    {
        public MapTemplateEntry(int Id, string Name, string? StreetName = null, string? Help = null) { }
        public Maple.StrongId.FieldTemplateId FieldId { get; }
        public string? Help { get; init; }
        public string? StreetName { get; init; }
    }
    public readonly struct MapTileEntry : System.IEquatable<Maple.Models.Templates.Map.MapTileEntry>
    {
        public MapTileEntry(int X, int Y, string TileSet, string U, int No, int ZM, int Layer, bool FlipH = false) { }
        public bool FlipH { get; init; }
        public int Layer { get; init; }
        public int No { get; init; }
        public string TileSet { get; init; }
        public string U { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
        public int ZM { get; init; }
    }
    public sealed class MonsterCarnivalData : System.IEquatable<Maple.Models.Templates.Map.MonsterCarnivalData>
    {
        public MonsterCarnivalData(int TimeLimit, int MaxGuardianCount, bool UsesUpgradedPointSystem, System.Collections.Generic.IReadOnlyList<int>? CarnivalPointThresholds = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPoint>? GuardianSpawnPositions = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry>? Guardians = null, Maple.Models.Templates.Map.MonsterCarnivalTeamData? Team0 = null, Maple.Models.Templates.Map.MonsterCarnivalTeamData? Team1 = null) { }
        public System.Collections.Generic.IReadOnlyList<int>? CarnivalPointThresholds { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MapPoint>? GuardianSpawnPositions { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry>? Guardians { get; init; }
        public int MaxGuardianCount { get; init; }
        public Maple.Models.Templates.Map.MonsterCarnivalTeamData? Team0 { get; init; }
        public Maple.Models.Templates.Map.MonsterCarnivalTeamData? Team1 { get; init; }
        public int TimeLimit { get; init; }
        public bool UsesUpgradedPointSystem { get; init; }
    }
    public readonly struct MonsterCarnivalShopEntry : System.IEquatable<Maple.Models.Templates.Map.MonsterCarnivalShopEntry>
    {
        public MonsterCarnivalShopEntry(int? EntryId, string Name, string Description, int CpCost) { }
        public int CpCost { get; init; }
        public string Description { get; init; }
        public int? EntryId { get; init; }
        public string Name { get; init; }
    }
    public sealed class MonsterCarnivalTeamData : System.IEquatable<Maple.Models.Templates.Map.MonsterCarnivalTeamData>
    {
        public MonsterCarnivalTeamData(System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry> Skills, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry> MobSummons) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry> MobSummons { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Map.MonsterCarnivalShopEntry> Skills { get; init; }
    }
}
namespace Maple.Models.Templates.Mob
{
    public sealed class MobAttackSummary : System.IEquatable<Maple.Models.Templates.Mob.MobAttackSummary>
    {
        public MobAttackSummary(
                    int Index,
                    int PADamage,
                    int ConMP,
                    bool IsMagic,
                    bool IsDeadly,
                    bool HasKnockBack,
                    int MPBurn,
                    int? RangeLeft = default,
                    int? RangeTop = default,
                    int? RangeRight = default,
                    int? RangeBottom = default,
                    Maple.Enums.Element? ElemAttr = default,
                    Maple.Enums.MobAttackRange Type = 0,
                    int BulletNumber = 0,
                    int BulletSpeed = 0,
                    int EffectAfterMs = 0,
                    int AttackAfterMs = 0,
                    int RandDelayMs = 0,
                    bool Tremble = false,
                    bool DoFirst = false,
                    bool IsRush = false,
                    bool IsSpecial = false,
                    bool IsInactive = false,
                    bool IsJumpAttack = false,
                    bool HitAttach = false,
                    bool FacingAttach = false,
                    string? EffectUol = null,
                    string? BallUol = null,
                    string? HitUol = null,
                    string? AreaWarningUol = null) { }
        public string? AreaWarningUol { get; init; }
        public int AttackAfterMs { get; init; }
        public string? BallUol { get; init; }
        public int BulletNumber { get; init; }
        public int BulletSpeed { get; init; }
        public int ConMP { get; init; }
        public bool DoFirst { get; init; }
        public int EffectAfterMs { get; init; }
        public string? EffectUol { get; init; }
        public Maple.Enums.Element? ElemAttr { get; init; }
        public bool FacingAttach { get; init; }
        public bool HasKnockBack { get; init; }
        public bool HitAttach { get; init; }
        public string? HitUol { get; init; }
        public int Index { get; init; }
        public bool IsDeadly { get; init; }
        public bool IsInactive { get; init; }
        public bool IsJumpAttack { get; init; }
        public bool IsMagic { get; init; }
        public bool IsRush { get; init; }
        public bool IsSpecial { get; init; }
        public int MPBurn { get; init; }
        public int PADamage { get; init; }
        public int RandDelayMs { get; init; }
        public int? RangeBottom { get; init; }
        public int? RangeLeft { get; init; }
        public int? RangeRight { get; init; }
        public int? RangeTop { get; init; }
        public bool Tremble { get; init; }
        public Maple.Enums.MobAttackRange Type { get; init; }
    }
    public readonly struct MobBehaviorFlags : System.IEquatable<Maple.Models.Templates.Mob.MobBehaviorFlags>
    {
        public MobBehaviorFlags(
                    bool Boss = false,
                    bool Undead = false,
                    bool BodyAttack = false,
                    bool FirstAttack = false,
                    bool Invincible = false,
                    bool NotAttack = false,
                    bool SelfDestruction = false,
                    bool FirstSelfDestruction = false,
                    bool Chase = false,
                    bool Disable = false,
                    bool NoFlip = false,
                    bool DamagedByMob = false,
                    bool PickUpDrop = false,
                    bool HideHP = false,
                    bool HideName = false,
                    bool HideLevel = false,
                    bool AngerGauge = false,
                    bool RegenAction = false,
                    bool HPGaugeHide = false,
                    bool OnlyNormalAttack = false,
                    bool CantPassByTeleport = false,
                    bool CannotEvade = false,
                    bool UpperMostLayer = false,
                    bool NoRegen = false) { }
        public bool AngerGauge { get; init; }
        public bool BodyAttack { get; init; }
        public bool Boss { get; init; }
        public bool CannotEvade { get; init; }
        public bool CantPassByTeleport { get; init; }
        public bool Chase { get; init; }
        public bool DamagedByMob { get; init; }
        public bool Disable { get; init; }
        public bool FirstAttack { get; init; }
        public bool FirstSelfDestruction { get; init; }
        public bool HPGaugeHide { get; init; }
        public bool HideHP { get; init; }
        public bool HideLevel { get; init; }
        public bool HideName { get; init; }
        public bool Invincible { get; init; }
        public bool NoFlip { get; init; }
        public bool NoRegen { get; init; }
        public bool NotAttack { get; init; }
        public bool OnlyNormalAttack { get; init; }
        public bool PickUpDrop { get; init; }
        public bool RegenAction { get; init; }
        public bool SelfDestruction { get; init; }
        public bool Undead { get; init; }
        public bool UpperMostLayer { get; init; }
    }
    public sealed class MobCombatData : System.IEquatable<Maple.Models.Templates.Mob.MobCombatData>
    {
        public MobCombatData(Maple.Models.Templates.Mob.MobCoreStats Stats, Maple.Models.Templates.Mob.MobBehaviorFlags Behavior, int HPRecovery, int MPRecovery, int FixedDamage, string? ElemAttr, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobElementResistance> ElementResistances, int AttackCount, int SkillCount, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobAttackSummary> Attacks, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSkillEntry> Skills) { }
        public int AttackCount { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobAttackSummary> Attacks { get; init; }
        public Maple.Models.Templates.Mob.MobBehaviorFlags Behavior { get; init; }
        public string? ElemAttr { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobElementResistance> ElementResistances { get; init; }
        public int FixedDamage { get; init; }
        public int HPRecovery { get; init; }
        public int MPRecovery { get; init; }
        public int SkillCount { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSkillEntry> Skills { get; init; }
        public Maple.Models.Templates.Mob.MobCoreStats Stats { get; init; }
    }
    public readonly struct MobCoreStats : System.IEquatable<Maple.Models.Templates.Mob.MobCoreStats>
    {
        public MobCoreStats(int Level, long MaxHP, int MaxMP, int PADamage, int MADamage, int PDRate, int MDRate, int Accuracy, int Evasion, int Exp, int Speed, int FlySpeed) { }
        public int Accuracy { get; init; }
        public int Evasion { get; init; }
        public int Exp { get; init; }
        public int FlySpeed { get; init; }
        public int Level { get; init; }
        public int MADamage { get; init; }
        public int MDRate { get; init; }
        public long MaxHP { get; init; }
        public int MaxMP { get; init; }
        public int PADamage { get; init; }
        public int PDRate { get; init; }
        public int Speed { get; init; }
    }
    public readonly struct MobDropEntry : System.IEquatable<Maple.Models.Templates.Mob.MobDropEntry>
    {
        public MobDropEntry(Maple.StrongId.ItemTemplateId ItemId, int Min, int Max, int Prop) { }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public int Max { get; init; }
        public int Min { get; init; }
        public int Prop { get; init; }
    }
    public readonly struct MobElementResistance : System.IEquatable<Maple.Models.Templates.Mob.MobElementResistance>
    {
        public MobElementResistance(Maple.Enums.Element ElemType, Maple.Enums.ElemResistanceTier Tier) { }
        public Maple.Enums.Element ElemType { get; init; }
        public Maple.Enums.ElemResistanceTier Tier { get; init; }
    }
    public sealed class MobInfoEntry : System.IEquatable<Maple.Models.Templates.Mob.MobInfoEntry>
    {
        public MobInfoEntry(Maple.Models.Templates.Mob.MobCombatData combat, Maple.Models.Templates.Mob.MobMetadata metadata, Maple.Models.Templates.Mob.MobInteractionData interaction) { }
        public int AttackCount { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobAttackSummary> Attacks { get; }
        public Maple.Enums.MobBanType? BanType { get; }
        public Maple.Models.Templates.Mob.MobBehaviorFlags Behavior { get; }
        public Maple.Enums.MobCategory? Category { get; }
        public int? ChargeCount { get; }
        public int? ChaseSpeed { get; }
        public Maple.Enums.ChatBalloonType? ChatBalloon { get; }
        public Maple.Models.Templates.Mob.MobCombatData Combat { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? DamagedBySelectedMob { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? DamagedBySelectedSkill { get; }
        public int? DieCount { get; }
        public int? DropItemPeriod { get; }
        public string? ElemAttr { get; }
        public System.Collections.Generic.IReadOnlyDictionary<Maple.Enums.Element, int>? ElemBonus { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobElementResistance> ElementResistances { get; }
        public Maple.Enums.MobEscortType? EscortType { get; }
        public int? FixedBodyAttackDamR { get; }
        public int FixedDamage { get; }
        public float? Fs { get; }
        public int HPRecovery { get; }
        public int? HitCount { get; }
        public Maple.Models.Common.ArgbColor? HpTagBgColor { get; }
        public Maple.Models.Common.ArgbColor? HpTagColor { get; }
        public Maple.Models.Templates.Mob.MobInteractionData Interaction { get; }
        public int MPRecovery { get; }
        public Maple.Models.Templates.Mob.MobMetadata Metadata { get; }
        public int? MonsterBookId { get; }
        public Maple.Enums.MobMoveAbility MoveAbility { get; }
        public int? PushedDamage { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? ReviveIds { get; }
        public int SkillCount { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSkillEntry> Skills { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSpeakEntry>? SpeakInfo { get; }
        public Maple.Enums.MobSpecies? Species { get; }
        public Maple.Models.Templates.Mob.MobCoreStats Stats { get; }
        public Maple.StrongId.ItemTemplateId? WeaponId { get; }
    }
    public sealed class MobInteractionData : System.IEquatable<Maple.Models.Templates.Mob.MobInteractionData>
    {
        public MobInteractionData(System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? ReviveIds = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? DamagedBySelectedMob = null, System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? DamagedBySelectedSkill = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSpeakEntry>? SpeakInfo = null, System.Collections.Generic.IReadOnlyDictionary<Maple.Enums.Element, int>? ElemBonus = null, int? FixedBodyAttackDamR = default) { }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? DamagedBySelectedMob { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? DamagedBySelectedSkill { get; init; }
        public System.Collections.Generic.IReadOnlyDictionary<Maple.Enums.Element, int>? ElemBonus { get; init; }
        public int? FixedBodyAttackDamR { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? ReviveIds { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSpeakEntry>? SpeakInfo { get; init; }
    }
    public sealed class MobMetadata : System.IEquatable<Maple.Models.Templates.Mob.MobMetadata>
    {
        public MobMetadata(
                    int? MonsterBookId = default,
                    Maple.Enums.MobSpecies? Species = default,
                    Maple.Enums.MobCategory? Category = default,
                    Maple.Enums.MobMoveAbility MoveAbility = 0,
                    int? ChaseSpeed = default,
                    int? PushedDamage = default,
                    Maple.StrongId.ItemTemplateId? WeaponId = default,
                    float? Fs = default,
                    Maple.Models.Common.ArgbColor? HpTagColor = default,
                    Maple.Models.Common.ArgbColor? HpTagBgColor = default,
                    int? ChargeCount = default,
                    int? DropItemPeriod = default,
                    Maple.Enums.MobBanType? BanType = default,
                    int? HitCount = default,
                    int? DieCount = default,
                    Maple.Enums.MobEscortType? EscortType = default,
                    Maple.Enums.ChatBalloonType? ChatBalloon = default) { }
        public Maple.Enums.MobBanType? BanType { get; init; }
        public Maple.Enums.MobCategory? Category { get; init; }
        public int? ChargeCount { get; init; }
        public int? ChaseSpeed { get; init; }
        public Maple.Enums.ChatBalloonType? ChatBalloon { get; init; }
        public int? DieCount { get; init; }
        public int? DropItemPeriod { get; init; }
        public Maple.Enums.MobEscortType? EscortType { get; init; }
        public float? Fs { get; init; }
        public int? HitCount { get; init; }
        public Maple.Models.Common.ArgbColor? HpTagBgColor { get; init; }
        public Maple.Models.Common.ArgbColor? HpTagColor { get; init; }
        public int? MonsterBookId { get; init; }
        public Maple.Enums.MobMoveAbility MoveAbility { get; init; }
        public int? PushedDamage { get; init; }
        public Maple.Enums.MobSpecies? Species { get; init; }
        public Maple.StrongId.ItemTemplateId? WeaponId { get; init; }
    }
    public sealed class MobSkillEntry : System.IEquatable<Maple.Models.Templates.Mob.MobSkillEntry>
    {
        public MobSkillEntry(Maple.StrongId.SkillTemplateId SkillId, int SkillLevel, int EffectAfterMs, int? CoolTime = default, Maple.Models.Templates.Mob.MobSkillLevelData? LevelData = null) { }
        public int? CoolTime { get; init; }
        public int EffectAfterMs { get; init; }
        public Maple.Models.Templates.Mob.MobSkillLevelData? LevelData { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
        public int SkillLevel { get; init; }
    }
    public sealed class MobSkillLevelData : System.IEquatable<Maple.Models.Templates.Mob.MobSkillLevelData>
    {
        public MobSkillLevelData(int HpBelow = 50, int ConMP = 0, int Interval = 0, int Duration = 0, int Prop = 100, int X = 0, int Y = 0, int Count = -1, bool Random = false, int Dir = 0, Maple.Enums.Element ElemAttr = 0, int NEffect = 0, int Limit = 0, Maple.Models.Templates.Map.MapRect? AffectedArea = default, System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? SummonMobIds = null) { }
        public Maple.Models.Templates.Map.MapRect? AffectedArea { get; init; }
        public int ConMP { get; init; }
        public int Count { get; init; }
        public int Dir { get; init; }
        public int Duration { get; init; }
        public Maple.Enums.Element ElemAttr { get; init; }
        public int HpBelow { get; init; }
        public int Interval { get; init; }
        public int Limit { get; init; }
        public int NEffect { get; init; }
        public int Prop { get; init; }
        public bool Random { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.MobTemplateId>? SummonMobIds { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public readonly struct MobSpeakCondition : System.IEquatable<Maple.Models.Templates.Mob.MobSpeakCondition>
    {
        public MobSpeakCondition(Maple.StrongId.QuestTemplateId? QuestId, int? RequiredState, Maple.StrongId.PetTemplateId? PetId) { }
        public Maple.StrongId.PetTemplateId? PetId { get; init; }
        public Maple.StrongId.QuestTemplateId? QuestId { get; init; }
        public int? RequiredState { get; init; }
    }
    public sealed class MobSpeakEntry : System.IEquatable<Maple.Models.Templates.Mob.MobSpeakEntry>
    {
        public MobSpeakEntry(Maple.Enums.MobActionType Action, int Hp, int Mp, int Prob, int Width, System.Collections.Generic.IReadOnlyList<string> Speech, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSpeakCondition>? Conditions = null) { }
        public Maple.Enums.MobActionType Action { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Mob.MobSpeakCondition>? Conditions { get; init; }
        public int Hp { get; init; }
        public int Mp { get; init; }
        public int Prob { get; init; }
        public System.Collections.Generic.IReadOnlyList<string> Speech { get; init; }
        public int Width { get; init; }
    }
    public sealed class MobTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Mob.MobTemplateEntry>
    {
        public MobTemplateEntry(int Id, string Name, Maple.Enums.MobCategory? CategoryId = default, Maple.Enums.MobMoveAbility? Type = default, Maple.StrongId.MobTemplateId? Link = default) { }
        public Maple.Enums.MobCategory? CategoryId { get; init; }
        public Maple.StrongId.MobTemplateId? Link { get; init; }
        public Maple.StrongId.MobTemplateId MobId { get; }
        public Maple.Enums.MobMoveAbility? Type { get; init; }
    }
    public readonly struct MonsterBookEntry : System.IEquatable<Maple.Models.Templates.Mob.MonsterBookEntry>
    {
        public MonsterBookEntry(string? Name, string? Description, string? Detail, string? Catch = null) { }
        public string? Catch { get; init; }
        public string? Description { get; init; }
        public string? Detail { get; init; }
        public string? Name { get; init; }
    }
    public sealed class TamingMobTemplateEntry : System.IEquatable<Maple.Models.Templates.Mob.TamingMobTemplateEntry>
    {
        public TamingMobTemplateEntry(Maple.StrongId.TamingMobTemplateId TamingMobId, string? Name, int Speed, int Jump, float Fs, int Swim, int Fatigue) { }
        public int Fatigue { get; init; }
        public float Fs { get; init; }
        public int Jump { get; init; }
        public string? Name { get; init; }
        public int Speed { get; init; }
        public int Swim { get; init; }
        public Maple.StrongId.TamingMobTemplateId TamingMobId { get; init; }
    }
}
namespace Maple.Models.Templates.Npc
{
    public readonly struct NpcActionSpeakEntry : System.IEquatable<Maple.Models.Templates.Npc.NpcActionSpeakEntry>
    {
        public NpcActionSpeakEntry(string Action, string Text, Maple.Enums.JobClass? JobCategory = default, Maple.StrongId.JobId? Job = default, Maple.StrongId.QuestTemplateId? SpeakQuestId = default) { }
        public string Action { get; init; }
        public Maple.StrongId.JobId? Job { get; init; }
        public Maple.Enums.JobClass? JobCategory { get; init; }
        public Maple.StrongId.QuestTemplateId? SpeakQuestId { get; init; }
        public string Text { get; init; }
    }
    public sealed class NpcBehaviorData : System.IEquatable<Maple.Models.Templates.Npc.NpcBehaviorData>
    {
        public NpcBehaviorData(bool CanMove, bool Float, bool Hide, bool HideName, bool Cash, bool TalkMouseOnly, bool DcMark, bool StoreBank, int TrunkGet, int TrunkPut, int Speed, Maple.Models.Templates.Map.MapRect? DcRange = default, System.Collections.Generic.IReadOnlyList<string>? SayLines = null) { }
        public bool CanMove { get; init; }
        public bool Cash { get; init; }
        public bool DcMark { get; init; }
        public Maple.Models.Templates.Map.MapRect? DcRange { get; init; }
        public bool Float { get; init; }
        public bool Hide { get; init; }
        public bool HideName { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? SayLines { get; init; }
        public int Speed { get; init; }
        public bool StoreBank { get; init; }
        public bool TalkMouseOnly { get; init; }
        public int TrunkGet { get; init; }
        public int TrunkPut { get; init; }
    }
    public sealed class NpcBroadcastData : System.IEquatable<Maple.Models.Templates.Npc.NpcBroadcastData>
    {
        public NpcBroadcastData(bool MapleTv = false, Maple.Models.Templates.Map.MapPoint? MapleTvMsgPos = default, Maple.Models.Templates.Map.MapPoint? MapleTvAdPos = default, Maple.StrongId.NpcTemplateId? ImitateId = default, bool ViewToLocalUser = false) { }
        public Maple.StrongId.NpcTemplateId? ImitateId { get; init; }
        public bool MapleTv { get; init; }
        public Maple.Models.Templates.Map.MapPoint? MapleTvAdPos { get; init; }
        public Maple.Models.Templates.Map.MapPoint? MapleTvMsgPos { get; init; }
        public bool ViewToLocalUser { get; init; }
    }
    public sealed class NpcConditionalEntry : System.IEquatable<Maple.Models.Templates.Npc.NpcConditionalEntry>
    {
        public NpcConditionalEntry(string NodeName, string? Action, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcQuestCondition>? QuestConditions = null, System.Collections.Generic.IReadOnlyList<string>? SpeakLines = null, Maple.Enums.Gender? Gender = default, bool IsHidden = false) { }
        public string? Action { get; init; }
        public Maple.Enums.Gender? Gender { get; init; }
        public bool IsHidden { get; init; }
        public string NodeName { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcQuestCondition>? QuestConditions { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? SpeakLines { get; init; }
    }
    public sealed class NpcInfoEntry : System.IEquatable<Maple.Models.Templates.Npc.NpcInfoEntry>
    {
        public NpcInfoEntry(Maple.Models.Templates.Npc.NpcBehaviorData behavior, Maple.Models.Templates.Npc.NpcBroadcastData broadcast, Maple.Models.Templates.Npc.NpcInteractionData interaction) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcActionSpeakEntry>? ActionSpeakLines { get; }
        public System.Collections.Generic.IReadOnlyList<string>? Actions { get; }
        public string? ActiveScript { get; }
        public Maple.Models.Templates.Npc.NpcBehaviorData Behavior { get; }
        public Maple.Models.Templates.Npc.NpcBroadcastData Broadcast { get; }
        public bool CanMove { get; }
        public bool Cash { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcConditionalEntry>? ConditionalActions { get; }
        public bool DcMark { get; }
        public Maple.Models.Templates.Map.MapRect? DcRange { get; }
        public System.Collections.Generic.IReadOnlyList<string>? DefaultDialogue { get; }
        public bool Float { get; }
        public bool HasShopAction { get; }
        public bool Hide { get; }
        public bool HideName { get; }
        public Maple.StrongId.NpcTemplateId? ImitateId { get; }
        public Maple.Models.Templates.Npc.NpcInteractionData Interaction { get; }
        public Maple.StrongId.NpcTemplateId? Link { get; }
        public bool MapleTv { get; }
        public Maple.Models.Templates.Map.MapPoint? MapleTvAdPos { get; }
        public Maple.Models.Templates.Map.MapPoint? MapleTvMsgPos { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcQuestDialogueLine>? QuestDialogues { get; }
        public System.Collections.Generic.IReadOnlyList<string>? SayLines { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcScriptEntry>? Scripts { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcShopEntry>? ShopItems { get; }
        public Maple.Enums.NpcSpecialActionType? SpecialAct { get; }
        public int Speed { get; }
        public bool StoreBank { get; }
        public bool TalkMouseOnly { get; }
        public int TrunkGet { get; }
        public int TrunkPut { get; }
        public bool ViewToLocalUser { get; }
    }
    public sealed class NpcInteractionData : System.IEquatable<Maple.Models.Templates.Npc.NpcInteractionData>
    {
        public NpcInteractionData(bool HasShopAction, string? ActiveScript, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcShopEntry>? ShopItems = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcScriptEntry>? Scripts = null, System.Collections.Generic.IReadOnlyList<string>? Actions = null, Maple.Enums.NpcSpecialActionType? SpecialAct = default, System.Collections.Generic.IReadOnlyList<string>? DefaultDialogue = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcQuestDialogueLine>? QuestDialogues = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcConditionalEntry>? ConditionalActions = null, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcActionSpeakEntry>? ActionSpeakLines = null, Maple.StrongId.NpcTemplateId? Link = default) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcActionSpeakEntry>? ActionSpeakLines { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? Actions { get; init; }
        public string? ActiveScript { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcConditionalEntry>? ConditionalActions { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? DefaultDialogue { get; init; }
        public bool HasShopAction { get; init; }
        public Maple.StrongId.NpcTemplateId? Link { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcQuestDialogueLine>? QuestDialogues { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcScriptEntry>? Scripts { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Npc.NpcShopEntry>? ShopItems { get; init; }
        public Maple.Enums.NpcSpecialActionType? SpecialAct { get; init; }
    }
    public readonly struct NpcQuestCondition : System.IEquatable<Maple.Models.Templates.Npc.NpcQuestCondition>
    {
        public NpcQuestCondition(Maple.StrongId.QuestTemplateId QuestId, Maple.Enums.QuestState State) { }
        public Maple.StrongId.QuestTemplateId QuestId { get; init; }
        public Maple.Enums.QuestState State { get; init; }
    }
    public readonly struct NpcQuestDialogueLine : System.IEquatable<Maple.Models.Templates.Npc.NpcQuestDialogueLine>
    {
        public NpcQuestDialogueLine(string Key, string Text) { }
        public string Key { get; init; }
        public string Text { get; init; }
    }
    public readonly struct NpcScriptEntry : System.IEquatable<Maple.Models.Templates.Npc.NpcScriptEntry>
    {
        public NpcScriptEntry(string Script, System.DateOnly StartDate, System.DateOnly EndDate, bool IsActive) { }
        public System.DateOnly EndDate { get; init; }
        public bool IsActive { get; init; }
        public string Script { get; init; }
        public System.DateOnly StartDate { get; init; }
    }
    public readonly struct NpcShopEntry : System.IEquatable<Maple.Models.Templates.Npc.NpcShopEntry>
    {
        public NpcShopEntry(Maple.StrongId.ItemTemplateId ItemId, int Price, int? Period = default, Maple.StrongId.ItemTemplateId? TokenItemId = default, int? TokenPrice = default, int? LimitPerDay = default, int? MaxPerSlot = default, int? Stock = default, bool NRunOut = false, Maple.StrongId.TamingMobTemplateId? TamingMob = default) { }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public int? LimitPerDay { get; init; }
        public int? MaxPerSlot { get; init; }
        public bool NRunOut { get; init; }
        public int? Period { get; init; }
        public int Price { get; init; }
        public int? Stock { get; init; }
        public Maple.StrongId.TamingMobTemplateId? TamingMob { get; init; }
        public Maple.StrongId.ItemTemplateId? TokenItemId { get; init; }
        public int? TokenPrice { get; init; }
    }
    public sealed class NpcTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Npc.NpcTemplateEntry>
    {
        public NpcTemplateEntry(int Id, string Name, string? FuncName = null) { }
        public string? FuncName { get; init; }
        public Maple.StrongId.NpcTemplateId NpcId { get; }
    }
}
namespace Maple.Models.Templates.Quest
{
    public readonly struct QuestItemReq : System.IEquatable<Maple.Models.Templates.Quest.QuestItemReq>
    {
        public QuestItemReq(Maple.StrongId.ItemTemplateId ItemId, int Count, bool IsStartReq = false, int? Order = default) { }
        public int Count { get; init; }
        public bool IsStartReq { get; init; }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public int? Order { get; init; }
    }
    public readonly struct QuestItemReward : System.IEquatable<Maple.Models.Templates.Quest.QuestItemReward>
    {
        public QuestItemReward(Maple.StrongId.ItemTemplateId ItemId, int Count, int Prop, int? Period = default, Maple.Enums.Gender? Gender = default, Maple.StrongId.JobId? JobFilter = default) { }
        public int Count { get; init; }
        public Maple.Enums.Gender? Gender { get; init; }
        public Maple.StrongId.ItemTemplateId ItemId { get; init; }
        public Maple.StrongId.JobId? JobFilter { get; init; }
        public int? Period { get; init; }
        public int Prop { get; init; }
    }
    public readonly struct QuestMobKill : System.IEquatable<Maple.Models.Templates.Quest.QuestMobKill>
    {
        public QuestMobKill(Maple.StrongId.MobTemplateId MobId, int Count) { }
        public int Count { get; init; }
        public Maple.StrongId.MobTemplateId MobId { get; init; }
    }
    public readonly struct QuestPrereqQuest : System.IEquatable<Maple.Models.Templates.Quest.QuestPrereqQuest>
    {
        public QuestPrereqQuest(Maple.StrongId.QuestTemplateId QuestId, Maple.Enums.QuestState RequiredState) { }
        public Maple.StrongId.QuestTemplateId QuestId { get; init; }
        public Maple.Enums.QuestState RequiredState { get; init; }
    }
    public sealed class QuestSayEntry : System.IEquatable<Maple.Models.Templates.Quest.QuestSayEntry>
    {
        public QuestSayEntry(System.Collections.Generic.IReadOnlyList<string>? StartLines, System.Collections.Generic.IReadOnlyList<string>? EndLines, Maple.StrongId.NpcTemplateId? StartNpcId = default, bool StartAsk = false, Maple.StrongId.NpcTemplateId? EndNpcId = default, bool EndAsk = false) { }
        public bool EndAsk { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? EndLines { get; init; }
        public Maple.StrongId.NpcTemplateId? EndNpcId { get; init; }
        public bool StartAsk { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? StartLines { get; init; }
        public Maple.StrongId.NpcTemplateId? StartNpcId { get; init; }
    }
    public readonly struct QuestSkillReq : System.IEquatable<Maple.Models.Templates.Quest.QuestSkillReq>
    {
        public QuestSkillReq(Maple.StrongId.SkillTemplateId SkillId, bool MustBeAcquired) { }
        public bool MustBeAcquired { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
    }
    public readonly struct QuestSkillReward : System.IEquatable<Maple.Models.Templates.Quest.QuestSkillReward>
    {
        public QuestSkillReward(Maple.StrongId.SkillTemplateId SkillId, int SkillLevel, int MasterLevel, Maple.StrongId.JobId? JobFilter = default) { }
        public Maple.StrongId.JobId? JobFilter { get; init; }
        public int MasterLevel { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
        public int SkillLevel { get; init; }
    }
    public readonly struct QuestSpReward : System.IEquatable<Maple.Models.Templates.Quest.QuestSpReward>
    {
        public QuestSpReward(Maple.StrongId.JobId? JobId, int Amount) { }
        public int Amount { get; init; }
        public Maple.StrongId.JobId? JobId { get; init; }
    }
    public readonly struct QuestStateChange : System.IEquatable<Maple.Models.Templates.Quest.QuestStateChange>
    {
        public QuestStateChange(Maple.StrongId.QuestTemplateId QuestId, Maple.Enums.QuestState State) { }
        public Maple.StrongId.QuestTemplateId QuestId { get; init; }
        public Maple.Enums.QuestState State { get; init; }
    }
    public sealed class QuestTemplateCompletionRequirements : System.IEquatable<Maple.Models.Templates.Quest.QuestTemplateCompletionRequirements>
    {
        public QuestTemplateCompletionRequirements() { }
        public bool AutoCancel { get; init; }
        public bool AutoComplete { get; init; }
        public bool AutoPreComplete { get; init; }
        public long? CompleteExpRequired { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReq>? CompleteItemReqs { get; init; }
        public long? CompleteMesoRequired { get; init; }
        public Maple.StrongId.NpcTemplateId? CompleteNpcId { get; init; }
        public string? CompleteQrInfo { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestMobKill>? MobKills { get; init; }
        public bool OneShot { get; init; }
        public int? TimeLimit { get; init; }
        public int? TimeLimit2 { get; init; }
    }
    public sealed class QuestTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Quest.QuestTemplateEntry>
    {
        public QuestTemplateEntry(int id, string name, Maple.Models.Templates.Quest.QuestTemplateMetadata? metadata = null, Maple.Models.Templates.Quest.QuestTemplateStartRequirements? startRequirements = null, Maple.Models.Templates.Quest.QuestTemplateCompletionRequirements? completionRequirements = null, Maple.Models.Templates.Quest.QuestTemplateRewardData? rewards = null) { }
        public int? ApReward { get; }
        public Maple.Enums.QuestArea? Area { get; }
        public bool AutoAccept { get; }
        public bool AutoCancel { get; }
        public bool AutoComplete { get; }
        public bool AutoPreComplete { get; }
        public bool AutoStart { get; }
        public bool Blocked { get; }
        public Maple.StrongId.ItemTemplateId? BuffItemId { get; }
        public long? CompleteExpRequired { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReq>? CompleteItemReqs { get; }
        public long? CompleteMesoRequired { get; }
        public Maple.StrongId.NpcTemplateId? CompleteNpcId { get; }
        public string? CompleteQrInfo { get; }
        public Maple.Models.Templates.Quest.QuestTemplateCompletionRequirements? CompletionRequirements { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Enums.QuestDayOfWeek>? DayOfWeek { get; }
        public string? DemandSummary { get; }
        public int? EndHour { get; }
        public long? Exp { get; }
        public int? FameRequired { get; }
        public int? FameReward { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId>? FieldEnterReqs { get; }
        public int? Interval { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReward>? ItemRewards { get; }
        public int? LvMax { get; }
        public int? LvMin { get; }
        public int? MedalCategory { get; }
        public long? Meso { get; }
        public Maple.Models.Templates.Quest.QuestTemplateMetadata? Metadata { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestMobKill>? MobKills { get; }
        public Maple.StrongId.QuestTemplateId? NextQuestId { get; }
        public string? NpcActKey { get; }
        public bool OneShot { get; }
        public int? Order { get; }
        public string? Parent { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestPrereqQuest>? PrereqQuests { get; }
        public string? QrInfoSet { get; }
        public Maple.StrongId.QuestTemplateId QuestId { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestStateChange>? QuestStateChanges { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.JobId>? RequiredJobs { get; }
        public Maple.StrongId.ItemTemplateId? RequiredPet { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSkillReq>? RequiredSkills { get; }
        public string? RewardSummary { get; }
        public Maple.Models.Templates.Quest.QuestTemplateRewardData? Rewards { get; }
        public Maple.StrongId.MobTemplateId? SelectedMob { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSkillReward>? SkillRewards { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSpReward>? SpRewards { get; }
        public int? StartHour { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReq>? StartItemReqs { get; }
        public Maple.StrongId.NpcTemplateId? StartNpcId { get; }
        public Maple.Models.Templates.Quest.QuestTemplateStartRequirements? StartRequirements { get; }
        public string? Summary { get; }
        public int? TamingMobLevelMin { get; }
        public int? TimeLimit { get; }
        public int? TimeLimit2 { get; }
        public Maple.StrongId.ItemTemplateId? ViewMedalItem { get; }
        public bool YellowMarker { get; }
    }
    public sealed class QuestTemplateMetadata : System.IEquatable<Maple.Models.Templates.Quest.QuestTemplateMetadata>
    {
        public QuestTemplateMetadata() { }
        public Maple.Enums.QuestArea? Area { get; init; }
        public bool Blocked { get; init; }
        public string? DemandSummary { get; init; }
        public int? MedalCategory { get; init; }
        public int? Order { get; init; }
        public string? Parent { get; init; }
        public string? RewardSummary { get; init; }
        public Maple.StrongId.MobTemplateId? SelectedMob { get; init; }
        public string? Summary { get; init; }
        public Maple.StrongId.ItemTemplateId? ViewMedalItem { get; init; }
        public bool YellowMarker { get; init; }
    }
    public sealed class QuestTemplateRewardData : System.IEquatable<Maple.Models.Templates.Quest.QuestTemplateRewardData>
    {
        public QuestTemplateRewardData() { }
        public int? ApReward { get; init; }
        public Maple.StrongId.ItemTemplateId? BuffItemId { get; init; }
        public long? Exp { get; init; }
        public int? FameReward { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReward>? ItemRewards { get; init; }
        public long? Meso { get; init; }
        public Maple.StrongId.QuestTemplateId? NextQuestId { get; init; }
        public string? NpcActKey { get; init; }
        public string? QrInfoSet { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestStateChange>? QuestStateChanges { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSkillReward>? SkillRewards { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSpReward>? SpRewards { get; init; }
    }
    public sealed class QuestTemplateStartRequirements : System.IEquatable<Maple.Models.Templates.Quest.QuestTemplateStartRequirements>
    {
        public QuestTemplateStartRequirements() { }
        public bool AutoAccept { get; init; }
        public bool AutoStart { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Enums.QuestDayOfWeek>? DayOfWeek { get; init; }
        public int? EndHour { get; init; }
        public int? FameRequired { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId>? FieldEnterReqs { get; init; }
        public int? Interval { get; init; }
        public int? LvMax { get; init; }
        public int? LvMin { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestPrereqQuest>? PrereqQuests { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.JobId>? RequiredJobs { get; init; }
        public Maple.StrongId.ItemTemplateId? RequiredPet { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestSkillReq>? RequiredSkills { get; init; }
        public int? StartHour { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Quest.QuestItemReq>? StartItemReqs { get; init; }
        public Maple.StrongId.NpcTemplateId? StartNpcId { get; init; }
        public int? TamingMobLevelMin { get; init; }
    }
}
namespace Maple.Models.Templates.Reactor
{
    public sealed class ReactorInfoEntry : System.IEquatable<Maple.Models.Templates.Reactor.ReactorInfoEntry>
    {
        public ReactorInfoEntry(int StateCount, bool CanMove, int Layer, bool NotHitable, bool ActivateByTouch, Maple.StrongId.QuestTemplateId? QuestId, Maple.StrongId.ReactorTemplateId? Link, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Reactor.ReactorStateInfo>? States = null, string? Action = null, bool RemoveInFieldSet = false) { }
        public string? Action { get; init; }
        public bool ActivateByTouch { get; init; }
        public bool CanMove { get; init; }
        public int Layer { get; init; }
        public Maple.StrongId.ReactorTemplateId? Link { get; init; }
        public bool NotHitable { get; init; }
        public Maple.StrongId.QuestTemplateId? QuestId { get; init; }
        public bool RemoveInFieldSet { get; init; }
        public int StateCount { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Reactor.ReactorStateInfo>? States { get; init; }
    }
    public sealed class ReactorStateEvent : System.IEquatable<Maple.Models.Templates.Reactor.ReactorStateEvent>
    {
        public ReactorStateEvent(Maple.Enums.ReactorEventType Type, System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? ActiveSkillIds, int NextState, Maple.Models.Templates.Map.MapRect? CheckArea = default, Maple.StrongId.ItemTemplateId? ItemId = default, int? ItemCount = default) { }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.SkillTemplateId>? ActiveSkillIds { get; init; }
        public Maple.Models.Templates.Map.MapRect? CheckArea { get; init; }
        public int? ItemCount { get; init; }
        public Maple.StrongId.ItemTemplateId? ItemId { get; init; }
        public int NextState { get; init; }
        public Maple.Enums.ReactorEventType Type { get; init; }
    }
    public sealed class ReactorStateInfo : System.IEquatable<Maple.Models.Templates.Reactor.ReactorStateInfo>
    {
        public ReactorStateInfo(int StateIndex, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Reactor.ReactorStateEvent> Events, bool Repeat = false) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Reactor.ReactorStateEvent> Events { get; init; }
        public bool Repeat { get; init; }
        public int StateIndex { get; init; }
    }
    public sealed class ReactorTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Reactor.ReactorTemplateEntry>
    {
        public ReactorTemplateEntry(int Id, string Name) { }
        public Maple.StrongId.ReactorTemplateId ReactorId { get; }
    }
}
namespace Maple.Models.Templates.SetItem
{
    public sealed class SetItemEffect : System.IEquatable<Maple.Models.Templates.SetItem.SetItemEffect>
    {
        public SetItemEffect(int PieceCount, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.SetItem.SetItemStatBonus> Stats) { }
        public int PieceCount { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.SetItem.SetItemStatBonus> Stats { get; init; }
    }
    public sealed class SetItemInfoEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.SetItem.SetItemInfoEntry>
    {
        public SetItemInfoEntry(int SetId, string Name, System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId> ItemIds, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.SetItem.SetItemEffect> Effects) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.SetItem.SetItemEffect> Effects { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.ItemTemplateId> ItemIds { get; init; }
        public int SetId { get; init; }
        public Maple.StrongId.SetItemTemplateId SetItemId { get; }
    }
    public readonly struct SetItemStatBonus : System.IEquatable<Maple.Models.Templates.SetItem.SetItemStatBonus>
    {
        public SetItemStatBonus(string Stat, int Value) { }
        public string Stat { get; init; }
        public int Value { get; init; }
    }
}
namespace Maple.Models.Templates.Skill
{
    public readonly struct GuildSkillLevelEntry : System.IEquatable<Maple.Models.Templates.Skill.GuildSkillLevelEntry>
    {
        public GuildSkillLevelEntry(int Level, int X, int Y, string? Effect) { }
        public string? Effect { get; init; }
        public int Level { get; init; }
        public int X { get; init; }
        public int Y { get; init; }
    }
    public sealed class GuildSkillTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Skill.GuildSkillTemplateEntry>
    {
        public GuildSkillTemplateEntry(int Id, string Name, int MaxLevel = 0, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.GuildSkillLevelEntry>? Levels = null) { }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.GuildSkillLevelEntry>? Levels { get; init; }
        public int MaxLevel { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; }
    }
    public readonly struct SkillAdditionPsd : System.IEquatable<Maple.Models.Templates.Skill.SkillAdditionPsd>
    {
        public SkillAdditionPsd(Maple.StrongId.SkillTemplateId TargetSkillId, int Cr = 0, int CdMin = 0, int Ar = 0, int DipR = 0, int PDamR = 0, int MDamR = 0, int ImpR = 0) { }
        public int Ar { get; init; }
        public int CdMin { get; init; }
        public int Cr { get; init; }
        public int DipR { get; init; }
        public int ImpR { get; init; }
        public int MDamR { get; init; }
        public int PDamR { get; init; }
        public Maple.StrongId.SkillTemplateId TargetSkillId { get; init; }
    }
    public sealed class SkillAnimationData : System.IEquatable<Maple.Models.Templates.Skill.SkillAnimationData>
    {
        public SkillAnimationData(
                    string? EffectUol = null,
                    string? ScreenEffectUol = null,
                    string? AffectedUol = null,
                    string? Affected0Uol = null,
                    string? SpecialAffectedUol = null,
                    string? PrepareUol = null,
                    string? KeyDownUol = null,
                    string? KeyDownEndUol = null,
                    string? HitRootUol = null,
                    System.Collections.Generic.IReadOnlyList<string>? HitUols = null,
                    string? BallUol = null,
                    string? FlipBallUol = null,
                    string? MobUol = null,
                    string? TileUol = null,
                    string? AfterimageUol = null,
                    string? SpecialUol = null,
                    string? SummonedUol = null,
                    string? FinishUol = null,
                    bool HasIconDisabled = false,
                    bool HasIcon = false,
                    bool HasIconMouseOver = false) { }
        public string? Affected0Uol { get; init; }
        public string? AffectedUol { get; init; }
        public string? AfterimageUol { get; init; }
        public string? BallUol { get; init; }
        public string? EffectUol { get; init; }
        public string? FinishUol { get; init; }
        public string? FlipBallUol { get; init; }
        public bool HasIcon { get; init; }
        public bool HasIconDisabled { get; init; }
        public bool HasIconMouseOver { get; init; }
        public string? HitRootUol { get; init; }
        public System.Collections.Generic.IReadOnlyList<string>? HitUols { get; init; }
        public string? KeyDownEndUol { get; init; }
        public string? KeyDownUol { get; init; }
        public string? MobUol { get; init; }
        public string? PrepareUol { get; init; }
        public string? ScreenEffectUol { get; init; }
        public string? SpecialAffectedUol { get; init; }
        public string? SpecialUol { get; init; }
        public string? SummonedUol { get; init; }
        public string? TileUol { get; init; }
    }
    public readonly struct SkillReqEntry : System.IEquatable<Maple.Models.Templates.Skill.SkillReqEntry>
    {
        public SkillReqEntry(Maple.StrongId.SkillTemplateId SkillId, int RequiredLevel) { }
        public int RequiredLevel { get; init; }
        public Maple.StrongId.SkillTemplateId SkillId { get; init; }
    }
    public sealed class SkillTemplateBehaviorData : System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateBehaviorData>
    {
        public SkillTemplateBehaviorData() { }
        public System.Collections.Generic.IReadOnlyList<string>? Actions { get; init; }
        public Maple.Models.Templates.Skill.SkillAnimationData? AnimationData { get; init; }
        public Maple.Enums.Element? AttackElemAttr { get; init; }
        public int? BallDelay { get; init; }
        public System.Collections.Generic.IReadOnlyDictionary<string, string>? CommonFormulas { get; init; }
        public bool ContinuousEffect { get; init; }
        public int? DelayFrame { get; init; }
        public string? ElemAttrStr { get; init; }
        public System.Collections.Generic.IReadOnlyList<int>? FinalAttackActionCodes { get; init; }
        public bool HasProjectile { get; init; }
        public int? HoldFrame { get; init; }
        public bool Invisible { get; init; }
        public bool KeydownEnd { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillTemplateLevel>? LevelStats { get; init; }
        public Maple.StrongId.MobTemplateId? MobCode { get; init; }
        public int? PrepareAction { get; init; }
        public int? PrepareTime { get; init; }
        public bool Psd { get; init; }
        public Maple.StrongId.SkillTemplateId? PsdSkillId { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillAdditionPsd>? PsdSkillOffsets { get; init; }
        public Maple.Enums.SkillSubType? SkillType { get; init; }
        public Maple.Enums.WeaponType? SubWeaponType { get; init; }
        public bool Summon { get; init; }
        public Maple.Enums.WeaponType? WeaponType { get; init; }
    }
    public sealed class SkillTemplateCostData : System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateCostData>
    {
        public SkillTemplateCostData() { }
        public bool CombatOrders { get; init; }
        public int? HpCon { get; init; }
        public Maple.StrongId.ItemTemplateId? ItemConsume { get; init; }
        public int? ItemConsumeCount { get; init; }
        public int? MoneyCon { get; init; }
        public int? MpCon { get; init; }
        public int? Speed { get; init; }
    }
    public sealed class SkillTemplateEntry : Maple.Models.Templates.TemplateCatalogEntry, System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateEntry>
    {
        public SkillTemplateEntry(int id, string name, Maple.Models.Templates.Skill.SkillTemplateMetadata? metadata = null, Maple.Models.Templates.Skill.SkillTemplateRequirements? requirements = null, Maple.Models.Templates.Skill.SkillTemplateBehaviorData? behavior = null, Maple.Models.Templates.Skill.SkillTemplateCostData? cost = null) { }
        public System.Collections.Generic.IReadOnlyList<string>? Actions { get; }
        public Maple.Models.Templates.Skill.SkillAnimationData? AnimationData { get; }
        public Maple.Enums.Element? AttackElemAttr { get; }
        public int? BallDelay { get; }
        public Maple.Models.Templates.Skill.SkillTemplateBehaviorData? Behavior { get; }
        public bool CombatOrders { get; }
        public System.Collections.Generic.IReadOnlyDictionary<string, string>? CommonFormulas { get; }
        public bool ContinuousEffect { get; }
        public Maple.Models.Templates.Skill.SkillTemplateCostData? Cost { get; }
        public int? DefaultMasterLevel { get; }
        public int? DelayFrame { get; }
        public string? ElemAttrStr { get; }
        public System.Collections.Generic.IReadOnlyList<int>? FinalAttackActionCodes { get; }
        public bool HasProjectile { get; }
        public string? Hint { get; }
        public int? HoldFrame { get; }
        public int? HpCon { get; }
        public bool Hyper { get; }
        public bool Invisible { get; }
        public Maple.StrongId.ItemTemplateId? ItemConsume { get; }
        public int? ItemConsumeCount { get; }
        public string? JobName { get; }
        public bool KeydownEnd { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillTemplateLevel>? LevelStats { get; }
        public int? MasterLevel { get; }
        public int MaxLevel { get; }
        public Maple.Models.Templates.Skill.SkillTemplateMetadata? Metadata { get; }
        public Maple.StrongId.MobTemplateId? MobCode { get; }
        public int? MoneyCon { get; }
        public int? MpCon { get; }
        public bool NotRemoved { get; }
        public int? PrepareAction { get; }
        public int? PrepareTime { get; }
        public bool Psd { get; }
        public Maple.StrongId.SkillTemplateId? PsdSkillId { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillAdditionPsd>? PsdSkillOffsets { get; }
        public bool PvpDisable { get; }
        public Maple.StrongId.JobId? ReqJob { get; }
        public int? ReqLevel { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillReqEntry>? RequiredSkills { get; }
        public Maple.Models.Templates.Skill.SkillTemplateRequirements? Requirements { get; }
        public Maple.StrongId.SkillTemplateId SkillId { get; }
        public Maple.Enums.SkillSubType? SkillType { get; }
        public int? Speed { get; }
        public Maple.Enums.WeaponType? SubWeaponType { get; }
        public bool Summon { get; }
        public bool TimeLimited { get; }
        public bool UpButtonDisabled { get; }
        public Maple.Enums.WeaponType? WeaponType { get; }
    }
    public sealed class SkillTemplateLevel
    {
        public SkillTemplateLevel(int Level, System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillTemplateStat> Stats) { }
        public int Level { get; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillTemplateStat> Stats { get; }
        public System.Collections.Generic.IReadOnlyDictionary<string, int> BuildStatLookup() { }
        public override bool Equals(object? obj) { }
        public override int GetHashCode() { }
    }
    public sealed class SkillTemplateMetadata : System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateMetadata>
    {
        public SkillTemplateMetadata() { }
        public string? Description { get; init; }
        public string? Hint { get; init; }
        public string? JobName { get; init; }
    }
    public sealed class SkillTemplateRequirements : System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateRequirements>
    {
        public SkillTemplateRequirements() { }
        public int? DefaultMasterLevel { get; init; }
        public bool Hyper { get; init; }
        public int? MasterLevel { get; init; }
        public int MaxLevel { get; init; }
        public bool NotRemoved { get; init; }
        public bool PvpDisable { get; init; }
        public Maple.StrongId.JobId? ReqJob { get; init; }
        public int? ReqLevel { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.Models.Templates.Skill.SkillReqEntry>? RequiredSkills { get; init; }
        public bool TimeLimited { get; init; }
        public bool UpButtonDisabled { get; init; }
    }
    public readonly struct SkillTemplateStat : System.IEquatable<Maple.Models.Templates.Skill.SkillTemplateStat>
    {
        public SkillTemplateStat(string Name, int Value) { }
        public string Name { get; init; }
        public int Value { get; init; }
    }
}
namespace Maple.Models.Templates
{
    public class TemplateCatalogEntry : System.IEquatable<Maple.Models.Templates.TemplateCatalogEntry>
    {
        public TemplateCatalogEntry(int Id, string Name, string? Description = null, string? Category = null) { }
        public string? Category { get; init; }
        public string? Description { get; init; }
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
namespace Maple.Models.Templates.WorldMap
{
    public readonly struct WorldMapLinkEntry : System.IEquatable<Maple.Models.Templates.WorldMap.WorldMapLinkEntry>
    {
        public WorldMapLinkEntry(string? ToolTip, string? LinkMap, string? LinkImg) { }
        public string? LinkImg { get; init; }
        public string? LinkMap { get; init; }
        public string? ToolTip { get; init; }
    }
    public readonly struct WorldMapPoint : System.IEquatable<Maple.Models.Templates.WorldMap.WorldMapPoint>
    {
        public WorldMapPoint(int Index, int SpotX, int SpotY, System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId> MapIds) { }
        public int Index { get; init; }
        public System.Collections.Generic.IReadOnlyList<Maple.StrongId.FieldTemplateId> MapIds { get; init; }
        public int SpotX { get; init; }
        public int SpotY { get; init; }
    }
}
namespace Maple.Models.Users
{
    public sealed class AccountInfo : System.IEquatable<Maple.Models.Users.AccountInfo>
    {
        public AccountInfo() { }
        public Maple.Enums.Gender? Gender { get; init; }
        public Maple.Enums.AccountGradeCode GradeCode { get; init; }
        public Maple.StrongId.AccountId Id { get; init; }
        public int MaplePoint { get; init; }
        public int NexonCash { get; init; }
        public string? PIN { get; init; }
        public int PrepaidNXCash { get; init; }
        public string? SPW { get; init; }
        public Maple.Enums.PrivateStatusFlag SubGradeCode { get; init; }
        public string Username { get; init; }
    }
    public sealed class IdentityInfo : System.IEquatable<Maple.Models.Users.IdentityInfo>
    {
        public IdentityInfo() { }
        public Maple.StrongId.AccountId Id { get; init; }
        [System.Text.Json.Serialization.JsonIgnore]
        public string Password { get; init; }
        public string Username { get; init; }
    }
}```
