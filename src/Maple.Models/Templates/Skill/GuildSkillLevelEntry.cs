namespace Maple.Models.Templates.Skill;

/// <summary>One level of a guild skill.</summary>
/// <param name="Level">1-based level index for this entry.</param>
/// <param name="X">Primary numeric value for this level (HP recovery %, mob count, etc. — interpretation depends on the specific guild skill).</param>
/// <param name="Y">Secondary numeric value for this level (contextual meaning varies by skill).</param>
/// <param name="Effect">Special effect script name, if any.</param>
public readonly record struct GuildSkillLevelEntry(int Level, int X, int Y, string? Effect);
