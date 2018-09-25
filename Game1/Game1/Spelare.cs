using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Spelare:Varelser
    {
        Vector2 velocity = Vector2.Zero;
        float gravity = 9.82f;
        KeyboardState lastState;
        public Spelare()
        {
            tex = TexFiler.spelare;
            width = tex.Width;
            height = tex.Height;
            velocity.Y = 10;
        }

        public override void Update()
        {
            KeyboardState newState = Keyboard.GetState();
            if (newState.IsKeyDown(Keys.W) && lastState.IsKeyUp(Keys.W))
            {
                velocity.Y -= 7;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                pos.Y += 10;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                pos.X -= 10;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                pos.X += 10;
            }

            if(pos.Y <= 0)
            {
                pos.Y = 0;
            }



            if (pos.X <= 0)
            {
                pos.X = 0;
            }

            if (pos.X >= Game1.Viewport.Width - tex.Width)
            {
                pos.X = Game1.Viewport.Width - tex.Width;
            }
            velocity.Y += gravity*(float)Game1.GameTime.ElapsedGameTime.TotalSeconds;
            pos += velocity;

            if (pos.Y >= Game1.Viewport.Height - tex.Height)
            {
                pos.Y = Game1.Viewport.Height - tex.Height;
                velocity.Y = 0;
            }
            lastState = newState;
        }
    }
}
