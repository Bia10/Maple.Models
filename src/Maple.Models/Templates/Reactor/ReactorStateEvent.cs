using Maple.Enums;
using Maple.Models.Templates.Map;
using Maple.StrongId;

namespace Maple.Models.Templates.Reactor;

/// <summary>A single trigger event within a reactor state.</summary>
/// <param name="Type">Event type.</param>
/// <param name="ActiveSkillIds">Skill IDs that activate this event.</param>
/// <param name="NextState">State index to transition to after this event fires.</param>
/// <param name="CheckArea">Optional spatial check area.</param>
/// <param name="ItemId">Item template ID required by this event (used by quest/item-hit triggers).</param>
/// <param name="ItemCount">Number of items required for the event trigger to fire.</param>
public sealed record ReactorStateEvent(
    ReactorEventType Type,
    IReadOnlyList<SkillTemplateId>? ActiveSkillIds,
    int NextState,
    MapRect? CheckArea = null,
    ItemTemplateId? ItemId = null,
    int? ItemCount = null
);
