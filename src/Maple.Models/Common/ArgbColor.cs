namespace Maple.Models.Common;

/// <summary>
/// Represents a raw ARGB color value stored by MapleStory data files.
/// </summary>
/// <param name="Value">Packed <c>0xAARRGGBB</c> color value.</param>
public readonly record struct ArgbColor(uint Value)
{
    /// <summary>Gets the alpha channel.</summary>
    public byte Alpha => (byte)(Value >> 24);

    /// <summary>Gets the red channel.</summary>
    public byte Red => (byte)(Value >> 16);

    /// <summary>Gets the green channel.</summary>
    public byte Green => (byte)(Value >> 8);

    /// <summary>Gets the blue channel.</summary>
    public byte Blue => (byte)Value;

    /// <summary>
    /// Creates a color from a signed 32-bit ARGB representation.
    /// </summary>
    /// <param name="value">Signed ARGB value.</param>
    /// <returns>A strongly typed color wrapper.</returns>
    public static ArgbColor FromInt32(int value) => new(unchecked((uint)value));

    /// <summary>Returns the packed color as a hexadecimal ARGB string.</summary>
    /// <returns>A string in <c>#AARRGGBB</c> form.</returns>
    public string ToHexString() => $"#{Value:X8}";

    /// <inheritdoc />
    public override string ToString() => ToHexString();
}
