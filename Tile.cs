using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plasma_Rev
{
    public class Tile
    {
        public Material material;
        public Texture2D texture;

        public Tile(Material material)
        {
            this.material = material;
            this.texture = TextureManager.loadTexture(this.material.getRandomResourceId());
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y, int width, int height)
        {
            spriteBatch.Draw(texture, new Rectangle(x, y, width, height), Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle rect)
        {
            spriteBatch.Draw(texture, rect, Color.White);
        }

        public void Draw(SpriteBatch spriteBatch, int x, int y)
        {
            spriteBatch.Draw(texture, new Rectangle(x, y, MathHelper.ceil(Ref.tileSize * Ref.pixelSize * Main.pixelScaleWidth), MathHelper.ceil(Ref.tileSize * Ref.pixelSize * Main.pixelScaleHeight)), Color.White);
        }
    }
}
