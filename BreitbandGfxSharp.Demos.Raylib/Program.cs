using System.Numerics;
using BreitbandGfxSharp;
using BreitbandGfxSharp.Demos.Raylib;
using BreitbandGfxSharp.Interfaces;
using BreitbandGfxSharp.Types;
using Raylib_cs;
using Color = BreitbandGfxSharp.Types.Color;

Raylib.InitWindow(800, 480, "Hello World");

IRenderer renderer = new Renderer();
Raylib.SetTargetFPS(60);
while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    renderer.Clear(new Color(0f, 0f, 1f));


    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        renderer.Translation = renderer.Translation with { X = renderer.Translation.X - 1 };
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        renderer.Translation = renderer.Translation with { X = renderer.Translation.X + 1 };
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        renderer.Translation = renderer.Translation with { Y = renderer.Translation.Y - 1 };
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        renderer.Translation = renderer.Translation with { Y = renderer.Translation.Y + 1 };
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
    {
        renderer.Scale = new Vector2(renderer.Scale.X + 0.25f, renderer.Scale.Y + 0.25f);
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
    {
        renderer.Scale = new Vector2(renderer.Scale.X - 0.25f, renderer.Scale.Y - 0.25f);
    }
    renderer.DrawRectangle(new Vector2(0, 0), new Vector2(90, 50), new Color(1f, 0f, 0f), 5f);
    renderer.FillRectangle(new Vector2(0, 100), new Vector2(90, 50), new Color(1f, 0f, 0f));
    renderer.DrawEllipse(new Vector2(0, 200), new Vector2(90, 50), new Color(1f, 0f, 0f), 2f);
    renderer.FillEllipse(new Vector2(0, 300), new Vector2(90, 50), new Color(1f, 0f, 0f));

    Raylib.EndDrawing();
}

Raylib.CloseWindow();