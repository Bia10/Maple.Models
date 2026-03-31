using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Passive stat offset for a target skill.
/// Implemented as a <c>readonly record struct</c>: all fields are value types and
/// instances are stored in lists, so inline array storage eliminates per-element heap allocations.
/// </summary>
/// <param name="TargetSkillId">Template ID of the skill that receives the passive offset.</param>
/// <param name="Cr">Critical-rate bonus points applied by this passive offset.</param>
/// <param name="CdMin">Minimum critical-damage floor bonus applied by this passive offset.</param>
/// <param name="Ar">Attack-rate bonus applied by this passive offset.</param>
/// <param name="DipR">Defense-ignore percentage rate bonus applied by this passive offset.</param>
/// <param name="PDamR">Physical-damage percentage bonus applied by this passive offset.</param>
/// <param name="MDamR">Magic-damage percentage bonus applied by this passive offset.</param>
/// <param name="ImpR">Status-application or impact-rate bonus applied by this passive offset.</param>
public readonly record struct SkillAdditionPsd(
    SkillTemplateId TargetSkillId,
    int Cr = 0,
    int CdMin = 0,
    int Ar = 0,
    int DipR = 0,
    int PDamR = 0,
    int MDamR = 0,
    int ImpR = 0
);
