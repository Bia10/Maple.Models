namespace Maple.Models.Templates.Map;

/// <summary>
/// A two-dimensional integer coordinate (pixel position in MapleStory's coordinate system).
/// Replaces anonymous <c>(int X, int Y)</c> tuples in public model APIs to improve clarity
/// and enable named-property access on nullable values without destructuring workarounds.
/// Positional record — supports <c>(var x, var y) = point</c> deconstruction.
/// </summary>
/// <param name="X">X coordinate.</param>
/// <param name="Y">Y coordinate.</param>
public readonly record struct MapPoint(int X, int Y)
{
    /// <summary>Returns the point formatted as <c>(X, Y)</c>.</summary>
    public override string ToString() => $"({X}, {Y})";
}
