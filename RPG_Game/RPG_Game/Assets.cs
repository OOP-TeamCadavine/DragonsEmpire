using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Game
{
    public static class Assets
    {
        public static Texture2D gameBackground;
        public static Texture2D archangelFly;
        public static Texture2D archangelFlyLeft;
        public static Texture2D archangel;
        public static void Init(Game1 game)
        {
            gameBackground = game.Content.Load<Texture2D>("background");
            archangelFly = game.Content.Load<Texture2D>("fly");
            archangelFlyLeft = game.Content.Load<Texture2D>("flyleft");
            archangel = game.Content.Load<Texture2D>("arhangel");
        }
    }
}
