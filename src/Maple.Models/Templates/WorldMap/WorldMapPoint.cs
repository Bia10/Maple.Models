using Maple.StrongId;

namespace Maple.Models.Templates.WorldMap;

/// <summary>A clickable world map point.</summary>
/// <param name="Index">Sequential index of this point within the world map.</param>
/// <param name="SpotX">X coordinate of the clickable spot.</param>
/// <param name="SpotY">Y coordinate of the clickable spot.</param>
/// <param name="MapIds">Field template IDs represented by this point.</param>
public readonly record struct WorldMapPoint(int Index, int SpotX, int SpotY, IReadOnlyList<FieldTemplateId> MapIds);
