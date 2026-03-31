using Maple.Enums;

namespace Maple.Models.Templates.Mob;

/// <summary>
/// A speak/chat-bubble entry for a mob.
/// </summary>
/// <param name="Action">Action index during which this dialogue fires.</param>
/// <param name="Hp">HP-percentage threshold that triggers this speak entry.</param>
/// <param name="Mp">MP threshold that triggers this speak entry.</param>
/// <param name="Prob">Probability of the dialogue firing.</param>
/// <param name="Width">Chat balloon width in pixels.</param>
/// <param name="Speech">Dialogue lines for this entry.</param>
/// <param name="Conditions">Optional conditions that must be met for this entry to fire.</param>
public sealed record MobSpeakEntry(
    MobActionType Action,
    int Hp,
    int Mp,
    int Prob,
    int Width,
    IReadOnlyList<string> Speech,
    IReadOnlyList<MobSpeakCondition>? Conditions = null
);
