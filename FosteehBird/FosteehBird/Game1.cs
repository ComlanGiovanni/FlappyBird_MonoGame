using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FosteehBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

       KeyboardState oldKeyboard;
       MouseState oldMouse;

        MenuBase menu;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this)
            {
                PreferredBackBufferHeight = Settings.SCREEN_HEIGHT,
                PreferredBackBufferWidth = Settings.SCREEN_WIDTH,
                
                IsFullScreen = Settings.IS_FULLSCREEN
            };
            graphics.ApplyChanges();

            this.IsMouseVisible = Settings.IS_MOUSE_VISIBLE;
            this.Window.AllowUserResizing = Settings.ALLOW_USER_RESIZING;
            this.Window.IsBorderless = Settings.IS_BORDERLESS;

            
            this.Window.Position = new Point((GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2) - (graphics.PreferredBackBufferWidth / 2), 
                (GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2) - (graphics.PreferredBackBufferHeight / 2));
            //graphics.GraphicsDevice.Viewport.TitleSafeArea.Height

            /*
        this.Window.Position = new Point(GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2,
            GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2);
            */
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            this.menu = new MenuMain();

            this.oldKeyboard = Keyboard.GetState();
            this.oldMouse = Mouse.GetState();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Ressources.LoadImages(this.Content);
            Ressources.LoadSounds(this.Content);

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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            this.menu.Update(new Input(oldKeyboard, oldMouse, Keyboard.GetState(), Mouse.GetState()));

            oldKeyboard = Keyboard.GetState();
            oldMouse = Mouse.GetState();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Settings.BACKGROUND_COLOR);

            // TODO: Add your drawing code here
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp,
                null,null,null,null);

            this.menu.Draw(this.spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
