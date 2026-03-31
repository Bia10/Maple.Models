using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>A single ingredient requirement within a crafting recipe.</summary>
/// <param name="ItemId">Template ID of the ingredient item.</param>
/// <param name="Count">Number of units required by the recipe.</param>
public readonly record struct ItemCraftingIngredient(ItemTemplateId ItemId, int Count);
