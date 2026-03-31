using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>A prerequisite skill requirement for learning or using another skill.</summary>
/// <param name="SkillId">Template ID of the prerequisite skill.</param>
/// <param name="RequiredLevel">Minimum level that must be achieved in the prerequisite skill.</param>
public readonly record struct SkillReqEntry(SkillTemplateId SkillId, int RequiredLevel);
