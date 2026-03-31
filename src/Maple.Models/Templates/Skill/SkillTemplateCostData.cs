using Maple.StrongId;

namespace Maple.Models.Templates.Skill;

/// <summary>
/// Resource costs and runtime modifiers associated with skill usage.
/// </summary>
public sealed record SkillTemplateCostData
{
    /// <summary>Skill charge/cast speed.</summary>
    public int? Speed { get; init; }

    /// <summary>Item consumed when the skill is used, if any.</summary>
    public ItemTemplateId? ItemConsume { get; init; }

    /// <summary>Quantity of <see cref="ItemConsume"/> consumed on use.</summary>
    public int? ItemConsumeCount { get; init; }

    /// <summary>Meso cost required to use the skill.</summary>
    public int? MoneyCon { get; init; }

    /// <summary>HP cost required to use the skill.</summary>
    public int? HpCon { get; init; }

    /// <summary>MP cost required to use the skill.</summary>
    public int? MpCon { get; init; }

    /// <summary>Gets whether the skill is affected by Combat Orders scaling rules.</summary>
    public bool CombatOrders { get; init; }
}
