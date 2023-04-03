namespace BreitbandGfxSharp.Types;

/// <summary>
/// Represents a 4-floating point channel color
/// </summary>
public readonly struct Color
{
    /// <summary>
    /// The red channel's value, ranging from <c>0->1</c>
    /// </summary>
    public readonly float Red;
    
    /// <summary>
    /// The green channel's value, ranging from <c>0->1</c>
    /// </summary>
    public readonly float Green;
    
    /// <summary>
    /// The blue channel's value, ranging from <c>0->1</c>
    /// </summary>
    public readonly float Blue;
    
    /// <summary>
    /// The alpha channel's value, ranging from <c>0->1</c>
    /// </summary>
    public readonly float Alpha;

    public Color(float red = 1f, float green = 1f, float blue = 1f, float alpha = 1f)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }
}