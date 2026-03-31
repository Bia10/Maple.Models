namespace Maple.Models.Templates.Map;

/// <summary>
/// A single tile instance.
/// </summary>
/// <param name="X">Tile X coordinate.</param>
/// <param name="Y">Tile Y coordinate.</param>
/// <param name="TileSet">Tile-set name that selects the source atlas.</param>
/// <param name="U">Tile category within the atlas (e.g. <c>bsc</c>, <c>edD</c>, <c>enHa0</c>).</param>
/// <param name="No">Tile variant number within the category.</param>
/// <param name="ZM">Z-order modifier for sub-ordering tiles on the same layer.</param>
/// <param name="Layer">Layer index (0–7); derived from the enclosing node hierarchy.</param>
/// <param name="FlipH">Whether the tile is rendered flipped horizontally.</param>
public readonly record struct MapTileEntry(
    int X,
    int Y,
    string TileSet,
    string U,
    int No,
    int ZM,
    int Layer,
    bool FlipH = false
);
