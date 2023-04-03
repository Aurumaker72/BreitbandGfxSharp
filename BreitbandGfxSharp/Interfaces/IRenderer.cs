using System.Numerics;
using BreitbandGfxSharp.Types;

namespace BreitbandGfxSharp.Interfaces;

/// <summary>
///     The default <see langword="interface" /> for a contract that provides rendering functionality
/// </summary>
public interface IRenderer
{
    /// <summary>
    /// The projection's translation
    /// </summary>
    public Vector2 Translation { get; set; }

    /// <summary>
    /// The projection's scale
    /// </summary>
    public Vector2 Scale { get; set; }

    /// <summary>
    /// Clears the viewport
    /// </summary>
    /// <param name="color">The color</param>
    void Clear(Color color);
    
    /// <summary>
    /// Draws a rectangle's outline
    /// </summary>
    /// <param name="position">The left and top coordinates</param>
    /// <param name="size">The width and height</param>
    /// <param name="color">The color</param>
    /// <param name="thickness">The outline's thickness</param>
    void DrawRectangle(Vector2 position, Vector2 size, Color color, float thickness);
    
    /// <summary>
    /// Draws a rectangle's solid shape
    /// </summary>
    /// <param name="position">The left and top coordinates</param>
    /// <param name="size">The width and height</param>
    /// <param name="color">The color</param>
    void FillRectangle(Vector2 position, Vector2 size, Color color);


    /// <summary>
    /// Draws an ellipse's outline
    /// </summary>
    /// <param name="position">The left and top coordinates of the ellipse's center</param>
    /// <param name="radius">The horizontal and vertical radii</param>
    /// <param name="color">The color</param>
    /// <param name="thickness">The outline's thickness</param>
    void DrawEllipse(Vector2 position, Vector2 radius, Color color, float thickness);
    
    /// <summary>
    /// Draws a ellipse's solid shape
    /// </summary>
    /// <param name="position">The left and top coordinates of the ellipse's center</param>
    /// <param name="radius">The horizontal and vertical radii</param>
    /// <param name="color">The color</param>
    void FillEllipse(Vector2 position, Vector2 radius, Color color);

}