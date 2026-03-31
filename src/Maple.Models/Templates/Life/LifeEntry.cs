using Maple.Enums;
using Maple.StrongId;

namespace Maple.Models.Templates.Life;

/// <summary>
/// A single life (NPC or mob) spawn entry in a map.
/// The <see cref="Type"/> discriminator determines whether <see cref="RawTemplateId"/>
/// refers to an NPC template or a mob template.
/// </summary>
/// <param name="Index">Ordinal position of this entry within the map's life list.</param>
/// <param name="Type">Whether this entry is an NPC or a mob spawn.</param>
/// <param name="RawTemplateId">7-digit template ID (e.g. 1000000 for Snail). Underlying template identifier before it is projected to a typed NPC or mob ID.</param>
/// <param name="X">spawn X coordinate in map pixels.</param>
/// <param name="Y">spawn Y coordinate in map pixels.</param>
/// <param name="Foothold">foothold segment ID the life spawns anchored to.</param>
/// <param name="CeilingY">ceiling Y constraint used to cap the vertical spawn position.</param>
/// <param name="RoamXMin">minimum X boundary for the mob's patrol/roaming range.</param>
/// <param name="RoamXMax">maximum X boundary for the mob's patrol/roaming range.</param>
/// <param name="FaceDirection">Initial facing direction.</param>
/// <param name="Hide">when <c>true</c>, the spawn starts hidden and must be triggered by a script.</param>
/// <param name="RespawnSeconds">respawn delay in seconds after the mob dies.</param>
/// <param name="Team">team assignment for Monster Carnival PvP maps. <c>null</c> when not a carnival map.</param>
public sealed record LifeEntry(
    int Index,
    LifeType Type,
    int RawTemplateId,
    int X,
    int Y,
    int Foothold,
    int CeilingY,
    int RoamXMin,
    int RoamXMax,
    int FaceDirection,
    bool Hide,
    int? RespawnSeconds,
    int? Team
)
{
    /// <summary>Gets whether this entry points at an NPC template.</summary>
    public bool IsNpc => Type == LifeType.Npc;

    /// <summary>Gets whether this entry points at a mob template.</summary>
    public bool IsMob => Type == LifeType.Mob;

    /// <summary>
    /// Gets the raw template identifier stored in the map data.
    /// Prefer <see cref="NpcId"/> or <see cref="MobId"/> (nullable StrongId) when the type is known,
    /// or <see cref="TryGetNpcId"/> / <see cref="TryGetMobId"/> for the try-pattern.
    /// </summary>
    [Obsolete(
        "TemplateId exposes a raw int with no type context. Use NpcId or MobId (nullable) for safe access, or TryGetNpcId / TryGetMobId for the try-pattern.",
        DiagnosticId = "MAPLE001"
    )]
    public int TemplateId => RawTemplateId;

    /// <summary>Creates an NPC life entry from a typed NPC template ID.</summary>
    public static LifeEntry CreateNpc(
        int index,
        NpcTemplateId npcId,
        int x,
        int y,
        int foothold,
        int ceilingY,
        int roamXMin,
        int roamXMax,
        int faceDirection,
        bool hide,
        int? respawnSeconds,
        int? team
    ) =>
        new(
            index,
            LifeType.Npc,
            npcId.Value,
            x,
            y,
            foothold,
            ceilingY,
            roamXMin,
            roamXMax,
            faceDirection,
            hide,
            respawnSeconds,
            team
        );

    /// <summary>Creates a mob life entry from a typed mob template ID.</summary>
    public static LifeEntry CreateMob(
        int index,
        MobTemplateId mobId,
        int x,
        int y,
        int foothold,
        int ceilingY,
        int roamXMin,
        int roamXMax,
        int faceDirection,
        bool hide,
        int? respawnSeconds,
        int? team
    ) =>
        new(
            index,
            LifeType.Mob,
            mobId.Value,
            x,
            y,
            foothold,
            ceilingY,
            roamXMin,
            roamXMax,
            faceDirection,
            hide,
            respawnSeconds,
            team
        );

    /// <summary>
    /// Returns this entry's template ID as a mob template ID.
    /// Throws when the life entry does not represent a mob.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown when <see cref="Type"/> is not <see cref="LifeType.Mob"/>.
    /// </exception>
    public MobTemplateId AsMob =>
        TryGetMobId(out MobTemplateId mobId)
            ? mobId
            : throw new InvalidOperationException($"Life entry {Index} is not a mob entry; actual type is {Type}.");

    /// <summary>
    /// Returns this entry's template ID as an NPC template ID.
    /// Throws when the life entry does not represent an NPC.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// Thrown when <see cref="Type"/> is not <see cref="LifeType.Npc"/>.
    /// </exception>
    public NpcTemplateId AsNpc =>
        TryGetNpcId(out NpcTemplateId npcId)
            ? npcId
            : throw new InvalidOperationException($"Life entry {Index} is not an NPC entry; actual type is {Type}.");

    /// <summary>Gets the NPC template ID when this entry is an NPC; otherwise <see langword="null"/>.</summary>
    public NpcTemplateId? NpcId => TryGetNpcId(out NpcTemplateId npcId) ? npcId : null;

    /// <summary>Gets the mob template ID when this entry is a mob; otherwise <see langword="null"/>.</summary>
    public MobTemplateId? MobId => TryGetMobId(out MobTemplateId mobId) ? mobId : null;

    /// <summary>
    /// Attempts to read the typed NPC template identifier without throwing when this entry is not an NPC.
    /// </summary>
    /// <param name="npcId">
    /// Receives the typed NPC template identifier when <see cref="Type"/> is <see cref="LifeType.Npc"/>;
    /// otherwise receives <see langword="default"/>.
    /// </param>
    /// <returns><see langword="true"/> when this entry is an NPC; otherwise <see langword="false"/>.</returns>
    public bool TryGetNpcId(out NpcTemplateId npcId)
    {
        if (IsNpc)
        {
            npcId = new NpcTemplateId(RawTemplateId);
            return true;
        }

        npcId = default;
        return false;
    }

    /// <summary>
    /// Attempts to read the typed mob template identifier without throwing when this entry is not a mob.
    /// </summary>
    /// <param name="mobId">
    /// Receives the typed mob template identifier when <see cref="Type"/> is <see cref="LifeType.Mob"/>;
    /// otherwise receives <see langword="default"/>.
    /// </param>
    /// <returns><see langword="true"/> when this entry is a mob; otherwise <see langword="false"/>.</returns>
    public bool TryGetMobId(out MobTemplateId mobId)
    {
        if (IsMob)
        {
            mobId = new MobTemplateId(RawTemplateId);
            return true;
        }

        mobId = default;
        return false;
    }
}
