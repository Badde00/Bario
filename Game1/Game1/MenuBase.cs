using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class MenuBase:Bas
    {
        public MenuBase()
        {
            tex = TexFiler.menu;
            width = tex.Width;
            height = tex.Height;
        }

        public override void Update()
        {

        }
    }
}
