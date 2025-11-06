using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;

namespace Mono_Game_lesson
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D zooTexture;
        Texture2D giraffeTexture;
        Texture2D monkeyTexture;
        Texture2D polarBearTexture;
        Texture2D tigerTexture;
        Texture2D blueBirdTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();

            this.Window.Title = "My first monogame project";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            zooTexture = Content.Load<Texture2D>("zoo");
            giraffeTexture = Content.Load<Texture2D>("giraffe");
            monkeyTexture = Content.Load<Texture2D>("monkey");
            polarBearTexture = Content.Load<Texture2D>("polarbear");
            tigerTexture = Content.Load<Texture2D>("tiger");
            blueBirdTexture = Content.Load<Texture2D>("bird");
        }
        

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(zooTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(giraffeTexture,new Vector2(300,400), Color.White);
            _spriteBatch.Draw(monkeyTexture, new Vector2(10, 350), Color.White);
            _spriteBatch.Draw(polarBearTexture, new Vector2(600, 300), Color.White);
            _spriteBatch.Draw(tigerTexture, new Vector2(400, 300), Color.White);
            _spriteBatch.Draw(blueBirdTexture, new Vector2(400, 10), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
