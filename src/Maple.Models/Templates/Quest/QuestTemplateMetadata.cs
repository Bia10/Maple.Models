using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Quest;

/// <summary>
/// Descriptive and classification metadata for a quest template.
/// </summary>
public sealed record QuestTemplateMetadata
{
    /// <summary>Category grouping name (e.g., "Maple Island", "Victoria Island").</summary>
    public string? Parent { get; init; }

    /// <summary>Brief description shown in the quest info panel.</summary>
    public string? Summary { get; init; }

    /// <summary>Human-readable rewards summary text.</summary>
    public string? RewardSummary { get; init; }

    /// <summary>Human-readable requirements summary text.</summary>
    public string? DemandSummary { get; init; }

    /// <summary>Integer map area filter used by the quest UI and filtering logic.</summary>
    public QuestArea? Area { get; init; }

    /// <summary>Sort priority within the area category.</summary>
    public int? Order { get; init; }

    /// <summary>Target mob template ID highlighted by the quest metadata, if any.</summary>
    public MobTemplateId? SelectedMob { get; init; }

    /// <summary>Whether the quest is hidden from the quest log UI.</summary>
    public bool Blocked { get; init; }

    /// <summary>Presence = display the yellow quest exclamation marker.</summary>
    public bool YellowMarker { get; init; }

    /// <summary>Medal achievement category identifier referenced by medal-style quests.</summary>
    public int? MedalCategory { get; init; }

    /// <summary>Item template ID of the medal previewed by the quest, if any.</summary>
    public ItemTemplateId? ViewMedalItem { get; init; }
}
