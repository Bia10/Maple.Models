using Maple.Enums;
using Maple.Models.Templates.Map;
using Maple.StrongId;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// Per-level data for a mob skill.
/// </summary>
/// <param name="HpBelow">HP percentage threshold below which the skill becomes usable.</param>
/// <param name="ConMP">MP consumed when the skill fires.</param>
/// <param name="Interval">Reuse cooldown.</param>
/// <param name="Duration">Active duration of the skill effect.</param>
/// <param name="Prop">Activation probability.</param>
/// <param name="X">Generic integer parameter A; interpretation is skill-type-specific.</param>
/// <param name="Y">Generic integer parameter B; interpretation is skill-type-specific.</param>
/// <param name="Count">Target or summon count.</param>
/// <param name="Random">Whether targeting is randomised (true = random, false = nearest target).</param>
/// <param name="Dir">Directional constraint.</param>
/// <param name="ElemAttr">Elemental type of the skill's damage.</param>
/// <param name="NEffect">Effect-type code used to select the visual/audio effect played on activation.</param>
/// <param name="Limit">Usage or summon cap; meaning depends on skill type.</param>
/// <param name="AffectedArea">Rectangular area of effect, when defined.</param>
/// <param name="SummonMobIds">Mob template IDs summoned when the skill fires.</param>
public sealed record MobSkillLevelData(
    int HpBelow = 50,
    int ConMP = 0,
    int Interval = 0,
    int Duration = 0,
    int Prop = 100,
    int X = 0,
    int Y = 0,
    int Count = -1,
    bool Random = false,
    int Dir = 0,
    Element ElemAttr = default,
    int NEffect = 0,
    int Limit = 0,
    MapRect? AffectedArea = null,
    IReadOnlyList<MobTemplateId>? SummonMobIds = null
);
