using Maple.Enums;
using Maple.Models.Users.Stats;
using Maple.StrongId;

namespace Maple.Models.Users;

/// <summary>
/// Contract for the mutable runtime character aggregate.
/// Implemented by <see cref="Character"/>.
/// </summary>
public interface ICharacter
{
    /// <summary>Database primary key for this character row.</summary>
    int Id { get; set; }

    /// <summary>Owning account-world row identifier.</summary>
    int AccountWorldDataId { get; set; }

    /// <summary>Character display name.</summary>
    string Name { get; set; }

    /// <summary>Character gender (<c>nGender</c>): 0 = male, 1 = female.</summary>
    Gender Gender { get; set; }

    /// <summary>Skin color index (<c>nSkin</c>).</summary>
    SkinColor Skin { get; set; }

    /// <summary>Face item template identifier (<c>nFace</c>).</summary>
    ItemTemplateId Face { get; set; }

    /// <summary>Hair item template identifier (<c>nHair</c>).</summary>
    ItemTemplateId Hair { get; set; }

    /// <summary>Current level (<c>nLevel</c>); range 1–200.</summary>
    byte Level { get; set; }

    /// <summary>Main job identifier (<c>nJob</c>).</summary>
    Job Job { get; set; }

    /// <summary>Base strength stat (<c>nSTR</c>).</summary>
    short STR { get; set; }

    /// <summary>Base dexterity stat (<c>nDEX</c>).</summary>
    short DEX { get; set; }

    /// <summary>Base intelligence stat (<c>nINT</c>).</summary>
    short INT { get; set; }

    /// <summary>Base luck stat (<c>nLUK</c>).</summary>
    short LUK { get; set; }

    /// <summary>Current HP (<c>nHP</c>).</summary>
    int HP { get; set; }

    /// <summary>Maximum HP (<c>nMHP</c>).</summary>
    int MaxHP { get; set; }

    /// <summary>Current MP (<c>nMP</c>).</summary>
    int MP { get; set; }

    /// <summary>Maximum MP (<c>nMMP</c>).</summary>
    int MaxMP { get; set; }

    /// <summary>Remaining ability points to allocate (<c>nAP</c>).</summary>
    short AP { get; set; }

    /// <summary>Remaining skill points for single-advancement jobs (<c>nSP</c>).</summary>
    short SP { get; set; }

    /// <summary>Per-job-level SP pools for multi-advancement jobs.</summary>
    ICharacterExtendSP ExtendSP { get; }

    /// <summary>Accumulated experience towards next level (<c>nEXP</c>).</summary>
    int EXP { get; set; }

    /// <summary>Fame / popularity vote tally (<c>nPOP</c>).</summary>
    short POP { get; set; }

    /// <summary>Mesos carried by the character (<c>nMoney</c>).</summary>
    int Money { get; set; }

    /// <summary>Server-side temporary EXP buffer (<c>nTempEXP</c>).</summary>
    int TempEXP { get; set; }

    /// <summary>Current map (field) template identifier (<c>dwPosMap</c>).</summary>
    FieldTemplateId FieldId { get; set; }

    /// <summary>Spawn portal index within the current field (<c>nPortal</c>).</summary>
    byte FieldPortal { get; set; }

    /// <summary>Total accumulated play time in seconds (<c>nPlaytime</c>).</summary>
    int PlayTime { get; set; }

    /// <summary>Sub-job variant identifier (<c>nSubJob</c>).</summary>
    short SubJob { get; set; }

    /// <summary>Maximum friend-list capacity.</summary>
    byte FriendMax { get; set; }

    /// <summary>Function-key bindings.</summary>
    ICharacterFuncKeys FuncKeys { get; }

    /// <summary>Quick-slot bindings.</summary>
    ICharacterQuickslotKeys QuickslotKeys { get; }

    /// <summary>Wishlist entries.</summary>
    ICharacterWishlist Wishlist { get; }

    /// <summary>Typed inventory aggregate.</summary>
    ICharacterInventories Inventories { get; }

    /// <summary>Skill records.</summary>
    ICharacterSkills Skills { get; }

    /// <summary>Completed quest records.</summary>
    ICharacterQuestCompletes QuestCompletes { get; }

    /// <summary>Quest progress records.</summary>
    ICharacterQuestRecords QuestRecords { get; }

    /// <summary>Extended quest progress records.</summary>
    ICharacterQuestRecordsEx QuestRecordsEx { get; }

    /// <summary>Wild-hunter capture state.</summary>
    ICharacterWildHunterInfo WildHunterInfo { get; }

    /// <summary>Temporary stat state.</summary>
    ICharacterTemporaryStats TemporaryStats { get; }
}
