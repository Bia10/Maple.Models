using Maple.Enums;
using Maple.Models.Items.Stats;
using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable equip item slot used by the editor and serialization layers.
/// Maps to <c>GW_ItemSlotEquip</c> (PDB), which inherits <c>GW_ItemSlotBase</c>
/// and embeds <c>GW_ItemSlotEquipBase</c> (stats) and <c>GW_ItemSlotEquipOpt</c> (potentials/sockets).
/// </summary>
/// <remarks>
/// The C++ struct also contains <c>ftEquipped</c> (<c>_FILETIME</c>) and <c>nPrevBonusExpRate</c> (int),
/// both of which are transient runtime state not tracked by the admin panel's data layer.
/// See <c>docs/item-slot-models.md</c> for the full field mapping and exclusion rationale.
/// </remarks>
public sealed class ItemSlotEquip : IItemSlotEquip
{
    /// <summary>
    /// Item template identifier (<c>GW_ItemSlotBase::nItemID</c>).
    /// Strongly typed to prevent raw-int confusion with other ID spaces.
    /// </summary>
    public ItemTemplateId TemplateId { get; set; }

    /// <summary>
    /// Cash shop transfer serial number (<c>GW_ItemSlotBase::liCashItemSN</c>).
    /// Non-null only when the item originated from a cash-shop purchase.
    /// Distinct from the inventory instance serial (<c>GW_ItemSlotEquip::liSN</c>), which is not persisted here.
    /// </summary>
    public long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp (<c>GW_ItemSlotBase::dateExpire</c>), or <see langword="null"/> when permanent.</summary>
    public DateTime? DateExpire { get; set; }

    /// <summary>
    /// Remaining Upgrade Count (<c>GW_ItemSlotEquipBase::nRUC</c>).
    /// Free scroll upgrade slots left; decremented on each scroll attempt (success or failure).
    /// Initial value comes from the WZ template field <c>tuc</c> (total upgrade count).
    /// </summary>
    public byte RUC { get; set; }

    /// <summary>
    /// Current Used Count — scroll upgrades already consumed (<c>GW_ItemSlotEquipBase::nCUC</c>).
    /// <c>RUC + CUC</c> equals the original total upgrade count from the WZ template.
    /// </summary>
    public byte CUC { get; set; }

    /// <summary>
    /// Core character-attribute bonuses (<c>GW_ItemSlotEquipBase::niSTR/niDEX/niINT/niLUK</c>);
    /// WZ keys <c>incSTR</c>, <c>incDEX</c>, <c>incINT</c>, <c>incLUK</c>.
    /// </summary>
    public CharacterBaseStats BaseStats { get; set; }

    /// <summary>
    /// Combat bonuses (<c>GW_ItemSlotEquipBase::niPAD/niMAD/niACC/niEVA</c>);
    /// WZ keys <c>incPAD</c>, <c>incMAD</c>, <c>incACC</c>, <c>incEVA</c>.
    /// </summary>
    public CombatStats Combat { get; set; }

    /// <summary>
    /// Defense bonuses (<c>GW_ItemSlotEquipBase::niPDD/niMDD</c>);
    /// WZ keys <c>incPDD</c>, <c>incMDD</c>.
    /// </summary>
    public DefenseStats Defense { get; set; }

    /// <summary>Maximum HP bonus (<c>GW_ItemSlotEquipBase::niMaxHP</c>); WZ key <c>incMHP</c>.</summary>
    public short MaxHP { get; set; }

    /// <summary>Maximum MP bonus (<c>GW_ItemSlotEquipBase::niMaxMP</c>); WZ key <c>incMMP</c>.</summary>
    public short MaxMP { get; set; }

    /// <summary>Craft / hands bonus (<c>GW_ItemSlotEquipBase::niCraft</c>); WZ key <c>incCraft</c>.</summary>
    public short Craft { get; set; }

    /// <summary>Move-speed bonus (<c>GW_ItemSlotEquipBase::niSpeed</c>); WZ key <c>incSpeed</c>.</summary>
    public short Speed { get; set; }

    /// <summary>Jump bonus (<c>GW_ItemSlotEquipBase::niJump</c>); WZ key <c>incJump</c>.</summary>
    public short Jump { get; set; }

    /// <summary>
    /// Custom title text embedded in the item instance (<c>GW_ItemSlotEquip::sTitle[13]</c>).
    /// Written by name-tag scrolls; <see langword="null"/> when the item has no custom title.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Item attribute bitfield (<c>GW_ItemSlotEquipBase::nAttribute</c>).
    /// Bit 0x01 = protected (item lock), 0x02 = prevent slip (anti-drop),
    /// 0x04 = warm support, 0x08 = account-bound, 0x10 = possible trading.
    /// </summary>
    public short Attribute { get; set; }

