using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>Skill grant from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="SkillId">Template ID of the skill granted or boosted by the addition.</param>
/// <param name="SkillLevel">Level at which the skill is granted; typically 1.</param>
public readonly record struct AdditionSkill(AdditionCondition? Condition, SkillTemplateId SkillId, int SkillLevel);
