namespace Maple.Models.Templates.Skill;

/// <summary>A named stat value extracted from a skill level definition.</summary>
/// <param name="Name">Stat key name.</param>
/// <param name="Value">Resolved integer value for this level.</param>
public readonly record struct SkillTemplateStat(string Name, int Value);
