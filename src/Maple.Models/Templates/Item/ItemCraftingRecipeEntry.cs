using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>A crafting recipe entry from Maker or recipe template data.</summary>
/// <param name="RecipeId">Unique recipe identifier.</param>
/// <param name="ResultItemId">Template ID of the crafted result item.</param>
/// <param name="ResultCount">Quantity produced when the recipe succeeds.</param>
/// <param name="ReqLevel">Minimum character or crafting level required to use the recipe.</param>
/// <param name="ReqSkillId">Required crafting-related skill, if any.</param>
/// <param name="ReqSkillLevel">Minimum level of <paramref name="ReqSkillId"/> required to craft.</param>
/// <param name="ReqSkillProficiency">Required proficiency value for the recipe, if applicable.</param>
/// <param name="ReqMeso">Mesos consumed by the craft attempt.</param>
/// <param name="Ingredients">Ingredient list consumed by the recipe.</param>
/// <param name="ResultProb">Result probability; 0=guaranteed success, otherwise 1–100 or 1–10000 depending on format.</param>
public sealed record ItemCraftingRecipeEntry(
    int RecipeId,
    ItemTemplateId ResultItemId,
    int ResultCount,
    int ReqLevel = 0,
    SkillTemplateId ReqSkillId = default,
    int ReqSkillLevel = 0,
    int ReqSkillProficiency = 0,
    int ReqMeso = 0,
    IReadOnlyList<ItemCraftingIngredient>? Ingredients = null,
    int ResultProb = 0
);
