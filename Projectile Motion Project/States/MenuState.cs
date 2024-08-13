using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Projectile_Motion_Project.Controls;
using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Xml.Linq;

namespace Projectile_Motion_Project.States
{
    public class MenuState : State
    {
        private List<Component> _components;

        private Texture2D menuBackground;

        public MenuState(Main game, ContentManager content) : base (game, content)
        {

        }

        public override void LoadContent()
        {
            var buttonTexture = _content.Load<Texture2D>("Controls/Button");
            var buttonFont = _content.Load<SpriteFont>("ButtonFonts/Font");
            menuBackground = _content.Load<Texture2D>("Backgrounds/Menu");

            _components = new List<Component>()
            {

            new Button(buttonTexture, buttonFont)
            {
                Text = "Text 1",
                Position = new Vector2(Main.ScreenWidth / 2, 400),
                Click = new EventHandler(Button_Text1_Clicked),
                // Layer = 0.1f
            },

            new Button(buttonTexture, buttonFont)
             {
                Text = "Text 2",
                Position = new Vector2(Main.ScreenWidth / 2, 400),
                Click = new EventHandler(Button_Text2_Clicked),
                // Layer = 0.1f
            },

            new Button(buttonTexture, buttonFont)
            {
                Text = "Text 3",
                Position = new Vector2(Main.ScreenWidth / 2, 400),
                Click = new EventHandler(Button_Text3_Clicked),
                // Layer = 0.1f
            },
          };
        }

        private void Button_Text1_Clicked(object sender, EventArgs args)
        {
            _game.ChangeState(new Text1State(_game, _content)
            {
                PlayerCount = 1
            });
        }

        private void Button_Text2_Clicked(object sender, EventArgs args)
        {
            _game.ChangeState(new Text2State(_game, _content)
            {
               PlayerCount = 1
            });
        }

        private void Button_Text3_Clicked(object sender, EventArgs args)
        {
            _game.ChangeState(new Text3State(_game, _content)
            {
                PlayerCount = 1
            });
        }

public override void Update(GameTime gameTime)
        {
            foreach (var component in _components)
            {
                component.Update(gameTime);
            }
        }

        public override void PostUpdate(GameTime gameTime)
        {
            
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin;

            spriteBatch.Draw(menuBackground, new Vector2(0, 0), Color.White);

            foreach (var component in _components)
            {
                component.Draw(gameTime, spriteBatch);
            }


            spriteBatch.End;
        }

    }
}
