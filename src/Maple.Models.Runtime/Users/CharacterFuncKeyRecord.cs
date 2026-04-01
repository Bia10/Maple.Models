using System.Text.Json.Serialization;

namespace Maple.Models.Users;

/// <summary>
/// Persisted function-key binding entry.
/// Maps to one <c>FUNCKEY_MAPPED</c> payload from <c>GW_FuncKeyMapped</c>.
/// </summary>
public sealed class CharacterFuncKeyRecord : ICharacterFuncKeyRecord
{
    /// <summary>
    /// Binding category stored in <c>FUNCKEY_MAPPED::nType</c>.
    /// </summary>
    [JsonPropertyName("Type")]
    public FuncKeyBindingType BindingType { get; set; }

    /// <summary>
    /// Target identifier stored in <c>FUNCKEY_MAPPED::nID</c>.
    /// The value is interpreted by <see cref="BindingType"/>.
    /// </summary>
    [JsonPropertyName("Action")]
    public int TargetId { get; set; }
}
