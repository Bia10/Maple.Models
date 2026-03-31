namespace Maple.Models.Templates.Map;

/// <summary>
/// Ferry/travel timing for a single route leg.
/// All time values are in seconds.
/// </summary>
/// <param name="Id">Unique numeric identifier for the route leg.</param>
/// <param name="Name">Human-readable label for the route leg.</param>
/// <param name="ContinentId">Source continent identifier.</param>
/// <param name="DestId">Destination identifier for the route leg.</param>
/// <param name="TBoardBefore">Pre-boarding wait time in seconds.</param>
/// <param name="TBoardAfter">Post-boarding transition time in seconds.</param>
/// <param name="TMove">Travel time while the transport is in motion, in seconds.</param>
/// <param name="TIngame">In-game dwell time for the route leg, in seconds.</param>
/// <param name="TEventBefore">Pre-departure event duration in seconds.</param>
/// <param name="TEventAfter">Post-arrival event duration in seconds.</param>
public sealed record ContinentMoveRouteEntry(
    int Id,
    string Name,
    int ContinentId,
    int DestId,
    int TBoardBefore = 0,
    int TBoardAfter = 0,
    int TMove = 0,
    int TIngame = 0,
    int TEventBefore = 0,
    int TEventAfter = 0
) : TemplateCatalogEntry(Id, Name);
