namespace Maple.Models.Templates.Skill;

/// <summary>
/// Descriptive text and presentation metadata for a skill template.
/// </summary>
public sealed record SkillTemplateMetadata
{
    /// <summary>Long description text with stat placeholders resolved at the display layer.</summary>
    public string? Description { get; init; }

    /// <summary>Short hint or tooltip text; used in skill books and quick-info overlays.</summary>
    public string? Hint { get; init; }

    /// <summary>Job class name string (e.g. "Warrior"); used to group skills in browsers and catalog filters.</summary>
    public string? JobName { get; init; }
}
