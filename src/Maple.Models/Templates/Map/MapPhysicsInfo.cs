namespace Maple.Models.Templates.Map;

/// <summary>
/// Per-map physics constant overrides.
/// <see cref="Fs"/> overrides the global friction scale; <see cref="Override"/>
/// supplies per-field physics constants that fall back to the global defaults from
/// <see cref="GlobalPhysicsEntry"/> when <see langword="null"/>.
/// </summary>
/// <param name="Fs">Global friction coefficient override for this map.</param>
/// <param name="Override">Per-map physics constants; <see langword="null"/> = all global defaults apply unchanged.</param>
public sealed record MapPhysicsInfo(float? Fs = null, GlobalPhysicsEntry? Override = null);
