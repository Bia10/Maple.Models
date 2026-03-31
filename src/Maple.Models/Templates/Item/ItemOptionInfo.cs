using Maple.Enums;

namespace Maple.Models.Templates.Item;

/// <summary>Per-option-ID metadata describing a potential option type.</summary>
/// <param name="ReqLevel">Minimum item equip-level required before this option can appear on an item.</param>
/// <param name="OptionType">Discriminator controlling which stat group the option belongs to (e.g., offensive, defensive, utility).</param>
public readonly record struct ItemOptionInfo(int ReqLevel, ItemOptionType OptionType);
