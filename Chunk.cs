using Microsoft.Xna.Framework.Graphics;
using System;

namespace Plasma_Rev
{
    public class Chunk
    {
        public Tile[,] tiles;

        public int chunkX;
        public int chunkY;

        public Chunk(int chunkX, int chunkY)
        {
            this.chunkX = chunkX;
            this.chunkY = chunkY;
        }

        public void populate()
        {
            tiles = new Tile[Ref.tileAmountX, Ref.tileAmountY];

            SimplexNoise simplexNoise = new SimplexNoise(7, 0.1);

            double xStart = chunkX * Ref.tileAmountX;
            double xEnd   = xStart + Ref.tileAmountX;
            double yStart = chunkY * Ref.tileAmountY;
            double yEnd   = yStart + Ref.tileAmountY;

            int xResolution = Ref.tileAmountX;
            int yResolution = Ref.tileAmountY;

            double[,] data = new double[xResolution, yResolution];

            for(int i = 0; i < xResolution; i++){
                for(int j = 0; j < yResolution; j++){
                    int x = (int)(xStart + (i * (xEnd - xStart) / xResolution));
                    int y = (int)(yStart + (j * (yEnd - yStart) / yResolution));

                    double noise = (1 + simplexNoise.getNoise(x, y)) / 2;

                    Material material;
                    if(noise < 0.495F)
                        material = Material.DEEPWATER;
                    else if(noise < 0.5F)
                        material = Material.WATER;
                    else if(noise < 0.525F)
                        material = Material.SAND;
                    else if(noise < 0.545F)
                        material = Material.GRASS;
                    else
                        material = Material.ROCK;

                    tiles[i, j] = new Tile(material);

                    data[i, j] = noise;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int posX = MathHelper.ceil((chunkX * Ref.tileAmountX * Ref.tileSize * Ref.pixelSize - Main.map.player.posX * Ref.tileSize * Ref.pixelSize - Ref.tileSize * Ref.pixelSize / 2) * Main.pixelScaleWidth + Ref.screenWidth / 2);
            int posY = MathHelper.ceil((chunkY * Ref.tileAmountY * Ref.tileSize * Ref.pixelSize - Main.map.player.posY * Ref.tileSize * Ref.pixelSize - Ref.tileSize * Ref.pixelSize / 2) * Main.pixelScaleHeight + Ref.screenHeight / 2);

            for (int x = 0; x < tiles.Length; x++)
            {
                for (int y = 0; y < tiles[0].Length; y++)
                {
                    tiles[x, y].Draw(spriteBatch, MathHelper.ceil(x * Ref.tileSize * Ref.pixelSize * Main.pixelScaleWidth + posX), MathHelper.ceil(y * Ref.tileSize * Ref.pixelSize * Main.pixelScaleHeight + posY));
                }
            }
            spriteBatch.drawLine(posX, 0, posX, Ref.screenHeight);
            spriteBatch.drawLine(0, posY, Ref.screenWidth, posY);

        }

        public bool equals(Object obj)
         {
            if(!(obj is Chunk))
                return false;

            Chunk chunk = (Chunk) object;
            return chunkX == chunk.chunkX && chunkY == chunk.chunkY;
        }
    }
}
