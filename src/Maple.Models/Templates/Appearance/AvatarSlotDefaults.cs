using Maple.StrongId;

namespace Maple.Models.Templates.Appearance;

/// <summary>
/// Default placeholder equip item IDs used by the avatar compositor.
/// These are purged from the avatar before compositing each frame.
/// </summary>
public static class AvatarSlotDefaults
{
    /// <summary>Default placeholder cap used when no hat equip is present.</summary>
    public static readonly ItemTemplateId DefaultCap = new(1002186);

    /// <summary>Default placeholder eye accessory used when no eye-accessory equip is present.</summary>
    public static readonly ItemTemplateId DefaultEyeAccessory = new(1022079);

    /// <summary>Default placeholder earring used when no earring equip is present.</summary>
    public static readonly ItemTemplateId DefaultEarring = new(1032024);

    /// <summary>Default placeholder top used when no male top equip is present.</summary>
    public static readonly ItemTemplateId DefaultMaleTop = new(1040036);

    /// <summary>Default placeholder top used when no female top equip is present.</summary>
    public static readonly ItemTemplateId DefaultFemaleTop = new(1041046);

    /// <summary>Default placeholder bottom used when no male bottom equip is present.</summary>
    public static readonly ItemTemplateId DefaultMaleBottom = new(1060026);

    /// <summary>Default placeholder bottom used when no female bottom equip is present.</summary>
    public static readonly ItemTemplateId DefaultFemaleBottom = new(1061039);

    /// <summary>Default placeholder shoes used when no shoes equip is present.</summary>
    public static readonly ItemTemplateId DefaultShoes = new(1072153);

    /// <summary>Default placeholder gloves used when no gloves equip is present.</summary>
    public static readonly ItemTemplateId DefaultGloves = new(1082102);

    /// <summary>Default placeholder cape used when no cape equip is present.</summary>
    public static readonly ItemTemplateId DefaultCape = new(1102039);

    /// <summary>Default placeholder shield used when no shield equip is present.</summary>
    public static readonly ItemTemplateId DefaultShield = new(1092067);
}
