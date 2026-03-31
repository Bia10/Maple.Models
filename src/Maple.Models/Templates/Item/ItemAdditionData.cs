namespace Maple.Models.Templates.Item;

/// <summary>Composite record holding all 7 optional equip addition bonus types.</summary>
/// <param name="Skill">Skill addition data.</param>
/// <param name="MobCategory">Mob-category addition data.</param>
/// <param name="ElemBoost">Elemental boost data.</param>
/// <param name="Critical">Critical-hit addition data.</param>
/// <param name="Boss">Boss-damage addition data.</param>
/// <param name="MobDie">On-mob-death addition data.</param>
/// <param name="HpMpChange">HP and MP change addition data.</param>
public readonly record struct ItemAdditionData(
    AdditionSkill? Skill = null,
    AdditionMobCategory? MobCategory = null,
    AdditionElemBoost? ElemBoost = null,
    AdditionCritical? Critical = null,
    AdditionBoss? Boss = null,
    AdditionMobDie? MobDie = null,
    AdditionHpMpChange? HpMpChange = null
);
