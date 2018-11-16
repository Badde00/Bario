using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Varelser:Bas
    {
        protected Rectangle hitBox;
        protected Rectangle hitBoxBot;
        protected Rectangle hitBoxTop;
        protected Rectangle hitBoxRight;
        protected Rectangle hitBoxLeft;
        protected int hP;
        protected double speed;

        public Rectangle HitBox
        {
            get { return hitBox; }
            set { hitBox = value; }
        }

        public Rectangle HitBoxBot
        {
            get { return hitBoxBot; }
            set { hitBoxBot = value; }
        }

        public Rectangle HitBoxTop
        {
            get { return hitBoxTop; }
            set { hitBoxTop = value; }
        }

        public Rectangle HitBoxRight
        {
            get { return hitBoxRight; }
            set { hitBoxRight = value; }
        }

        public Rectangle HitBoxLeft
        {
            get { return hitBoxLeft; }
            set { hitBoxLeft = value; }
        }

        public int HP
        {
            get { return hP; }
            set { hP = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
