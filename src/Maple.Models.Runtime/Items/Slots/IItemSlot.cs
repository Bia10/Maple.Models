using System.Text.Json.Serialization;
using Maple.StrongId;

namespace Maple.Models.Items.Slots;

/// <summary>
/// Base polymorphic contract for persisted inventory slots.
/// The <see cref="JsonDerivedTypeAttribute"/> declarations define the JSON discriminator values used
/// when slot payloads are serialized or materialized across process boundaries.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(ItemSlot), "item")]
[JsonDerivedType(typeof(ItemSlotEquip), "equip")]
[JsonDerivedType(typeof(ItemSlotBundle), "bundle")]
[JsonDerivedType(typeof(ItemSlotPet), "pet")]
public interface IItemSlot
{
    /// <summary>Strongly typed template ID of the item stored in this slot.</summary>
    [JsonPropertyName("TemplateID")]
    ItemTemplateId TemplateId { get; }
}
