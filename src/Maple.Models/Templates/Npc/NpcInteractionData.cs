using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// Script, shop, dialogue, and special-action metadata for an NPC.
/// </summary>
/// <param name="HasShopAction">Whether the NPC has a shop interaction node.</param>
/// <param name="ActiveScript">The currently active time-gated script name, or null if none is active.</param>
/// <param name="ShopItems">Inventory entries for the NPC's shop; only present when <c>HasShopAction</c> is <see langword="true"/>.</param>
/// <param name="Scripts">Time-gated script entries with date ranges.</param>
/// <param name="Actions">Top-level animation action names.</param>
/// <param name="SpecialAct">Special interaction behaviour override code; absent = standard dialogue.</param>
/// <param name="DefaultDialogue">Default greeting dialogue lines read from numbered string sub-nodes.</param>
/// <param name="QuestDialogues">Quest-specific conditional dialogue lines.</param>
/// <param name="ConditionalActions">Conditional quest-driven behaviour branches.</param>
/// <param name="ActionSpeakLines">Per-action ambient dialogue strings.</param>
/// <param name="Link">NPC template ID whose image data is loaded in place of this NPC's own data for all action/dialogue resolution.</param>
public sealed record NpcInteractionData(
    bool HasShopAction,
    string? ActiveScript,
    IReadOnlyList<NpcShopEntry>? ShopItems = null,
    IReadOnlyList<NpcScriptEntry>? Scripts = null,
    IReadOnlyList<string>? Actions = null,
    NpcSpecialActionType? SpecialAct = null,
    IReadOnlyList<string>? DefaultDialogue = null,
    IReadOnlyList<NpcQuestDialogueLine>? QuestDialogues = null,
    IReadOnlyList<NpcConditionalEntry>? ConditionalActions = null,
    IReadOnlyList<NpcActionSpeakEntry>? ActionSpeakLines = null,
    NpcTemplateId? Link = null
);
