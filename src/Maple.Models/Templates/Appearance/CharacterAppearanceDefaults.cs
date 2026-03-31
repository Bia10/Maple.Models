namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Built-in skin templates exposed by the MapleStory character creator.
/// Also centralizes the supported and reserved skin ID ranges used by validation logic.
/// </summary>
public static class CharacterAppearanceDefaults
{
    private const int BaseId = 2000;
    private const int MinId = 2000;
    private const int MaxId = 2011;

    /// <summary>Ordered list of supported built-in skin templates used by the editor UI.</summary>
    public static IReadOnlyList<SkinTemplateEntry> SkinEntries { get; } =
    [
        new(BaseId + 0, "Light"),
        new(BaseId + 1, "Tanned"),
        new(BaseId + 2, "Dark"),
        new(BaseId + 3, "Pale"),
        new(BaseId + 4, "Ghost"),
        new(BaseId + 5, "Green"),
        new(BaseId + 9, "White"),
        new(BaseId + 10, "Pink"),
        new(BaseId + 11, "Brown"),
    ];

    /// <summary>Returns whether the provided skin ID falls into the reserved gap within the base skin range.</summary>
    public static bool IsReservedSkinId(int skinId) => skinId is 2006 or 2007 or 2008;

    /// <summary>Returns whether the provided skin ID is within the supported built-in range and not reserved.</summary>
    public static bool IsSupportedSkinId(int skinId) => skinId is >= MinId and <= MaxId && !IsReservedSkinId(skinId);
}
