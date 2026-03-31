using Maple.StrongId;

namespace Maple.Models.Templates.Reactor;

/// <summary>Basic reactor properties (loaded on-demand).</summary>
/// <param name="StateCount">Number of states defined by the reactor template; derived at runtime if absent.</param>
/// <param name="CanMove">Whether the reactor can move.</param>
/// <param name="Layer">Layer index for rendering z-order.</param>
/// <param name="NotHitable">Whether the reactor cannot be hit directly.</param>
/// <param name="ActivateByTouch">Whether touching the reactor activates it.</param>
/// <param name="QuestId">Quest template ID associated with the reactor.</param>
/// <param name="Link">Linked reactor template ID; the reactor resolves sprite data from the linked template.</param>
/// <param name="States">Parsed state entries from the reactor image's numbered state nodes.</param>
/// <param name="Action">Action identifier string for the reactor.</param>
/// <param name="RemoveInFieldSet">Whether the reactor is removed when the field set resets.</param>
public sealed record ReactorInfoEntry(
    int StateCount,
    bool CanMove,
    int Layer,
    bool NotHitable,
    bool ActivateByTouch,
    QuestTemplateId? QuestId,
    ReactorTemplateId? Link,
    IReadOnlyList<ReactorStateInfo>? States = null,
    string? Action = null,
    bool RemoveInFieldSet = false
);
