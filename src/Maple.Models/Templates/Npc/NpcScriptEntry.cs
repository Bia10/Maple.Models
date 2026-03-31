namespace Maple.Models.Templates.Npc;

/// <summary>
/// A time-gated script entry for an NPC.
/// <see cref="IsActive"/> is true when today falls within [StartDate, EndDate].
/// </summary>
/// <param name="Script">Script name/identifier string.</param>
/// <param name="StartDate">Inclusive start date of the active window.</param>
/// <param name="EndDate">Inclusive end date of the active window.</param>
/// <param name="IsActive">Computed: true when today falls within [StartDate, EndDate]. Derived at load time.</param>
public readonly record struct NpcScriptEntry(string Script, DateOnly StartDate, DateOnly EndDate, bool IsActive);
