namespace RPG_Game
{
    using Microsoft.Xna.Framework.Graphics;

    public static class Assets
    {
        public static Texture2D gameBackground;
        public static Texture2D archangelFly;
        public static Texture2D archangelFlyLeft;
        public static Texture2D archangel;
        public static Texture2D pill;
        public static Texture2D soup;
        public static Texture2D cloak;
        public static Texture2D shield;
        public static Texture2D sword;
        public static Texture2D konay;
        public static Texture2D mainMenuImage;
        public static Texture2D buttonPlay;
        public static Texture2D buttonScore;
        public static Texture2D buttonExit;
        public static Texture2D blueDragon;
        public static Texture2D blackDragon;
        public static Texture2D goldenDragon;
        public static Texture2D nameStateBackground;
        public static Texture2D enterName;
        public static Texture2D doneButton;
        public static Texture2D toolbar;
        public static Texture2D okButton;
        public static Texture2D errorBackground;
        public static Texture2D gameOverBackground;

        public static SpriteFont name;
        public static SpriteFont dragonsKilled;
        public static SpriteFont health;
        public static SpriteFont experience;

        public static void Init(GameEngine game)
        {
            gameBackground = game.Content.Load<Texture2D>("background");
            archangelFly = game.Content.Load<Texture2D>("fly");
            archangelFlyLeft = game.Content.Load<Texture2D>("flyleft");
            archangel = game.Content.Load<Texture2D>("arhangel");
            toolbar = game.Content.Load<Texture2D>("toolbar");
            
            blueDragon = game.Content.Load<Texture2D>("blueDragon");
            blackDragon = game.Content.Load<Texture2D>("blackDragon");
            goldenDragon = game.Content.Load<Texture2D>("goldenDragon");

            pill = game.Content.Load<Texture2D>("pill");
            soup = game.Content.Load<Texture2D>("soup");
            cloak = game.Content.Load<Texture2D>("cloak");
            shield = game.Content.Load<Texture2D>("shield");
            sword = game.Content.Load<Texture2D>("sword");
            konay = game.Content.Load<Texture2D>("konay");

            mainMenuImage = game.Content.Load<Texture2D>("DragonsEmpire");
            buttonPlay = game.Content.Load<Texture2D>("buttonPlay");
            buttonScore = game.Content.Load<Texture2D>("buttonScore");
            buttonExit = game.Content.Load<Texture2D>("buttonExit");

            nameStateBackground = game.Content.Load<Texture2D>("saveName");
            enterName = game.Content.Load<Texture2D>("emptySpace");
            doneButton = game.Content.Load<Texture2D>("doneButton");

            errorBackground = game.Content.Load<Texture2D>("error");
            okButton = game.Content.Load<Texture2D>("okbutton");

            name = game.Content.Load<SpriteFont>("name");
            health = game.Content.Load<SpriteFont>("health");
            experience = game.Content.Load<SpriteFont>("experience");
            dragonsKilled = game.Content.Load<SpriteFont>("dragons");

            gameOverBackground = game.Content.Load<Texture2D>("gameover");
        }
    }
}
