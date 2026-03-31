namespace Maple.Models.Templates.Mob;

/// <summary>
/// Boolean behavioral and visibility flags for a mob.
/// </summary>
/// <param name="Boss">Whether the mob is marked as a boss.</param>
/// <param name="Undead">Whether the mob is flagged as undead (healed by dark magic, weak to holy).</param>
/// <param name="BodyAttack">Whether contact with the mob causes body damage.</param>
/// <param name="FirstAttack">Whether the mob initiates attacks proactively on sight.</param>
/// <param name="Invincible">Whether the mob is invincible to all damage.</param>
/// <param name="NotAttack">Whether the mob never performs attacks (used for environmental or decorative mobs).</param>
/// <param name="SelfDestruction">Whether the mob can self-destruct, dealing area damage.</param>
/// <param name="FirstSelfDestruction">Whether self-destruction can occur as the mob's first action.</param>
/// <param name="Chase">Whether the mob actively chases targets.</param>
/// <param name="Disable">Whether the mob is disabled (cannot be interacted with).</param>
/// <param name="NoFlip">Whether the sprite is prevented from flipping to face movement direction.</param>
/// <param name="DamagedByMob">Whether the mob can be damaged by other mobs.</param>
/// <param name="PickUpDrop">Whether the mob can pick up drops.</param>
/// <param name="HideHP">Whether the HP bar should be hidden.</param>
/// <param name="HideName">Whether the mob name is hidden above the HP bar.</param>
/// <param name="HideLevel">Whether the mob level should be hidden.</param>
/// <param name="AngerGauge">Whether the mob uses an anger-gauge mechanic.</param>
/// <param name="RegenAction">Whether the mob exposes a dedicated regeneration action.</param>
/// <param name="HPGaugeHide">Whether the HP gauge should be hidden (boss overlap indicator).</param>
/// <param name="OnlyNormalAttack">Whether only normal attacks are allowed on this mob.</param>
/// <param name="CantPassByTeleport">Whether teleport movement cannot pass through the mob.</param>
/// <param name="CannotEvade">Whether the mob is prevented from evading attacks.</param>
/// <param name="UpperMostLayer">Whether the mob is rendered on the upper-most layer.</param>
/// <param name="NoRegen">Disables natural HP recovery for the mob.</param>
public readonly record struct MobBehaviorFlags(
    bool Boss = false,
    bool Undead = false,
    bool BodyAttack = false,
    bool FirstAttack = false,
    bool Invincible = false,
    bool NotAttack = false,
    bool SelfDestruction = false,
    bool FirstSelfDestruction = false,
    bool Chase = false,
    bool Disable = false,
    bool NoFlip = false,
    bool DamagedByMob = false,
    bool PickUpDrop = false,
    bool HideHP = false,
    bool HideName = false,
    bool HideLevel = false,
    bool AngerGauge = false,
    bool RegenAction = false,
    bool HPGaugeHide = false,
    bool OnlyNormalAttack = false,
    bool CantPassByTeleport = false,
    bool CannotEvade = false,
    bool UpperMostLayer = false,
    bool NoRegen = false
);
