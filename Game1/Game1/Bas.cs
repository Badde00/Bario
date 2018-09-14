using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Bas
    {
        protected Texture2D tex;
        protected Vector2 pos;
        protected int height;
        protected int width;

        public virtual void Update() { }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(tex,new Rectangle(pos.ToPoint(),new Point(width, height)), Color.BlanchedAlmond);
        }

        public Texture2D Tex
        {
            get { return tex; }
            set { tex = value; }
        }

        public Vector2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }
    }
}
