using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Properties for bridle/mount-capture items. Present on items that are used to capture a mob and obtain its mount.
/// </summary>
/// <param name="TargetMobId">Mob template ID that this bridle item targets for capture.</param>
/// <param name="CreateItemId">Item template obtained on successful capture.</param>
/// <param name="CreateItemPeriod">Lifespan of the created item, in days.</param>
/// <param name="CatchPercentageHp">Maximum target HP percentage threshold that allows capture.</param>
/// <param name="BridleProb">Base capture probability (0.0–1.0).</param>
/// <param name="BridleProbAdj">Adjusted capture probability.</param>
/// <param name="UseDelay">Cooldown in milliseconds between capture attempts.</param>
/// <param name="DelayMsg">Message shown while the item is on cooldown.</param>
/// <param name="NoMobMsg">Message shown when the target mob is not present in the field.</param>
public sealed record ItemBridleInfo(
    MobTemplateId TargetMobId,
    ItemTemplateId CreateItemId = default,
    int CreateItemPeriod = 0,
    int CatchPercentageHp = 0,
    float BridleProb = 0f,
    float BridleProbAdj = 0f,
    int UseDelay = 0,
    string? DelayMsg = null,
    string? NoMobMsg = null
);
