using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Spelare:Varelser
    {
        public Spelare()
        {
            tex = TexFiler.spelare;
            width = tex.Width;
            height = tex.Height;
        }
    }
}
