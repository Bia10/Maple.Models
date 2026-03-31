namespace Maple.Models.Templates.Item;

/// <summary>
/// Bundle-item payload for non-equip templates such as consumables, etc items, and cash items.
/// </summary>
public sealed record ItemTemplateBundleData
{
    /// <summary>Parsed bundle metadata for the non-equip item template.</summary>
    /// <remarks>
    /// Marked <c>required</c> because every bundle item unconditionally carries bundle metadata;
    /// a bundle payload without <see cref="ItemBundleInfo"/> is not a valid bundle.
    /// This differs from <see cref="ItemTemplateEquipData"/> where all sub-payloads are optional.
    /// </remarks>
    public required ItemBundleInfo BundleInfo { get; init; }
}
