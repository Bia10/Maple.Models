using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>A skill requirement for starting a quest.</summary>
/// <param name="SkillId">Template ID of the required skill.</param>
/// <param name="MustBeAcquired">Whether the skill must already be learned (nonzero level required) rather than merely referenced.</param>
public readonly record struct QuestSkillReq(SkillTemplateId SkillId, bool MustBeAcquired);
