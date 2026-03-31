using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Pet-related properties for bundle items that serve as pet items.
/// Present only when <see cref="ItemBundleInfo.PetData"/> is non-null — its presence is the canonical
/// signal that the item is a pet item.
/// Encapsulates the pet mob reference, hunger/lifecycle timers, locomotion flags, cosmetics,
/// and the ordered evolution chain.
/// </summary>
/// <param name="Pet">Mob template ID used as the pet's physical body.</param>
/// <param name="Life">Hunger timer; <see langword="null"/> when absent.</param>
/// <param name="Hungry">Hunger drain rate per tick.</param>
/// <param name="NoRevive">Whether the pet cannot be revived with mesos.</param>
/// <param name="NoMoveToLocker">Whether the pet cannot be stored in the character locker.</param>
/// <param name="NameTag">Cosmetic name-tag item identifier.</param>
/// <param name="ChatBalloon">Cosmetic chat-balloon item identifier.</param>
/// <param name="PickUpItem">Whether the pet automatically loots items.</param>
/// <param name="ConsumeHp">Whether the pet automatically uses HP potions.</param>
/// <param name="ConsumeMp">Whether the pet automatically uses MP potions.</param>
/// <param name="SweepForDrop">Whether the pet performs broad loot sweeps.</param>
/// <param name="LongRange">Whether the pet has extended pickup range.</param>
/// <param name="IgnorePickup">Whether the pet ignores generic loot.</param>
/// <param name="Recall">Whether the pet supports recall.</param>
/// <param name="AutoSpeaking">Whether the pet automatically shows chat bubbles.</param>
/// <param name="AutoReact">Whether the pet automatically reacts.</param>
/// <param name="InteractByUser">Whether the pet can be interacted with by user action.</param>
/// <param name="Evolutions">Ordered evolution chain entries for the pet.</param>
public sealed record ItemPetInfo(
    MobTemplateId Pet,
    int? Life = null,
    int? Hungry = null,
    bool NoRevive = false,
    bool NoMoveToLocker = false,
    ItemTemplateId? NameTag = null,
    ItemTemplateId? ChatBalloon = null,
    bool PickUpItem = false,
    bool ConsumeHp = false,
    bool ConsumeMp = false,
    bool SweepForDrop = false,
    bool LongRange = false,
    bool IgnorePickup = false,
    bool Recall = false,
    bool AutoSpeaking = false,
    bool AutoReact = false,
    bool InteractByUser = false,
    IReadOnlyList<PetEvolutionEntry>? Evolutions = null
);
