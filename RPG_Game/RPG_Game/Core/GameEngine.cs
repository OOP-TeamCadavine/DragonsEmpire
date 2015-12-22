using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RPG_Game.Core;
using RPG_Game.Events;
using RPG_Game.States;

namespace RPG_Game
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameEngine : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private MapInitializer mapInitializer;
        private PlayerController playerController;
        private CollisionHandler collisionHandler;
        private EnterNameState enterNameState;
        private MainMenuState menu;
        private string playerName;

        public GameEngine()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 700;
            graphics.PreferredBackBufferWidth = 1200;
            graphics.ApplyChanges();
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
            this.IsMouseVisible = true;
            MainMenuState menu = new MainMenuState();
            menu.ButtonClicked += new ButtonClickedEventHandler(MainMenu_ButtonClicked);
            StateManager.CurrentState = menu;
            enterNameState = new EnterNameState();
            enterNameState.ButtonClicked += new ButtonClickedEventHandler(GetNameState_ButtonClicked);
            mapInitializer = new MapInitializer();
            playerController = new PlayerController();
            collisionHandler = new CollisionHandler();

            //TODO: Initialize GameOverState

            base.Initialize();
        }

       

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Assets.Init(this);

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
            
            
            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Update(gameTime);
            }
            if (StateManager.CurrentState is GameOverState && Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                menu = new MainMenuState();
                menu.ButtonClicked += new ButtonClickedEventHandler(MainMenu_ButtonClicked);
                StateManager.CurrentState = menu;
                enterNameState = new EnterNameState();
                enterNameState.ButtonClicked += new ButtonClickedEventHandler(GetNameState_ButtonClicked);
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            if (StateManager.CurrentState != null)
            {
                StateManager.CurrentState.Draw(spriteBatch, gameTime);
            }
          
            base.Draw(gameTime);
        }

        private void MainMenu_ButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                case ButtonNames.Play:
                    StateManager.CurrentState = enterNameState;
                    break;                   
                    /* ScoreState not implemented yet!
                case ButtonNames.Score:
                    StateManager.CurrentState = new ScoreState();
                    break;
                    */
                case ButtonNames.Exit:
                    this.Exit();
                    break;

            }
        }

        private void GetNameState_ButtonClicked(object sender, ButtonClickedEventArgs eventArgs)
        {
            switch (eventArgs.Button)
            {
                    case ButtonNames.Done:
                    playerName = enterNameState.PlayerName;
                    StateManager.CurrentState = new GameState(playerName, mapInitializer, playerController, collisionHandler);
                    break;
            }
        }
    }
}
