using Maple.StrongId;

namespace Maple.Models.Templates.Item;

/// <summary>
/// Top-level item template entry.
/// Separates descriptive text, equip payload, and bundle payload so a template cannot
/// accidentally carry both equip-specific and bundle-specific state at the same time.
/// </summary>
/// <remarks>
/// Payload properties (<see cref="Text"/>, <see cref="Equip"/>, <see cref="Bundle"/>) have no
/// <c>init</c> accessor — <c>with</c> expressions leave them unchanged.
/// Use the constructor directly when payload modifications are needed.
/// </remarks>
public sealed record ItemTemplateEntry : TemplateCatalogEntry
{
    /// <summary>
    /// Creates an item template entry from grouped text, equip, and bundle payloads.
    /// </summary>
    /// <param name="id">Numeric item template identifier from the game data.</param>
    /// <param name="name">Localized item name.</param>
    /// <param name="text">Optional descriptive text and categorization metadata.</param>
    /// <param name="equip">Optional equip-specific payload.</param>
    /// <param name="bundle">Optional non-equip bundle payload.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when both <paramref name="equip"/> and <paramref name="bundle"/> are provided.
    /// </exception>
    public ItemTemplateEntry(
        int id,
        string name,
        ItemTemplateTextData? text = null,
        ItemTemplateEquipData? equip = null,
        ItemTemplateBundleData? bundle = null
    )
        : base(id, name, text?.Description, text?.Category)
    {
        if (equip is not null && bundle is not null)
            throw new ArgumentException(
                "An item template cannot be both an equip and a bundle at the same time.",
                nameof(bundle)
            );

        Text = text;
        Equip = equip;
        Bundle = bundle;
    }

    /// <summary>Typed wrapper for this entry's item template ID.</summary>
    public ItemTemplateId ItemId => new(Id);

    /// <summary>Grouped descriptive text and categorization metadata for the item template.</summary>
    public ItemTemplateTextData? Text { get; }

    /// <summary>Equip-specific payload when the template represents wearable gear.</summary>
    public ItemTemplateEquipData? Equip { get; }

    /// <summary>Bundle payload when the template represents a non-equip item.</summary>
    public ItemTemplateBundleData? Bundle { get; }

    /// <summary>Equip sub-category such as Cap or Cape.</summary>
    public string? SubCategory => Text?.SubCategory;

    /// <summary>Automatically generated description text from the source data.</summary>
    public string? AutoDesc => Text?.AutoDescription;

    /// <summary>Equip stat payload when the template represents wearable gear.</summary>
    public ItemTemplateStats? Stats => Equip?.Stats;

    /// <summary>Equip requirements when the template represents wearable gear.</summary>
    public ItemEquipRequirements? Requirements => Equip?.Requirements;

    /// <summary>Equip flag payload when the template represents wearable gear.</summary>
    public ItemEquipFlags? Flags => Equip?.Flags;

    /// <summary>Template-granted skills when the template represents wearable gear.</summary>
    public IReadOnlyList<ItemSkillEntry>? ItemSkills => Equip?.ItemSkills;

    /// <summary>Bundle payload when the template represents a non-equip item.</summary>
    public ItemBundleInfo? BundleInfo => Bundle?.BundleInfo;

    /// <summary>Elemental resistance payload for equip templates.</summary>
    public ItemEquipElementResist? ElementResist => Equip?.ElementResist;

    /// <summary>Level progression tables for growth-enabled equip templates.</summary>
    public IReadOnlyList<ItemLevelInfo>? LevelInfos => Equip?.LevelInfos;

    /// <summary>Randomized potential-style progression tables for equip templates.</summary>
    public IReadOnlyList<ItemLevelInfo>? RandomStatPotentials => Equip?.RandomStatPotentials;

    /// <summary>Level-based skill bonus entries for equip templates.</summary>
    public IReadOnlyList<ItemSkillEntry>? SkillLevelBonuses => Equip?.SkillLevelBonuses;

    /// <summary>Optional addition payload for equip templates.</summary>
    public ItemAdditionData? Addition => Equip?.Addition;

    /// <summary>Gets whether this entry carries equip-specific template data.</summary>
    public bool IsEquip => Equip is not null;

    /// <summary>Gets whether this entry carries bundle-specific template data.</summary>
    public bool IsBundle => Bundle is not null;
}
