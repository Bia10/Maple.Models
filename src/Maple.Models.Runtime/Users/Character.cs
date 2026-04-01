using Maple.Enums;
using Maple.Models.Users.Stats;
using Maple.StrongId;

namespace Maple.Models.Users;

/// <summary>
/// Mutable runtime character aggregate with typed subsystem graphs.
/// Scalar fields map directly to <c>GW_CharacterStat</c> (PDB), with server-only
/// fields (e.g. <see cref="AccountWorldDataId"/>, <see cref="FriendMax"/>) added by Edelstein.
/// </summary>
/// <remarks>
/// <c>GW_CharacterStat</c> also contains <c>aliPetLockerSN[3]</c> (<c>LARGE_INTEGER[3]</c>),
/// the three active-pet slot instance serials. Those are not persisted here — the admin panel
/// exposes active-pet state through <see cref="Inventories"/> pet slots; the serials are
/// re-derived from session state rather than stored independently.
/// See <c>docs/runtime-character-models.md</c> for the full field mapping and exclusion rationale.
/// </remarks>
public sealed class Character : ICharacter
{
    /// <summary>Database primary key for this character row (server-side; not <c>dwCharacterID</c>).</summary>
    public int Id { get; set; }

    /// <summary>Owning account-world row identifier (server-side; not in <c>GW_CharacterStat</c>).</summary>
    public int AccountWorldDataId { get; set; }

    /// <summary>Character display name (<c>sCharacterName[13]</c> in <c>GW_CharacterStat</c>; max 12 chars + null).</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Character gender (<c>nGender</c>): 0 = male, 1 = female.</summary>
    public Gender Gender { get; set; }

    /// <summary>Skin color index (<c>nSkin</c>).</summary>
    public SkinColor Skin { get; set; }

    /// <summary>Face item template identifier (<c>nFace</c>).</summary>
    public ItemTemplateId Face { get; set; }

    /// <summary>Hair item template identifier (<c>nHair</c>).</summary>
    public ItemTemplateId Hair { get; set; }

    /// <summary>Current level (<c>nLevel</c>); unsigned byte, range 1–200.</summary>
    public byte Level { get; set; } = 1;

    /// <summary>Main job identifier (<c>nJob</c>).</summary>
    public Job Job { get; set; }

    /// <summary>Base strength stat (<c>nSTR</c>).</summary>
    public short STR { get; set; } = 4;

    /// <summary>Base dexterity stat (<c>nDEX</c>).</summary>
    public short DEX { get; set; } = 4;

    /// <summary>Base intelligence stat (<c>nINT</c>).</summary>
    public short INT { get; set; } = 4;

    /// <summary>Base luck stat (<c>nLUK</c>).</summary>
    public short LUK { get; set; } = 4;

    /// <summary>Current HP (<c>nHP</c>); enforced ≤ <see cref="MaxHP"/> by the server.</summary>
    public int HP { get; set; } = 50;

    /// <summary>Maximum HP (<c>nMHP</c>).</summary>
    public int MaxHP { get; set; } = 50;

    /// <summary>Current MP (<c>nMP</c>); enforced ≤ <see cref="MaxMP"/> by the server.</summary>
    public int MP { get; set; } = 50;

    /// <summary>Maximum MP (<c>nMMP</c>).</summary>
    public int MaxMP { get; set; } = 50;

    /// <summary>Remaining ability points to allocate (<c>nAP</c>).</summary>
    public short AP { get; set; }

    /// <summary>
    /// Remaining skill points for single-advancement jobs (<c>nSP</c>).
    /// Multi-advancement jobs (4th-job+) use <see cref="ExtendSP"/> instead.
    /// </summary>
    public short SP { get; set; }

    /// <summary>
    /// Per-job-level SP pool for multi-advancement jobs (<c>extendSP → SPSet.nSP</c>).
    /// Keyed by job advancement level (<c>SPSet.nJobLevel</c>).
    /// </summary>
    public CharacterExtendSP ExtendSP { get; set; } = new();

    /// <summary>Accumulated experience towards next level (<c>nEXP</c>).</summary>
    public int EXP { get; set; }

    /// <summary>Fame / popularity vote tally (<c>nPOP</c>).</summary>
    public short POP { get; set; }

    /// <summary>Mesos carried by the character (<c>nMoney</c>).</summary>
    public int Money { get; set; }

    /// <summary>
    /// Server-side temporary EXP buffer (<c>nTempEXP</c>).
    /// Accumulated during party/bonus EXP events; flushed into <see cref="EXP"/> on next level-up check.
    /// </summary>
    public int TempEXP { get; set; }

    /// <summary>Current map (field) template identifier (<c>dwPosMap</c>).</summary>
    public FieldTemplateId FieldId { get; set; }

    /// <summary>Spawn portal index within the current field (<c>nPortal</c>).</summary>
    public byte FieldPortal { get; set; }

    /// <summary>Total accumulated play time in seconds (<c>nPlaytime</c>).</summary>
    public int PlayTime { get; set; }

    /// <summary>
    /// Sub-job variant identifier (<c>nSubJob</c>).
    /// Non-zero for jobs that carry a secondary advancement path (e.g. Mihile).
    /// </summary>
    public short SubJob { get; set; }

    /// <summary>Maximum friend-list capacity (server-side; not in <c>GW_CharacterStat</c>).</summary>
    public byte FriendMax { get; set; } = 20;

    /// <summary>Function-key bindings.</summary>
    public CharacterFuncKeys FuncKeys { get; set; } = new();

    /// <summary>Quick-slot bindings.</summary>
    public CharacterQuickslotKeys QuickslotKeys { get; set; } = new();

    /// <summary>Wishlist entries.</summary>
    public CharacterWishlist Wishlist { get; set; } = new();

    /// <summary>Typed inventory aggregate.</summary>
    public CharacterInventories Inventories { get; set; } = CharacterInventories.CreateEmpty();

    /// <summary>Typed skill-record aggregate.</summary>
    public CharacterSkills Skills { get; set; } = new();

    /// <summary>Completed quest records.</summary>
    public CharacterQuestCompletes QuestCompletes { get; set; } = new();

    /// <summary>Quest progress records.</summary>
    public CharacterQuestRecords QuestRecords { get; set; } = new();

    /// <summary>Extended quest progress records.</summary>
    public CharacterQuestRecordsEx QuestRecordsEx { get; set; } = new();

    /// <summary>Wild-hunter capture state.</summary>
    public CharacterWildHunterInfo WildHunterInfo { get; set; } = new();

    /// <summary>Temporary stat state.</summary>
    public CharacterTemporaryStats TemporaryStats { get; set; } = new();

    // ── ICharacter explicit navigation property impls ──────────────────────
    ICharacterExtendSP ICharacter.ExtendSP => ExtendSP;
    ICharacterFuncKeys ICharacter.FuncKeys => FuncKeys;
    ICharacterQuickslotKeys ICharacter.QuickslotKeys => QuickslotKeys;
    ICharacterWishlist ICharacter.Wishlist => Wishlist;
    ICharacterInventories ICharacter.Inventories => Inventories;
    ICharacterSkills ICharacter.Skills => Skills;
    ICharacterQuestCompletes ICharacter.QuestCompletes => QuestCompletes;
    ICharacterQuestRecords ICharacter.QuestRecords => QuestRecords;
    ICharacterQuestRecordsEx ICharacter.QuestRecordsEx => QuestRecordsEx;
    ICharacterWildHunterInfo ICharacter.WildHunterInfo => WildHunterInfo;
    ICharacterTemporaryStats ICharacter.TemporaryStats => TemporaryStats;
}
