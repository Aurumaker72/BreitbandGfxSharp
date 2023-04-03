using System.Numerics;
using BreitbandGfxSharp.Interfaces;
using Raylib_cs;
using Color = BreitbandGfxSharp.Types.Color;

namespace BreitbandGfxSharp.Demos.Raylib;

public class Renderer : IRenderer
{
    private Raylib_cs.Color FromColor(Color color) => new Raylib_cs.Color((byte)(color.Red * byte.MaxValue),
        (byte)(color.Green * byte.MaxValue),
        (byte)(color.Blue * byte.MaxValue), (byte)(color.Alpha * byte.MaxValue));


    public Vector2 Translation { get; set; } = Vector2.Zero;
    public Vector2 Scale { get; set; } = Vector2.One;

    void IRenderer.Clear(Color color)
    {
        Raylib_cs.Raylib.ClearBackground(FromColor(color));
        Raylib_cs.Raylib.EndDrawing();
        Raylib_cs.Raylib.BeginDrawing();
    }

    void IRenderer.DrawRectangle(Vector2 position, Vector2 size, Color color, float thickness)
    {
        Raylib_cs.Raylib.DrawRectangleLinesEx(new Rectangle((position.X + Translation.X) * Scale.X, (position.Y + Translation.Y) * Scale.Y, size.X * Scale.X, size.Y * Scale.Y), thickness, FromColor(color));
    }

    void IRenderer.FillRectangle(Vector2 position, Vector2 size, Color color)
    {
        Raylib_cs.Raylib.DrawRectangleV((position + Translation) * Scale, size * Scale, FromColor(color));
    }

    void IRenderer.DrawEllipse(Vector2 position, Vector2 radius, Color color, float thickness)
    {
        // TODO: reimplement line thickness manually, since raylibcs doesn't expose the correct api lol
        Raylib_cs.Raylib.DrawEllipseLines((int)((position.X + Translation.X) * Scale.X), (int)((position.Y + Translation.Y) * Scale.Y), radius.X * Scale.X, radius.Y * Scale.Y, FromColor(color));
    }
    void IRenderer.FillEllipse(Vector2 position, Vector2 radius, Color color)
    {
        Raylib_cs.Raylib.DrawEllipse((int)((position.X + Translation.X) * Scale.X), (int)((position.Y + Translation.Y) * Scale.Y), radius.X * Scale.X, radius.Y * Scale.Y, FromColor(color));
    }
}