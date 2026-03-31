namespace Maple.Models.Templates.Item;

/// <summary>
/// Equip-specific template data for an item that can be worn or enhanced.
/// </summary>
public sealed record ItemTemplateEquipData
{
    /// <summary>Base stat payload copied onto equip instances created from the template.</summary>
    public ItemTemplateStats? Stats { get; init; }

    /// <summary>Character requirements that must be satisfied before the equip can be worn.</summary>
    public ItemEquipRequirements? Requirements { get; init; }

    /// <summary>Economy and flag metadata associated with the equip template.</summary>
    public ItemEquipFlags? Flags { get; init; }

    /// <summary>Template-granted active or passive skills attached directly to the equip.</summary>
    public IReadOnlyList<ItemSkillEntry>? ItemSkills { get; init; }

    /// <summary>Elemental resistance adjustments granted by the equip template.</summary>
    public ItemEquipElementResist? ElementResist { get; init; }

    /// <summary>Deterministic level-up stat tables used by growth-enabled equips.</summary>
    public IReadOnlyList<ItemLevelInfo>? LevelInfos { get; init; }

    /// <summary>Randomized potential-style stat tables applied by growth or reroll systems.</summary>
    public IReadOnlyList<ItemLevelInfo>? RandomStatPotentials { get; init; }

    /// <summary>Skill bonuses unlocked or scaled by equip level progression.</summary>
    public IReadOnlyList<ItemSkillEntry>? SkillLevelBonuses { get; init; }

    /// <summary>Optional equip addition payload loaded from the template addition nodes.</summary>
    public ItemAdditionData? Addition { get; init; }
}
