using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Projectile_Motion_Project.States;
using System;

namespace Projectile_Motion_Project
{
    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static int screenWidth = 1920;
        public static int screenHeight = 1080;

        private State _currentState;
        private State _nextState;

        Texture2D backgroundSprite;
        Texture2D cannonSprite;
        Texture2D projectileSprite;

        Rectangle backgroundRectangle;
        Rectangle cannonRectangle;
        Rectangle projectileRectangle;

        Rectangle screenRectangle;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            screenRectangle = new Rectangle(0, 0, 1920, 1080);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _currentState = new SpriteBatch(GraphicsDevice);
            _currentState.LoadContent();
            _nextState = null;

           // backgroundSprite = Content.Load<Texture2D>("deck");
           // cannonSprite = Content.Load<Texture2D>("cannon"); // delete?
           // projectileSprite = Content.Load<Texture2D>("cannonball"); // Need this to change depending on what projectile is chosen.

            // ADD A FONT
        }

        protected override void Update(GameTime gameTime)
        {
            if (_nextState  != null) 
            {
                _currentState = _nextState;
                _currentState.LoadContent();
                _nextState = null;
            }

            _currentState.Update(gameTime);

            _currentState.PostUpdate(gameTime);

            base.Update(gameTime);
        }

        public void ChangeState(State state)
        {
            _nextState = state;
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _currentState.Draw(gameTime, _spriteBatch);

            base.Draw(gameTime);
        }
    }
}
