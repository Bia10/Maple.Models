using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// A skill entry assigned to a mob.
/// </summary>
/// <param name="SkillId">Template ID of the referenced mob skill.</param>
/// <param name="SkillLevel">Granted skill level.</param>
/// <param name="EffectAfterMs">Delay before the effect, in milliseconds.</param>
/// <param name="CoolTime">Cooldown in milliseconds.</param>
/// <param name="LevelData">Per-level mob skill data for this skill and level combination.</param>
public sealed record MobSkillEntry(
    SkillTemplateId SkillId,
    int SkillLevel,
    int EffectAfterMs,
    int? CoolTime = null,
    MobSkillLevelData? LevelData = null
);
