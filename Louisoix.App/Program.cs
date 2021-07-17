using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using GameCore = Microsoft.Xna.Framework.Game;

namespace Louisoix.App
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using var game = new Game();
            game.Run();
        }
    }

    public class Game : GameCore
    {
        private readonly GraphicsDeviceManager _graphicsDeviceManager;
        public Game()
        {
            _graphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            base.Draw(gameTime);
        }
    }
}