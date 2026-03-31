namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Canonical z-layer rendering order for character avatar compositing.
/// Defines the 36 named z-layers used for character avatar compositing.
/// Index 0 = backmost, Index 35 = frontmost.
/// </summary>
public static class CharacterZLayer
{
    /// <summary>Index of the face layer — split point for under/over compositing.</summary>
    public const int FaceSplitIndex = 21;

    /// <summary>
    /// Canonical z-layer rendering order. Index matches draw priority (0 = backmost).
    /// </summary>
    public static readonly IReadOnlyList<string> Layers =
    [
        "capeBackHead", // 0
        "capeBack", // 1
        "backDefault", // 2
        "weaponBelowBody", // 3
        "capeOverBody", // 4
        "pants", // 5
        "pantsOverShoes", // 6
        "shoeBelowPants", // 7
        "shoes", // 8
        "body", // 9
        "coat", // 10
        "armBelowHead", // 11
        "arm", // 12
        "armOverHead", // 13
        "handBelowWeapon", // 14
        "weapon", // 15
        "handOverWeapon", // 16
        "glove", // 17
        "weaponOverHand", // 18
        "gloveWrist", // 19
        "weaponOverGlove", // 20
        "face", // 21 ← split point
        "head", // 22
        "capeBelowHead", // 23
        "capeOverHead", // 24
        "accessoryEar", // 25
        "accessoryFace", // 26
        "accessoryEye", // 27
        "hair", // 28
        "hairBelowBody", // 29
        "hairBelowHead", // 30
        "hairBelowCap", // 31
        "hairOverHead", // 32
        "hairOverCap", // 33
        "capAttr", // 34
        "cap", // 35
    ];
}
