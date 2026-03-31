namespace Maple.Models.Templates.Item;

/// <summary>On-mob-kill HP/MP recovery bonus from an equip addition entry.</summary>
/// <param name="Condition">Activation condition that must be satisfied; <see langword="null"/> = unconditional.</param>
/// <param name="HpIncOnMobDie">Flat HP restored when a mob is killed.</param>
/// <param name="MpIncOnMobDie">Flat MP restored when a mob is killed.</param>
/// <param name="HpProp">Activation probability for the flat HP recovery; 100 = always.</param>
/// <param name="MpProp">Activation probability for the flat MP recovery; 100 = always.</param>
/// <param name="HpIncRatioOnMobDie">Percentage of max HP restored when a mob is killed.</param>
/// <param name="MpIncRatioOnMobDie">Percentage of max MP restored when a mob is killed.</param>
/// <param name="HpRatioProp">Activation probability for the percentage HP recovery.</param>
/// <param name="MpRatioProp">Activation probability for the percentage MP recovery.</param>
public readonly record struct AdditionMobDie(
    AdditionCondition? Condition,
    int HpIncOnMobDie = 0,
    int MpIncOnMobDie = 0,
    int HpProp = 100,
    int MpProp = 100,
    int HpIncRatioOnMobDie = 0,
    int MpIncRatioOnMobDie = 0,
    int HpRatioProp = 0,
    int MpRatioProp = 0
);
