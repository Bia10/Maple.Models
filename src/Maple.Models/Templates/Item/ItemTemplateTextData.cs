namespace Maple.Models.Templates.Item;

/// <summary>
/// Descriptive text and categorization metadata attached to an item template.
/// </summary>
public sealed record ItemTemplateTextData
{
    /// <summary>Localized description shown for the item, if present.</summary>
    public string? Description { get; init; }

    /// <summary>Top-level category such as Equip, Consume, Install, or Etc.</summary>
    public string? Category { get; init; }

    /// <summary>Subtype within the top-level category, such as Cap or Cape for equips.</summary>
    public string? SubCategory { get; init; }

    /// <summary>Automatically generated supplemental description text from the source data.</summary>
    public string? AutoDescription { get; init; }
}
