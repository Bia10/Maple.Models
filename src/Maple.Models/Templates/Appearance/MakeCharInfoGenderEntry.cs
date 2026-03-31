using Maple.StrongId;

namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Valid starting appearance and equipment IDs for one gender.
/// </summary>
/// <param name="Id">Gender bucket identifier.</param>
/// <param name="Name">Loader-assigned display label.</param>
/// <param name="Faces">Available face item template IDs.</param>
/// <param name="Hairs">Available hair item template IDs.</param>
/// <param name="Skins">Available skin tone IDs.</param>
/// <param name="Tops">Available top item template IDs.</param>
/// <param name="Bottoms">Available bottom item template IDs.</param>
/// <param name="Shoes">Available shoe item template IDs.</param>
/// <param name="Weapons">Available weapon item template IDs.</param>
public sealed record MakeCharInfoGenderEntry(
    int Id,
    string Name,
    IReadOnlyList<ItemTemplateId>? Faces = null,
    IReadOnlyList<ItemTemplateId>? Hairs = null,
    IReadOnlyList<ItemTemplateId>? Skins = null,
    IReadOnlyList<ItemTemplateId>? Tops = null,
    IReadOnlyList<ItemTemplateId>? Bottoms = null,
    IReadOnlyList<ItemTemplateId>? Shoes = null,
    IReadOnlyList<ItemTemplateId>? Weapons = null
) : TemplateCatalogEntry(Id, Name);
