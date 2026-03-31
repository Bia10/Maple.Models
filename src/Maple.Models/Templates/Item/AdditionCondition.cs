using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>Activation condition for an equip addition bonus.</summary>
/// <param name="Level">Minimum character level required for the bonus to activate.</param>
/// <param name="Job">Job ID required for the bonus to activate; <see langword="null"/> = any job.</param>
/// <param name="Str">Minimum STR required for the bonus to activate.</param>
/// <param name="Dex">Minimum DEX required for the bonus to activate.</param>
/// <param name="Int">Minimum INT required for the bonus to activate.</param>
/// <param name="Luk">Minimum LUK required for the bonus to activate.</param>
/// <param name="Craft">Minimum crafting (diligence) stat required for the bonus to activate.</param>
/// <param name="ItemQuality">Minimum item-quality tier required.</param>
public readonly record struct AdditionCondition(
    int Level = 0,
    JobId? Job = null,
    int Str = 0,
    int Dex = 0,
    int Int = 0,
    int Luk = 0,
    int Craft = 0,
    int ItemQuality = -2
);
