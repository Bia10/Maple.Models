using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Users;

/// <summary>
/// Persisted character snapshot with scalar fields plus JSON-serialised runtime subgraphs.
/// Scalar fields mirror <c>GW_CharacterStat</c> (PDB); server-only fields
/// (e.g. <see cref="AccountWorldDataId"/>, <see cref="FriendMax"/>) are added by Edelstein.
/// </summary>
public sealed record CharacterInfo
{
    /// <summary>Database primary key for this character row (server-side; not <c>dwCharacterID</c>).</summary>
    public int Id { get; init; }

    /// <summary>Owning account-world row identifier (server-side; not in <c>GW_CharacterStat</c>).</summary>
    public int AccountWorldDataId { get; init; }

    /// <summary>Character display name (<c>sCharacterName[13]</c> in <c>GW_CharacterStat</c>; max 12 chars + null).</summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>Character gender (<c>nGender</c>): 0 = male, 1 = female.</summary>
    public Gender Gender { get; init; }

    /// <summary>Skin color index (<c>nSkin</c>).</summary>
    public SkinColor Skin { get; init; }

    /// <summary>Face item template identifier (<c>nFace</c>).</summary>
    public ItemTemplateId Face { get; init; }

    /// <summary>Hair item template identifier (<c>nHair</c>).</summary>
    public ItemTemplateId Hair { get; init; }

    /// <summary>Current level (<c>nLevel</c>); unsigned byte, range 1–200.</summary>
    public byte Level { get; init; }

    /// <summary>Main job identifier (<c>nJob</c>).</summary>
    public Job Job { get; init; }

    /// <summary>Base strength stat (<c>nSTR</c>).</summary>
    public short STR { get; init; }

    /// <summary>Base dexterity stat (<c>nDEX</c>).</summary>
    public short DEX { get; init; }

    /// <summary>Base intelligence stat (<c>nINT</c>).</summary>
    public short INT { get; init; }

    /// <summary>Base luck stat (<c>nLUK</c>).</summary>
    public short LUK { get; init; }

    /// <summary>Current HP (<c>nHP</c>).</summary>
    public int HP { get; init; }

    /// <summary>Maximum HP (<c>nMHP</c>).</summary>
    public int MaxHP { get; init; }

    /// <summary>Current MP (<c>nMP</c>).</summary>
    public int MP { get; init; }

    /// <summary>Maximum MP (<c>nMMP</c>).</summary>
    public int MaxMP { get; init; }

    /// <summary>Remaining ability points to allocate (<c>nAP</c>).</summary>
    public short AP { get; init; }

    /// <summary>
    /// Remaining skill points for single-advancement jobs (<c>nSP</c>).
    /// Multi-advancement jobs use the serialised <see cref="ExtendSP"/> payload instead.
    /// </summary>
    public short SP { get; init; }

    /// <summary>Accumulated experience towards next level (<c>nEXP</c>).</summary>
    public int EXP { get; init; }

    /// <summary>Fame / popularity vote tally (<c>nPOP</c>).</summary>
    public short POP { get; init; }

    /// <summary>Mesos carried by the character (<c>nMoney</c>).</summary>
    public int Money { get; init; }

    /// <summary>
    /// Server-side temporary EXP buffer (<c>nTempEXP</c>).
    /// Accumulated during party/bonus EXP events; flushed into <see cref="EXP"/> on next level-up check.
    /// </summary>
    public int TempEXP { get; init; }

    /// <summary>Current map (field) template identifier (<c>dwPosMap</c>).</summary>
    public FieldTemplateId FieldId { get; init; }

    /// <summary>
    /// Spawn portal index within the current field (<c>nPortal</c>).
    /// Stored as <c>short</c> so that out-of-range values can be persisted and rejected by
    /// <see cref="CharacterSnapshotMapper.ToRuntime"/> rather than truncated silently.
    /// Valid runtime range is <c>0–255</c> (<see cref="byte"/>).
    /// </summary>
    public short FieldPortal { get; init; }

    /// <summary>Total accumulated play time in seconds (<c>nPlaytime</c>).</summary>
    public int PlayTime { get; init; }

    /// <summary>
    /// Sub-job variant identifier (<c>nSubJob</c>).
    /// Non-zero for jobs that carry a secondary advancement path (e.g. Mihile).
    /// </summary>
    public short SubJob { get; init; }

    /// <summary>Serialized inventory payload.</summary>
    public string Inventories { get; init; } = JsonDefaults.EmptyCharacterInventories;

    /// <summary>Serialized temporary-stat payload.</summary>
    public string TemporaryStats { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized skill record payload.</summary>
    public string Skills { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized function-key payload.</summary>
    public string FuncKeys { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized quick-slot payload.</summary>
    public string QuickslotKeys { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized completed-quest payload.</summary>
    public string QuestCompletes { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized quest-record payload.</summary>
    public string QuestRecords { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized extended quest-record payload.</summary>
    public string QuestRecordsEx { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized wishlist payload.</summary>
    public string Wishlist { get; init; } = JsonDefaults.EmptyArray;

    /// <summary>Serialized wild-hunter payload.</summary>
    public string WildHunterInfo { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Serialized extended skill-point payload.</summary>
    public string ExtendSP { get; init; } = JsonDefaults.EmptyObject;

    /// <summary>Maximum friend-list capacity (server-side; not in <c>GW_CharacterStat</c>).</summary>
    public byte FriendMax { get; init; } = 20;
}
