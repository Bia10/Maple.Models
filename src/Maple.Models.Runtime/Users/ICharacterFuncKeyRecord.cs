namespace Maple.Models.Users;

/// <summary>
/// Read contract for a persisted function-key binding entry.
/// Implemented by <see cref="CharacterFuncKeyRecord"/>.
/// </summary>
public interface ICharacterFuncKeyRecord
{
    /// <summary>Binding category (<c>FUNCKEY_MAPPED::nType</c>).</summary>
    FuncKeyBindingType BindingType { get; }

    /// <summary>Target identifier (<c>FUNCKEY_MAPPED::nID</c>); interpretation depends on <see cref="BindingType"/>.</summary>
    int TargetId { get; }
}
