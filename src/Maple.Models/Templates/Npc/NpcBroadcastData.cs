using Maple.Models.Templates.Map;
using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// Maple TV and imitation broadcast metadata for an NPC.
/// </summary>
/// <param name="MapleTv">Whether this NPC is a Maple TV broadcast board (renders submitted messages).</param>
/// <param name="MapleTvMsgPos">Pixel offset for the Maple TV message text relative to the NPC.</param>
/// <param name="MapleTvAdPos">Pixel offset for the Maple TV advertisement banner relative to the NPC.</param>
/// <param name="ImitateId">NPC template ID whose avatar data this NPC clones; the server sends <c>OnNpcImitateData</c> packets with the impersonated avatar. <see langword="null"/> when absent.</param>
/// <param name="ViewToLocalUser">Internal/runtime flag, not a data key. When <see langword="true"/> the NPC is only visible to the local session user (used for instanced NPCs).</param>
public sealed record NpcBroadcastData(
    bool MapleTv = false,
    MapPoint? MapleTvMsgPos = null,
    MapPoint? MapleTvAdPos = null,
    NpcTemplateId? ImitateId = null,
    bool ViewToLocalUser = false
);
