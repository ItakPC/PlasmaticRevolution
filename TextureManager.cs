using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plasma_Rev
{
    public class TextureManager
    {
        public static Texture2D loadTexture(string path)
        {
            return Program.game.Content.Load<Texture2D>(path);
        }
    }
}
