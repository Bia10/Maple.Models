using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable pet item slot for persisted pet inventory entries and editor workflows.
/// Maps to <c>GW_ItemSlotPet</c> (PDB), which inherits <c>GW_ItemSlotBase</c>.
/// </summary>
public sealed class ItemSlotPet : IItemSlotPet
{
    /// <summary>Pet item template identifier (<c>GW_ItemSlotBase::nItemID</c>).</summary>
    public ItemTemplateId TemplateId { get; set; }

    /// <summary>
    /// Cash shop transfer serial number (<c>GW_ItemSlotBase::liCashItemSN</c>).
    /// Non-null only when the pet item originated from a cash-shop purchase.
    /// </summary>
    public long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp for the pet item itself (<c>GW_ItemSlotBase::dateExpire</c>), or <see langword="null"/> when permanent.</summary>
    public DateTime? DateExpire { get; set; }

    /// <summary>Displayed pet name as entered by the player (<c>GW_ItemSlotPet::sPetName[13]</c>; max 12 chars + null).</summary>
    public string? PetName { get; set; }

    /// <summary>Current pet level (<c>GW_ItemSlotPet::nLevel</c>); increases with tameness gains.</summary>
    public byte Level { get; set; }

    /// <summary>Intimacy / tameness value (<c>GW_ItemSlotPet::nTameness</c>); range 0–30 000. Determines pet level.</summary>
    public short Tameness { get; set; }

    /// <summary>Satiation / fullness value (<c>GW_ItemSlotPet::nRepleteness</c>); range 0–100. Decreases over time; pet runs away at 0.</summary>
    public byte Repleteness { get; set; }

    /// <summary>Timestamp when the pet died / ran away (<c>GW_ItemSlotPet::dateDead</c>); <see langword="null"/> when the pet is alive.</summary>
    public DateTime? DateDead { get; set; }

    /// <summary>
    /// Pet-specific attribute bitfield (<c>GW_ItemSlotPet::nPetAttribute</c>).
    /// Bits control pet features such as auto-buff consumption and other toggleable behaviors.
    /// </summary>
    public short PetAttribute { get; set; }

    /// <summary>
    /// Encoded pet skill state (<c>GW_ItemSlotPet::usPetSkill</c>; unsigned short in C++).
    /// Stores which auto-use skills (HP food, MP food, etc.) have been taught to the pet.
    /// </summary>
    public short PetSkill { get; set; }

    /// <summary>Pet life counter remaining (<c>GW_ItemSlotPet::nRemainLife</c>); decrements while the pet is active.</summary>
    public int RemainLife { get; set; }

    /// <summary>
    /// Base item attribute bitfield (<c>GW_ItemSlotPet::nAttribute</c> — shared with other slot types).
    /// Bit 0x01 = protected (item lock), 0x02 = prevent slip, 0x04 = warm support,
    /// 0x08 = account-bound, 0x10 = possible trading.
    /// </summary>
    public short Attribute { get; set; }

    /// <summary>Creates a detached copy of this pet slot.</summary>
    public ItemSlotPet Clone() =>
        new()
        {
            TemplateId = TemplateId,
            CashItemSN = CashItemSN,
            DateExpire = DateExpire,
            PetName = PetName,
            Level = Level,
            Tameness = Tameness,
            Repleteness = Repleteness,
            DateDead = DateDead,
            PetAttribute = PetAttribute,
            PetSkill = PetSkill,
            RemainLife = RemainLife,
            Attribute = Attribute,
        };
}
