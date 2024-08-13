using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectile_Motion_Project.Controls;
using Projectile_Motion_Project.States;

namespace Projectile_Motion_Project.States
{
    public class GameState : State
    {
        private SpriteFont font;

        public static int screenWidth = 1920;

        public static int screenHeight = 1080;

        private Texture2D background;
        public GameState(Main game, ContentManager content) : base (game, content)
        {

        }

        public override void LoadContent()
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }


        public override void PostUpdate(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        public override void Draw(GameTime gameTime, SpriteBatch )
        {
            throw new NotImplementedException();
        }
    }
}
