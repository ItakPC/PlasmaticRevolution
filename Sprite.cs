using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Plasma_Rev
{
    public class Sprite
    {
        private static Texture2D sheet;

        public static Texture2D getSprite(int y, int angle)
        {
            if (sheet == null)
            {
                sheet = TextureManager.loadTexture("mob/playerSheet");
            }

            return null; // delete this when bitmap code is finished

            // REPLACE WITH BITMAP CROPPING http://stackoverflow.com/questions/11457679/extract-sub-image-from-an-image-using-c-sharp
            /*
            Texture2D image = sheet.getSubimage(0, y * Ref.tileSize, Ref.tileSize, Ref.tileSize);

            double rotationRequired = MathHelper.toRad(angle);
            double locationX = image.Width / 2;
            double locationY = image.Height / 2;
            AffineTransform tx = AffineTransform.getRotateInstance(rotationRequired, locationX, locationY);
            AffineTransformOp op = new AffineTransformOp(tx, AffineTransformOp.TYPE_BILINEAR);
            return op.filter(image, null);
             */
        }
    }
}