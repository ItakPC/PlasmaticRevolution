using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace Plasma_Rev
{
    class GameDELETEME
    {
        public GameDELETEME()
        {
            
        }

        // Java Rendering Code: Convert to MonoGame
        /*
	    public class Screen extends JPanel
	    {
            public void paintComponent(SpriteBatch spriteBatch)
            {
                // Clears the screen
                spriteBatch.clearRect(0, 0, screenWidth, screenHeight);

                // Renders background of screen
                renderBackground(g);

                // Renders main part of screen
                render(g);

                // Renders foreground of screen
                renderForeground(g);
            }

            private void renderBackground(SpriteBatch spriteBatch)
            {
                for (Chunk chunk : map.loadedChunks)
                {
                    int posX = ceil((chunk.chunkX * tileAmountX * tileSize * pixelSize - map.player.posX * tileSize * pixelSize - tileSize * pixelSize / 2) * pixelScaleWidth + screenWidth / 2);
                    int posY = ceil((chunk.chunkY * tileAmountY * tileSize * pixelSize - map.player.posY * tileSize * pixelSize - tileSize * pixelSize / 2) * pixelScaleHeight + screenHeight / 2);

                    for (int x = 0; x < chunk.tiles.Length; x++)
                    {
                        for (int y = 0; y < chunk.tiles[0].Length; y++)
                        {
                            spriteBatch.drawImage(chunk.tiles[x, y].texture, ceil(x * tileSize * pixelSize * pixelScaleWidth + posX), ceil(y * tileSize * pixelSize * pixelScaleHeight + posY), ceil(tileSize * pixelSize * pixelScaleWidth), ceil(tileSize * pixelSize * pixelScaleHeight), null);
                        }
                    }
                    spriteBatch.drawLine(posX, 0, posX, screenHeight);
                    spriteBatch.drawLine(0, posY, screenWidth, posY);
                }
            }

            private void render(SpriteBatch spriteBatch)
            {
        	    map.player.Draw(g);
            }

            private void renderForeground(SpriteBatch spriteBatch)
            {
        	    if (debugMode)
        	    {
        		    resetString();
            	    drawString(g, "FPS: " + FPS);
            	    drawString(g, "");
            	    drawString(g, "MouseX: " + mouseX);
            	    drawString(g, "MouseY: " + mouseY);
            	    drawString(g, "");
            	    drawString(g, "PosX: " + map.player.posX);
            	    drawString(g, "PosY: " + map.player.posY);
        	    }
            }

		    int spaceY = 15;
            private void resetString()
            {
                spaceY = 15;
            }
            private void drawString(SpriteBatch spriteBatch, String text)
            {
                spriteBatch.setColor(Color.GREEN);
                spriteBatch.drawString(text, 5, spaceY);
                spaceY += 16;
            }
		    private void drawList(SpriteBatch spriteBatch, List<String> list)
            {
                for(String text : list)
                {
                    drawString(g, text);
                }
            }
		    private List<String> toStringList(String pre, List<Integer> list)
            {
                List<String> stringList = new List<String>();

                for(Object object : list){
                    stringList.add(pre+object.toString());
                }

                return stringList;
            }
             */
        }
    }
