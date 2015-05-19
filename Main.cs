using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Plasma_Rev
{
    public class Main : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static Map map;

        public int FPS;
        public int UPS;

        public static float pixelScaleWidth;
        public static float pixelScaleHeight;

        public static Input input = new Input();

        public static bool debugMode = false;

        public Main()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            map = new Map(new Player(0, 0));

            pixelScaleWidth = Ref.screenWidth / Ref.optimisedSceenWidth;
            pixelScaleHeight = Ref.screenHeight / Ref.optimisedSceenHeight;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent() { }

        protected override void Update(GameTime gameTime)
        {
            map.checkChunks();
            map.player.Update();
            input.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
