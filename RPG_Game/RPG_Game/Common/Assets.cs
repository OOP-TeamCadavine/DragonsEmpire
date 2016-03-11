namespace RPG_Game.Common
{
    using Microsoft.Xna.Framework.Graphics;
    using RPG_Game.Core;

    public static class Assets
    {
        public static Texture2D GameBackground;
        public static Texture2D ArchangelFly;
        public static Texture2D ArchangelFlyLeft;
        public static Texture2D Archangel;
        public static Texture2D Pill;
        public static Texture2D Soup;
        public static Texture2D Cloak;
        public static Texture2D Shield;
        public static Texture2D Sword;
        public static Texture2D Konay;
        public static Texture2D MainMenuImage;
        public static Texture2D ButtonPlay;
        public static Texture2D ButtonScore;
        public static Texture2D ButtonExit;
        public static Texture2D BlueDragon;
        public static Texture2D BlackDragon;
        public static Texture2D GoldenDragon;
        public static Texture2D NameStateBackground;
        public static Texture2D EnterName;
        public static Texture2D DoneButton;
        public static Texture2D Toolbar;
        public static Texture2D GameOverBackground;
        public static Texture2D ScoresBackground;

        public static SpriteFont Name;
        public static SpriteFont DragonsKilled;
        public static SpriteFont Health;
        public static SpriteFont Experience;

        public static void Init(GameEngine game)
        {
            GameBackground = game.Content.Load<Texture2D>("background");
            ArchangelFly = game.Content.Load<Texture2D>("fly");
            ArchangelFlyLeft = game.Content.Load<Texture2D>("flyleft");
            Archangel = game.Content.Load<Texture2D>("arhangel");
            Toolbar = game.Content.Load<Texture2D>("toolbar");
            
            BlueDragon = game.Content.Load<Texture2D>("blueDragon");
            BlackDragon = game.Content.Load<Texture2D>("blackDragon");
            GoldenDragon = game.Content.Load<Texture2D>("goldenDragon");

            Pill = game.Content.Load<Texture2D>("pill");
            Soup = game.Content.Load<Texture2D>("soup");
            Cloak = game.Content.Load<Texture2D>("cloak");
            Shield = game.Content.Load<Texture2D>("shield");
            Sword = game.Content.Load<Texture2D>("sword");
            Konay = game.Content.Load<Texture2D>("konay");

            MainMenuImage = game.Content.Load<Texture2D>("DragonsEmpire");
            ButtonPlay = game.Content.Load<Texture2D>("buttonPlay");
            ButtonScore = game.Content.Load<Texture2D>("buttonScore");
            ButtonExit = game.Content.Load<Texture2D>("buttonExit");

            NameStateBackground = game.Content.Load<Texture2D>("saveName");
            EnterName = game.Content.Load<Texture2D>("emptySpace");
            DoneButton = game.Content.Load<Texture2D>("doneButton");

            Name = game.Content.Load<SpriteFont>("name");
            Health = game.Content.Load<SpriteFont>("health");
            Experience = game.Content.Load<SpriteFont>("experience");
            DragonsKilled = game.Content.Load<SpriteFont>("dragons");

            GameOverBackground = game.Content.Load<Texture2D>("gameover");

            ScoresBackground = game.Content.Load<Texture2D>("highScores");
        }
    }
}
