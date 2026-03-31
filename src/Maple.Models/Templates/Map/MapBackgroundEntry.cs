using Maple.Enums;

namespace Maple.Models.Templates.Map;

/// <summary>A parallax background/foreground layer entry.</summary>
/// <param name="No">Sprite index within the selected background set.</param>
/// <param name="BgSet">Background set name.</param>
/// <param name="BgType">Background tiling/scroll behavior type.</param>
/// <param name="IsFront">When true, layer is drawn in the foreground (above map objects); otherwise drawn in the background.</param>
/// <param name="IsAnimated">When true, uses an animated sub-image from the background set; otherwise uses a static sprite.</param>
/// <param name="X">World-space X position.</param>
/// <param name="Y">World-space Y position.</param>
/// <param name="Rx">Parallax X scroll rate.</param>
/// <param name="Ry">Parallax Y scroll rate.</param>
/// <param name="Cx">Horizontal tiling step in pixels.</param>
/// <param name="Cy">Vertical tiling step in pixels.</param>
/// <param name="Flip">When true, layer bitmap is flipped horizontally.</param>
/// <param name="Alpha">Opacity of the layer (0–255).</param>
/// <param name="Back">Background layer sort index; controls depth ordering within the background set.</param>
public sealed record MapBackgroundEntry(
    int No,
    string? BgSet,
    BackgroundType BgType,
    bool IsFront,
    bool IsAnimated,
    int X = 0,
    int Y = 0,
    int Rx = 0,
    int Ry = 0,
    int Cx = 0,
    int Cy = 0,
    bool Flip = false,
    byte Alpha = 255,
    int Back = 0
);
