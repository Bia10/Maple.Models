using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Progression and unlock requirements for a skill template.
/// </summary>
public sealed record SkillTemplateRequirements
{
    /// <summary>Maximum skill level available from the template.</summary>
    public int MaxLevel { get; init; }

    /// <summary>Maximum mastery level when the skill supports mastery books; distinct from <see cref="MaxLevel"/>.</summary>
    public int? MasterLevel { get; init; }

    /// <summary>Minimum character level required to learn or use the skill.</summary>
    public int? ReqLevel { get; init; }

    /// <summary>Optional job requirement.</summary>
    public JobId? ReqJob { get; init; }

    /// <summary>Required prerequisite skills and levels.</summary>
    public IReadOnlyList<SkillReqEntry>? RequiredSkills { get; init; }

    /// <summary>Default mastery level assigned when the skill is learned.</summary>
    public int? DefaultMasterLevel { get; init; }

    /// <summary>Gets whether the skill is marked as a hyper skill.</summary>
    public bool Hyper { get; init; }

    /// <summary>Gets whether the skill is disabled in PvP contexts.</summary>
    public bool PvpDisable { get; init; }

    /// <summary>Gets whether the up directional key input is disabled during skill usage (prevents jumping mid-animation).</summary>
    public bool UpButtonDisabled { get; init; }

    /// <summary>Gets whether the skill persists instead of being removed by normal cleanup flows.</summary>
    public bool NotRemoved { get; init; }

    /// <summary>Gets whether the skill is time-limited.</summary>
    public bool TimeLimited { get; init; }
}
