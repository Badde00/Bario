using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Game1
{
    public enum MenuOptions
    {
        Options,
        Start,
        End,
        InGame
    }

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Spelare tim;
        MenuOptions menuOptions = MenuOptions.Start;
        List<Bas> PLista;
        public static Viewport Viewport;
        public static GameTime GameTime;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
        
        protected override void Initialize()
        {
            base.Initialize();
            tim = new Spelare();
            PLista = new List<Bas>();
            Viewport = GraphicsDevice.Viewport;

            PLista.Add(new Plattform(new Vector2(800,100), 0, 0, 0, 0, new Vector2(0, 380)));
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TexFiler.Ladda(Content);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            GameTime = gameTime;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            tim.Update();
            if(menuOptions == MenuOptions.Start)
            {
                if(Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    menuOptions = MenuOptions.InGame;
                }
            } else if (menuOptions == MenuOptions.InGame)
            {
                if(Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    menuOptions = MenuOptions.Options;
                }
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            tim.Draw(spriteBatch);
            foreach(Plattform item in PLista)
            {
                item.Draw(spriteBatch);
            }
            
            

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
