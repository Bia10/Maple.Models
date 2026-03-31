using Maple.StrongId;

namespace Maple.Models.Templates.Npc;

/// <summary>
/// Top-level NPC template catalog entry.
/// </summary>
/// <param name="Id">NPC template identifier.</param>
/// <param name="Name">NPC display name shown in name tag and minimap.</param>
/// <param name="FuncName">Functional category or role description shown in shop and interaction UI, if any.</param>
public sealed record NpcTemplateEntry(int Id, string Name, string? FuncName = null)
    : TemplateCatalogEntry(Id, Name, Category: FuncName)
{
    /// <summary>Typed wrapper for this entry's NPC template ID.</summary>
    public NpcTemplateId NpcId => new(Id);
}
