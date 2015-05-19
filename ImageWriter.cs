using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

namespace Plasma_Rev
{
    public class ImageWriter
    {
        public static void greyWriteImage(double[][] data)
        {
            Texture2D image = new Texture2D(data.Length, data[0].Length, Texture2D.TYPE_INT_RGB);

            for (int x = 0; x < data.Length; x++)
            {
                for (int y = 0; y < data[0].Length; y++)
                {
                    Color color = new Color((float)data[x, y], (float)data[x, y], (float)data[x, y]);
                    image.setRGB(x, y, color.getRGB());
                }
            }

            try
            {
                File.Create("noise.png");

                ImageIO.write(image, "PNG", file);
            }
            catch (IOException e)
            {
                throw new Exception("Unable to write noise");
            }
        }
    }
}
