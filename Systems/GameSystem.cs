public abstract class GameSystem
{
    public abstract void Update();
    public GameEngine GameEngine;
    public GameSystem(GameEngine gameEngine)
    {
        GameEngine = gameEngine;
    }
}