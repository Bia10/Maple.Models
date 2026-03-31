namespace Maple.Models.Templates.Reactor;

/// <summary>All events for a single reactor state.</summary>
/// <param name="StateIndex">Zero-based index of this state within the reactor's state array.</param>
/// <param name="Events">All trigger events that can advance the reactor from this state.</param>
/// <param name="Repeat">When <see langword="true"/> the reactor loops back to this same state index after all events are consumed instead of advancing.</param>
public sealed record ReactorStateInfo(int StateIndex, IReadOnlyList<ReactorStateEvent> Events, bool Repeat = false);
