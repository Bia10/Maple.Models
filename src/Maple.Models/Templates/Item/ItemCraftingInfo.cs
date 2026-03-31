namespace Maple.Models.Templates.Item;

/// <summary>
/// Reverse crafting index for an item.
/// Tracks which recipes produce the item and which recipes consume it as an ingredient.
/// </summary>
/// <param name="ProducedBy">Recipes whose output yields this item.</param>
/// <param name="UsedIn">Recipes that consume this item as an ingredient.</param>
public sealed record ItemCraftingInfo(
    IReadOnlyList<ItemCraftingRecipeEntry> ProducedBy,
    IReadOnlyList<ItemCraftingRecipeEntry> UsedIn
);
