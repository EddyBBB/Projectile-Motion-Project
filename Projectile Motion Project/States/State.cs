using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Projectile_Motion_Project.States
{
    public abstract class State
    {
        protected Main _game;

        protected ContentManager _content;

        public State(Main game, ContentManager content)
        {
            _game = game;
            _content = content;
        }
        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime);

        public abstract void PostUpdate(GameTime gameTime);

        public abstract void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