    /// <summary>
    /// Enhancement progression mode (<c>GW_ItemSlotEquipBase::nLevelUpType</c>).
    /// 0 = standard scroll enhancement, 1 = item XP growth (e.g. Evolving Ring), 2 = monster-badge growth.
    /// </summary>
    public byte LevelUpType { get; set; }

    /// <summary>
    /// Item enhancement level (<c>GW_ItemSlotEquipBase::nLevel</c>).
    /// Used both by scroll enhancement (regular equips) and XP growth (e.g. Evolving Ring).
    /// Valid range: 0–<see cref="MaxLevel"/> (200).
    /// Values above 200 are outside the game's design space and indicate corrupt or fabricated data.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when set to a value greater than <see cref="MaxLevel"/>.
    /// </exception>
    public byte Level
    {
        get => _level;
        set
        {
            if (value > MaxLevel)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    value,
                    $"Item enhancement level must be ≤ {MaxLevel}; received {value}."
                );
            _level = value;
        }
    }
    private byte _level;

    /// <summary>Maximum allowed item enhancement level.</summary>
    public const byte MaxLevel = 200;

    /// <summary>Accumulated item experience for XP-growth equips (<c>GW_ItemSlotEquipBase::nEXP</c>).</summary>
    public int EXP { get; set; }

    /// <summary>Remaining durability (<c>GW_ItemSlotEquipBase::nDurability</c>); <see langword="null"/> when the item has no durability mechanic.</summary>
    public int? Durability { get; set; }

    /// <summary>
    /// Item Upgrade Count — Vicious Hammer or Star Force applications (<c>GW_ItemSlotEquipBase::nIUC</c>).
    /// Incremented by each hammer use; tracked separately from <see cref="CHUC"/>.
    /// </summary>
    public int IUC { get; set; }

    /// <summary>Potential rank (grade) applied to the equip (<c>GW_ItemSlotEquipOpt::nGrade</c>); see <c>ItemGrade</c> enum.</summary>
    public ItemGrade Grade { get; set; }

    /// <summary>
    /// Chaos Hammer Upgrade Count (<c>GW_ItemSlotEquipOpt::nCHUC</c>).
    /// Number of Chaos / Star Force upgrades applied; tracked separately from regular <see cref="IUC"/>.
    /// </summary>
    public byte CHUC { get; set; }

    /// <summary>First potential line option identifier (<c>GW_ItemSlotEquipOpt::nOption1</c>); references <c>ItemOption.wz</c>.</summary>
    public short Option1 { get; set; }

    /// <summary>Second potential line option identifier (<c>GW_ItemSlotEquipOpt::nOption2</c>); references <c>ItemOption.wz</c>.</summary>
    public short Option2 { get; set; }

    /// <summary>Third potential line option identifier (<c>GW_ItemSlotEquipOpt::nOption3</c>); references <c>ItemOption.wz</c>.</summary>
    public short Option3 { get; set; }

    /// <summary>First socket option identifier (<c>GW_ItemSlotEquipOpt::nSocket1</c>); 0 when socket is empty or not unlocked.</summary>
    public short Socket1 { get; set; }

    /// <summary>Second socket option identifier (<c>GW_ItemSlotEquipOpt::nSocket2</c>); 0 when socket is empty or not unlocked.</summary>
    public short Socket2 { get; set; }

    /// <summary>
    /// Creates a detached copy of this equip slot.
    /// The copy remains shallow with respect to immutable values, but it avoids relying on
    /// <see cref="object.MemberwiseClone"/> so future ref-type fields must be copied explicitly.
    /// </summary>
    public ItemSlotEquip Clone() =>
        new()
        {
            TemplateId = TemplateId,
            CashItemSN = CashItemSN,
            DateExpire = DateExpire,
            RUC = RUC,
            CUC = CUC,
            BaseStats = BaseStats,
            Combat = Combat,
            Defense = Defense,
            MaxHP = MaxHP,
            MaxMP = MaxMP,
            Craft = Craft,
            Speed = Speed,
            Jump = Jump,
            Title = Title,
            Attribute = Attribute,
            LevelUpType = LevelUpType,
            Level = Level,
            EXP = EXP,
            Durability = Durability,
            IUC = IUC,
            Grade = Grade,
            CHUC = CHUC,
            Option1 = Option1,
            Option2 = Option2,
            Option3 = Option3,
            Socket1 = Socket1,
            Socket2 = Socket2,
        };
}
