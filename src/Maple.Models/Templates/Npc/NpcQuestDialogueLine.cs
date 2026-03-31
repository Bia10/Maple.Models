namespace Maple.Models.Templates.Npc;

/// <summary>
/// A single quest-completion dialogue line paired with an NPC.
/// Replaces the anonymous <c>(string Key, string Text)</c> tuple in <see cref="NpcInfoEntry.QuestDialogues"/>.
/// Positional record — supports <c>(var key, var text) = line</c> deconstruction.
/// </summary>
/// <param name="Key">Dialogue key used to group or identify the line.</param>
/// <param name="Text">Dialogue text.</param>
public readonly record struct NpcQuestDialogueLine(string Key, string Text);
