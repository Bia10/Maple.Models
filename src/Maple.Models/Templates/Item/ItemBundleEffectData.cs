using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Direct in-field effects for bundle items.
/// The deeper buff specification lives in <see cref="ItemConsumeSpec"/>.
/// </summary>
/// <param name="Pad">Weapon ATK value (used on throwing stars and similar).</param>
/// <param name="IsMonsterBookCard">Whether the item is a Monster Book registration card.</param>
/// <param name="McType">Monster Carnival summon type; non-null only for MC summon items.</param>
/// <param name="Hp">Flat HP restored immediately on use.</param>
/// <param name="Mp">Flat MP restored immediately on use.</param>
/// <param name="HpR">HP restored as a percentage of max HP.</param>
/// <param name="MpR">MP restored as a percentage of max MP.</param>
/// <param name="HpQ">HP quantity recovered (alternative flat-HP field on some items).</param>
/// <param name="MpQ">MP quantity recovered (alternative flat-MP field on some items).</param>
/// <param name="Time">Effect or buff duration.</param>
/// <param name="Success">Scroll success chance.</param>
/// <param name="Cursed">Chance that the item is destroyed on scroll failure.</param>
/// <param name="Recover">Recovery value applied when the item is used.</param>
/// <param name="PreventSlip">Prevents the character from slipping when this item is active.</param>
/// <param name="BuffItemId">Item whose <c>spec/</c> node is used as the actual buff source instead of this item's own spec.</param>
/// <param name="MoveTo">Target field for warp/teleport items.</param>
/// <param name="Speed">Speed stat on the item (rare; mainly on speed-buff consumables).</param>
/// <param name="Jump">Jump stat on the item (rare; mainly on jump-buff consumables).</param>
/// <param name="Pdd">Physical defense stat on the item.</param>
public sealed record ItemBundleEffectData(
    int Pad = 0,
    bool IsMonsterBookCard = false,
    MonsterCarnivalMapType? McType = null,
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
    ItemTemplateId? BuffItemId = null,
    FieldTemplateId? MoveTo = null,
    int Speed = 0,
    int Jump = 0,
    int Pdd = 0
);
