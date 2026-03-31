using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>An item requirement for a quest phase; phase 0 = start check (items to hold), phase 1 = complete check (items consumed on turn-in).</summary>
/// <param name="ItemId">Template ID of the required item.</param>
/// <param name="Count">Number of items required.</param>
/// <param name="IsStartReq">True when the entry comes from phase 0 (start), false for phase 1 (complete).</param>
/// <param name="Order">Display/evaluation order within the requirement list.</param>
public readonly record struct QuestItemReq(
    ItemTemplateId ItemId,
    int Count,
    bool IsStartReq = false,
    int? Order = null
);
