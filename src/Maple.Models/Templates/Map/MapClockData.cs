namespace Maple.Models.Templates.Map;

/// <summary>Countdown clock widget data. Present on timed boss/event maps.</summary>
/// <param name="X">Clock widget X anchor coordinate.</param>
/// <param name="Y">Clock widget Y anchor coordinate.</param>
/// <param name="Width">Clock widget width in pixels.</param>
/// <param name="Height">Clock widget height in pixels.</param>
public readonly record struct MapClockData(int X, int Y, int Width, int Height);
