using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Mutable contract for pet item instances whose runtime state includes pet progression,
/// affection, life span, and pet-specific attribute flags.
/// </summary>
public interface IItemSlotPet : IItemSlotBase
{
    /// <summary>Strongly typed template identifier for the pet item.</summary>
    new ItemTemplateId TemplateId { get; set; }

    /// <summary>Cash shop serial number recorded for cash-origin pet items, when present.</summary>
    new long? CashItemSN { get; set; }

    /// <summary>Expiration timestamp for the pet item itself, or <see langword="null"/> when permanent.</summary>
    new DateTime? DateExpire { get; set; }

    /// <summary>Displayed pet name.</summary>
    string? PetName { get; set; }

    /// <summary>Current pet level.</summary>
    byte Level { get; set; }

    /// <summary>Accumulated pet tameness.</summary>
    short Tameness { get; set; }

    /// <summary>Current pet fullness / repleteness level.</summary>
    byte Repleteness { get; set; }

    /// <summary>Date when the pet died, if applicable.</summary>
    DateTime? DateDead { get; set; }

    /// <summary>Pet-specific attribute bitfield.</summary>
    short PetAttribute { get; set; }

    /// <summary>Pet skill bitfield or encoded pet skill state.</summary>
    short PetSkill { get; set; }

    /// <summary>Remaining pet life value.</summary>
    int RemainLife { get; set; }

    /// <summary>Raw item attribute bitfield stored with the pet item instance.</summary>
    short Attribute { get; set; }
}
