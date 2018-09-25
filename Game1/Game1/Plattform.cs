using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Plattform:Bas
    {
        protected Rectangle size;
        private float moveSpaceX;
        private float moveSpaceY;
        private float speedX;
        private float speedY;
        private Vector2 orgPos;

        public Rectangle Size
        {
            get { return size; }
        }

        public override void Update()
        {
            if(pos.Y-orgPos.Y>=moveSpaceY)
            {
                pos.Y -= speedY;
            } else
            {
                pos.Y += speedY;
            }

            if (pos.X - orgPos.X >= moveSpaceY)
            {
                pos.X -= speedX;
            }
            else
            {
                pos.X += speedX;
            }
        }

        public Plattform(Rectangle si, float mX, float mY, float sX,float sY, Vector2 p)
        {
            tex = TexFiler.plattform;
            si = size;
            mX = moveSpaceX;
            mY = moveSpaceY;
            sX = speedX;
            sY = speedY;
            p = pos;
            p = orgPos;
        }
    }
}
