namespace Maple.Models.Templates.Item;

/// <summary>
/// 56-field value type for per-level potential stat data.
/// Implemented as a <c>readonly record struct</c> so array storage is contiguous and inline,
/// avoiding one heap allocation per level entry across the entire item-option catalog.
/// </summary>
/// <param name="Prob">Probability value for the option to activate on this level.</param>
/// <param name="Time">Duration in seconds.</param>
/// <param name="IncStr">Flat STR bonus.</param>
/// <param name="IncDex">Flat DEX bonus.</param>
/// <param name="IncInt">Flat INT bonus.</param>
/// <param name="IncLuk">Flat LUK bonus.</param>
/// <param name="IncHp">Flat HP bonus.</param>
/// <param name="IncMp">Flat MP bonus.</param>
/// <param name="IncMhp">Flat maximum-HP bonus.</param>
/// <param name="IncMmp">Flat maximum-MP bonus.</param>
/// <param name="IncAcc">Flat accuracy bonus.</param>
/// <param name="IncEva">Flat evasion bonus.</param>
/// <param name="IncSpeed">Flat movement-speed bonus.</param>
/// <param name="IncJump">Flat jump bonus.</param>
/// <param name="IncPad">Flat physical-attack bonus.</param>
/// <param name="IncMad">Flat magic-attack bonus.</param>
/// <param name="IncPdd">Flat physical-defense bonus.</param>
/// <param name="IncMdd">Flat magic-defense bonus.</param>
/// <param name="IncStrR">Percent STR bonus.</param>
/// <param name="IncDexR">Percent DEX bonus.</param>
/// <param name="IncIntR">Percent INT bonus.</param>
/// <param name="IncLukR">Percent LUK bonus.</param>
/// <param name="IncMhpR">Percent maximum-HP bonus.</param>
/// <param name="IncMmpR">Percent maximum-MP bonus.</param>
/// <param name="IncAccR">Percent accuracy bonus.</param>
/// <param name="IncEvaR">Percent evasion bonus.</param>
/// <param name="IncPadR">Percent physical-attack bonus.</param>
/// <param name="IncMadR">Percent magic-attack bonus.</param>
/// <param name="IncPddR">Percent physical-defense bonus.</param>
/// <param name="IncMddR">Percent magic-defense bonus.</param>
/// <param name="IncCr">Critical-rate bonus.</param>
/// <param name="IncCDr">Critical-damage bonus.</param>
/// <param name="IncMamR">Additional damage modifier rate.</param>
/// <param name="IncSkill">Specific skill level bonus.</param>
/// <param name="IncAllSkill">All-skill-level bonus.</param>
/// <param name="RecoveryHp">HP recovery bonus.</param>
/// <param name="RecoveryMp">MP recovery bonus.</param>
/// <param name="RecoveryUp">Recovery-efficiency bonus.</param>
/// <param name="MpConReduce">MP-consumption reduction.</param>
/// <param name="MpConRestore">MP-consumption refund value.</param>
/// <param name="IgnoreTargetDef">Ignore-target-defense bonus.</param>
/// <param name="IgnoreDam">Damage-ignore flat value.</param>
/// <param name="IgnoreDamR">Damage-ignore rate.</param>
/// <param name="IncDamR">All-damage rate bonus.</param>
/// <param name="DamReflect">Damage-reflection bonus.</param>
/// <param name="AttackType">Attack-type code used by the option.</param>
/// <param name="IncMesoProb">Meso-drop probability bonus.</param>
/// <param name="IncRewardProb">Item-drop probability bonus.</param>
/// <param name="Level">Required or associated option level.</param>
/// <param name="Boss">Boss-damage addition value.</param>
/// <param name="EmotionAngry">Whether the angry emotion effect is enabled.</param>
/// <param name="EmotionCheer">Whether the cheer emotion effect is enabled.</param>
/// <param name="EmotionLove">Whether the love emotion effect is enabled.</param>
/// <param name="EmotionBlaze">Whether the blaze emotion effect is enabled.</param>
/// <param name="EmotionGlitter">Whether the glitter emotion effect is enabled.</param>
/// <param name="HasEmotion">Aggregate flag — <see langword="true"/> if any emotion field above is active.</param>
public readonly record struct ItemOptionLevelData(
    int Prob = 0,
    int Time = 0,
    // ── Flat stat bonuses ──
    int IncStr = 0,
    int IncDex = 0,
    int IncInt = 0,
    int IncLuk = 0,
    int IncHp = 0,
    int IncMp = 0,
    int IncMhp = 0,
    int IncMmp = 0,
    int IncAcc = 0,
    int IncEva = 0,
    int IncSpeed = 0,
    int IncJump = 0,
    int IncPad = 0,
    int IncMad = 0,
    int IncPdd = 0,
    int IncMdd = 0,
    // ── Percentage stat bonuses ──
    int IncStrR = 0,
    int IncDexR = 0,
    int IncIntR = 0,
    int IncLukR = 0,
    int IncMhpR = 0,
    int IncMmpR = 0,
    int IncAccR = 0,
    int IncEvaR = 0,
    int IncPadR = 0,
    int IncMadR = 0,
    int IncPddR = 0,
    int IncMddR = 0,
    // ── Rate-based fields ──
    int IncCr = 0,
    int IncCDr = 0,
    int IncMamR = 0,
    int IncSkill = 0,
    int IncAllSkill = 0,
    int RecoveryHp = 0,
    int RecoveryMp = 0,
    int RecoveryUp = 0,
    int MpConReduce = 0,
    int MpConRestore = 0,
    int IgnoreTargetDef = 0,
    int IgnoreDam = 0,
    int IgnoreDamR = 0,
    int IncDamR = 0,
    int DamReflect = 0,
    int AttackType = 0,
    int IncMesoProb = 0,
    int IncRewardProb = 0,
    int Level = 0,
    int Boss = 0,
    // ── Emotion flags ──
    bool EmotionAngry = false,
    bool EmotionCheer = false,
    bool EmotionLove = false,
    bool EmotionBlaze = false,
    bool EmotionGlitter = false,
    bool HasEmotion = false
);
