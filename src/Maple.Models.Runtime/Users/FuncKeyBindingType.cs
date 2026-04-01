namespace Maple.Models.Users;

/// <summary>
/// Function-key binding category stored in <c>FUNCKEY_MAPPED::nType</c> (PDB).
/// Controls how <see cref="CharacterFuncKeyRecord.TargetId"/> is interpreted for each bound slot.
/// See <c>docs/runtime-character-models.md</c> for the full PDB enumerator mapping.
/// </summary>
public enum FuncKeyBindingType : byte
{
    /// <summary>Unbound slot (<c>T_NONE</c>); <c>TargetId</c> is unused.</summary>
    None = 0,

    /// <summary>Skill shortcut (<c>T_SKILL</c>); <c>TargetId</c> is a skill template ID.</summary>
    Skill = 1,

    /// <summary>Item shortcut (<c>T_ITEM</c>); <c>TargetId</c> is an item template ID.</summary>
    Item = 2,

    /// <summary>Emotion / expression (<c>T_EMOTION</c>); <c>TargetId</c> is an emotion ID.</summary>
    Emotion = 3,

    /// <summary>System menu action (<c>T_MENU</c>); <c>TargetId</c> is a menu action index.</summary>
    Menu = 4,

    /// <summary>Basic character action (<c>T_BASICACTION</c>); <c>TargetId</c> is a basic-action index.</summary>
    BasicAction = 5,

    /// <summary>Basic emotion / expression (<c>T_BASICEMOTION</c>); <c>TargetId</c> is a basic-emotion index.</summary>
    BasicEmotion = 6,

    /// <summary>Effect shortcut (<c>T_EFFECT</c>); <c>TargetId</c> is an effect ID.</summary>
    Effect = 7,

    /// <summary>Skill macro slot (<c>T_MACROSKILL</c>); <c>TargetId</c> is a macro slot index.</summary>
    MacroSkill = 8,
}
