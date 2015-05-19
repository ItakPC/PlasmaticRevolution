using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Plasma_Rev
{
    public class Input
    {
        KeyboardState state;
        MouseState mstate;

        public void Update()
        {
            #region Diagonal Movement

            // Walk Up Right
            if (state.IsKeyDown(Keys.W) && state.IsKeyDown(Keys.D))
            {
                Main.map.player.animation = Main.map.player.walkUpRight;
            	Main.map.player.animation.start();
                Main.map.player.posY -= Main.map.player.speed;
            }

            // Walk Up Left
            if (state.IsKeyDown(Keys.W) && state.IsKeyDown(Keys.A))
            {
            	Main.map.player.animation = Main.map.player.walkUpLeft;
            	Main.map.player.animation.start();
                Main.map.player.posY += Main.map.player.speed;
            }

            // Walk Down Right
            if (state.IsKeyDown(Keys.S) && state.IsKeyDown(Keys.D))
            {
            	Main.map.player.animation = Main.map.player.walkDownRight;
            	Main.map.player.animation.start();
                Main.map.player.posX += Main.map.player.speed;
            }

            // Walk Down Left
            if (state.IsKeyDown(Keys.S) && state.IsKeyDown(Keys.A))
            {
            	Main.map.player.animation = Main.map.player.walkDownLeft;
            	Main.map.player.animation.start();
                Main.map.player.posX -= Main.map.player.speed;
            }

            #endregion

            #region Movement

            // Walk Up
            if (state.IsKeyDown(Keys.W) && !state.IsKeyDown(Keys.A) && !state.IsKeyDown(Keys.D))
            {
            	Main.map.player.animation = Main.map.player.walkUp;
            	Main.map.player.animation.start();
                Main.map.player.posY -= Main.map.player.speed;
            }

            // Walk Down
            if (state.IsKeyDown(Keys.S) && !state.IsKeyDown(Keys.A) && !state.IsKeyDown(Keys.D))
            {
            	Main.map.player.animation = Main.map.player.walkDown;
            	Main.map.player.animation.start();
                Main.map.player.posY += Main.map.player.speed;
            }

            // Walk Right
            if (state.IsKeyDown(Keys.D) && !state.IsKeyDown(Keys.W) && !state.IsKeyDown(Keys.S))
            {
            	Main.map.player.animation = Main.map.player.walkRight;
            	Main.map.player.animation.start();
                Main.map.player.posX += Main.map.player.speed;
            }

            // Walk Left
            if (state.IsKeyDown(Keys.A) && !state.IsKeyDown(Keys.W) && !state.IsKeyDown(Keys.S))
            {
            	Main.map.player.animation = Main.map.player.walkLeft;
            	Main.map.player.animation.start();
                Main.map.player.posX -= Main.map.player.speed;
            }

            #endregion

            // Debug Menu
            if (state.IsKeyDown(Keys.Back) && Main.debugMode == false)
            {
                Main.debugMode = true;
            }
            else if (Main.debugMode == true)
            {
            	Main.debugMode = false;
            }
        }
    }
}