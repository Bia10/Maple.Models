namespace Maple.Models.Templates.Map;

/// <summary>
/// An axis-aligned integer rectangle (pixel region in MapleStory's coordinate system),
/// stored as left/top/right/bottom edges.
/// Replaces anonymous <c>(int L, int T, int R, int B)</c> and
/// <c>(int Left, int Top, int Right, int Bottom)</c> tuples in public model APIs.
/// Positional record — supports <c>(var l, var t, var r, var b) = rect</c> deconstruction.
/// </summary>
/// <param name="Left">Left edge of the rectangle.</param>
/// <param name="Top">Top edge of the rectangle.</param>
/// <param name="Right">Right edge of the rectangle.</param>
/// <param name="Bottom">Bottom edge of the rectangle.</param>
public readonly record struct MapRect(int Left, int Top, int Right, int Bottom)
{
    /// <summary>Gets the rectangle width as <c>Right - Left</c>.</summary>
    public int Width => Right - Left;

    /// <summary>Gets the rectangle height as <c>Bottom - Top</c>.</summary>
    public int Height => Bottom - Top;

    /// <summary>Returns a compact edge-based string representation of the rectangle.</summary>
    public override string ToString() => $"L:{Left} T:{Top} R:{Right} B:{Bottom}";
}
