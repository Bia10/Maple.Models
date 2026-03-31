using Maple.Enums;
using Maple.Models.Templates.Map;
using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// Behavioral properties for an NPC template,
/// loaded on-demand for the details popup.
/// </summary>
/// <remarks>
/// Payload properties (<see cref="Behavior"/>, <see cref="Broadcast"/>, <see cref="Interaction"/>) have no
/// <c>init</c> accessor — <c>with</c> expressions leave them unchanged.
/// Use the constructor directly when payload modifications are needed.
/// </remarks>
public sealed record NpcInfoEntry
{
    /// <summary>Creates an NPC info entry from grouped behavior, presentation, and interaction payloads.</summary>
    /// <param name="behavior">Core movement, visibility, and service behavior.</param>
    /// <param name="broadcast">Presentation and client-local display metadata.</param>
    /// <param name="interaction">Script, shop, dialogue, and special-action metadata.</param>
    public NpcInfoEntry(NpcBehaviorData behavior, NpcBroadcastData broadcast, NpcInteractionData interaction)
    {
        Behavior = behavior;
        Broadcast = broadcast;
        Interaction = interaction;
    }

    /// <summary>Gets the core movement, visibility, and service behavior.</summary>
    public NpcBehaviorData Behavior { get; }

    /// <summary>Gets the presentation and client-local display metadata.</summary>
    public NpcBroadcastData Broadcast { get; }

    /// <summary>Gets the script, shop, dialogue, and special-action metadata.</summary>
    public NpcInteractionData Interaction { get; }

    /// <summary>Gets whether the NPC can move.</summary>
    public bool CanMove => Behavior.CanMove;

    /// <summary>Gets whether the NPC uses floating movement.</summary>
    public bool Float => Behavior.Float;

    /// <summary>Gets whether the NPC starts hidden.</summary>
    public bool Hide => Behavior.Hide;

    /// <summary>Gets whether the NPC name is hidden.</summary>
    public bool HideName => Behavior.HideName;

    /// <summary>Gets whether the NPC is marked as cash-related.</summary>
    public bool Cash => Behavior.Cash;

    /// <summary>Gets whether the NPC only reacts to mouse-based interaction.</summary>
    public bool TalkMouseOnly => Behavior.TalkMouseOnly;

    /// <summary>Gets whether the NPC displays the DC mark indicator.</summary>
    public bool DcMark => Behavior.DcMark;

    /// <summary>Gets whether the NPC exposes storage or banking behavior.</summary>
    public bool StoreBank => Behavior.StoreBank;

    /// <summary>Gets the storage withdrawal fee or value configured for the NPC.</summary>
    public int TrunkGet => Behavior.TrunkGet;

    /// <summary>Gets the storage deposit fee or value configured for the NPC.</summary>
    public int TrunkPut => Behavior.TrunkPut;

    /// <summary>Gets the speed value.</summary>
    public int Speed => Behavior.Speed;

    /// <summary>Gets the distance-check range bounds.</summary>
    public MapRect? DcRange => Behavior.DcRange;

    /// <summary>Gets the default say-dialogue lines exposed by the NPC.</summary>
    public IReadOnlyList<string>? SayLines => Behavior.SayLines;

    /// <summary>Gets whether Maple TV behavior is enabled.</summary>
    public bool MapleTv => Broadcast.MapleTv;

    /// <summary>Gets the message position for Maple TV output.</summary>
    public MapPoint? MapleTvMsgPos => Broadcast.MapleTvMsgPos;

    /// <summary>Gets the advertisement position for Maple TV output.</summary>
    public MapPoint? MapleTvAdPos => Broadcast.MapleTvAdPos;

    /// <summary>Gets the NPC template ID that this NPC imitates, when present.</summary>
    public NpcTemplateId? ImitateId => Broadcast.ImitateId;

    /// <summary>Gets whether the NPC is shown only to the local user.</summary>
    public bool ViewToLocalUser => Broadcast.ViewToLocalUser;

    /// <summary>Gets whether the NPC exposes a dedicated shop action.</summary>
    public bool HasShopAction => Interaction.HasShopAction;

    /// <summary>Gets the active script identifier associated with the NPC.</summary>
    public string? ActiveScript => Interaction.ActiveScript;

    /// <summary>Gets the shop inventory entries exposed by the NPC.</summary>
    public IReadOnlyList<NpcShopEntry>? ShopItems => Interaction.ShopItems;

    /// <summary>Gets the time-gated script entries for the NPC.</summary>
    public IReadOnlyList<NpcScriptEntry>? Scripts => Interaction.Scripts;

    /// <summary>Gets the available animation action names.</summary>
    public IReadOnlyList<string>? Actions => Interaction.Actions;

    /// <summary>Gets the special interaction behavior override.</summary>
    public NpcSpecialActionType? SpecialAct => Interaction.SpecialAct;

    /// <summary>Gets the default greeting dialogue lines.</summary>
    public IReadOnlyList<string>? DefaultDialogue => Interaction.DefaultDialogue;

    /// <summary>Gets the quest-specific dialogue lines.</summary>
    public IReadOnlyList<NpcQuestDialogueLine>? QuestDialogues => Interaction.QuestDialogues;

    /// <summary>Gets the conditional quest-driven behavior branches.</summary>
    public IReadOnlyList<NpcConditionalEntry>? ConditionalActions => Interaction.ConditionalActions;

    /// <summary>Gets the per-action dialogue entries.</summary>
    public IReadOnlyList<NpcActionSpeakEntry>? ActionSpeakLines => Interaction.ActionSpeakLines;

    /// <summary>Gets the linked NPC template identifier.</summary>
    public NpcTemplateId? Link => Interaction.Link;
}
