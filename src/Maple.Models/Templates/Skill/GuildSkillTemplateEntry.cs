using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>Guild skill template entry.</summary>
/// <param name="Id">Template ID of the guild skill.</param>
/// <param name="Name">Display name shown in the guild skill UI.</param>
/// <param name="MaxLevel">Maximum level the guild can unlock for this skill.</param>
/// <param name="Levels">Per-level stat payloads.</param>
public sealed record GuildSkillTemplateEntry(
    int Id,
    string Name,
    int MaxLevel = 0,
    IReadOnlyList<GuildSkillLevelEntry>? Levels = null
) : TemplateCatalogEntry(Id, Name)
{
    /// <summary>Typed wrapper for this entry's guild skill template ID.</summary>
    public SkillTemplateId SkillId => new(Id);
}
