using Maple.Models.Templates.Map;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// Core movement, visibility, and service behavior for an NPC.
/// </summary>
/// <param name="CanMove">Whether the NPC can move from its spawn position.</param>
/// <param name="Float">Whether the NPC uses floating (non-ground) movement.</param>
/// <param name="Hide">Whether the NPC starts hidden and invisible on the map.</param>
/// <param name="HideName">Whether the NPC name tag is hidden.</param>
/// <param name="Cash">Whether the NPC is a cash shop or premium NPC.</param>
/// <param name="TalkMouseOnly">Whether the NPC only reacts to mouse-click interaction (not proximity key).</param>
/// <param name="DcMark">Whether the NPC displays the DC (disconnect) mark indicator.</param>
/// <param name="StoreBank">Whether the NPC exposes storage or banking behavior.</param>
/// <param name="TrunkGet">Storage withdrawal fee per transaction.</param>
/// <param name="TrunkPut">Storage deposit fee per transaction.</param>
/// <param name="Speed">NPC movement speed.</param>
/// <param name="DcRange">Bounding rect used for distance-check interaction range.</param>
/// <param name="SayLines">Default ambient dialogue lines displayed without player interaction.</param>
public sealed record NpcBehaviorData(
    bool CanMove,
    bool Float,
    bool Hide,
    bool HideName,
    bool Cash,
    bool TalkMouseOnly,
    bool DcMark,
    bool StoreBank,
    int TrunkGet,
    int TrunkPut,
    int Speed,
    MapRect? DcRange = null,
    IReadOnlyList<string>? SayLines = null
);
