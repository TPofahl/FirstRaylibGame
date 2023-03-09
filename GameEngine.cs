using Raylib_CsLo;

public class GameEngine
{
    public List<Entity> Entities { get; set; } = new();
    public List<GameSystem> Systems { get; set; } = new();
    public Camera2D Camera;

    public void RunGame()
    {
        Raylib.InitWindow(1380, 768, "FREE Assets THE GAME");
        Raylib.SetTargetFPS(60);
        Camera = new Camera2D();
        Camera.zoom = 1;
        while (!Raylib.WindowShouldClose())
        {
            GameLoop();
        }
    }

    private void GameLoop()
    {
        Raylib.BeginDrawing();
        Raylib.BeginMode2D(Camera);
        Raylib.ClearBackground(Raylib.WHITE);
        foreach(var system in Systems)
        {
            system.Update();
        }

        Raylib.EndMode2D();
        Raylib.EndDrawing();
    }
}