using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Spawn, dialogue, and special-interaction metadata for a mob.
/// </summary>
/// <param name="ReviveIds">Mob templates spawned when this mob dies (revive chain).</param>
/// <param name="DamagedBySelectedMob">Mob templates that are allowed to damage this mob.</param>
/// <param name="DamagedBySelectedSkill">Skill templates allowed to damage this mob.</param>
/// <param name="SpeakInfo">Speak/chat-bubble entries for the mob.</param>
/// <param name="ElemBonus">Per-element bonus damage values keyed by element index.</param>
/// <param name="FixedBodyAttackDamR">Fixed body-attack damage-ratio override; bypasses normal damage formula when present.</param>
public sealed record MobInteractionData(
    IReadOnlyList<MobTemplateId>? ReviveIds = null,
    IReadOnlyList<MobTemplateId>? DamagedBySelectedMob = null,
    IReadOnlyList<SkillTemplateId>? DamagedBySelectedSkill = null,
    IReadOnlyList<MobSpeakEntry>? SpeakInfo = null,
    IReadOnlyDictionary<Element, int>? ElemBonus = null,
    int? FixedBodyAttackDamR = null
);
