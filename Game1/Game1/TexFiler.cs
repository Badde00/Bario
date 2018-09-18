using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    static class TexFiler
    {
        public static Texture2D spelare;
        
        public static void Ladda(ContentManager contMan)
        {
            spelare = contMan.Load<Texture2D>(@"Spel-filer\Gubbe1");
        }
    }
}
