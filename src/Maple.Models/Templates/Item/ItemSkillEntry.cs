using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// A skill granted or required by an equip item.
/// </summary>
/// <param name="SkillId">Template ID of the granted skill.</param>
/// <param name="SkillLevel">Skill level granted or required.</param>
public readonly record struct ItemSkillEntry(SkillTemplateId SkillId, int SkillLevel);
