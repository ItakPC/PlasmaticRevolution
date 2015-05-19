using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Plasma_Rev
{
    public class Player : Entity
    {
        public float speed = .1f;

        // Each section is one animation set.
        // PLEASE PLEASE PLEASE MAKE THIS MORE EFFICIENT!!!
    
        // Walking Up
        public static Texture2D[] spritesUp = {
    		    Sprite.getSprite(0, 0),
    		    Sprite.getSprite(1, 0),
    		    Sprite.getSprite(2, 0),
    		    Sprite.getSprite(3, 0),
    		    Sprite.getSprite(4, 0),
    		    Sprite.getSprite(5, 0),
    		    Sprite.getSprite(6, 0),
    		    Sprite.getSprite(7, 0)
    		    };
    
        // Walking Down
        public static Texture2D[] spritesDown = {
    		    Sprite.getSprite(0, 180),
    		    Sprite.getSprite(1, 180),
    		    Sprite.getSprite(2, 180),
    		    Sprite.getSprite(3, 180),
    		    Sprite.getSprite(4, 180),
    		    Sprite.getSprite(5, 180),
    		    Sprite.getSprite(6, 180),
    		    Sprite.getSprite(7, 180)
    		    };
    
        // Walking Right
        public static Texture2D[] spritesRight = {
    		    Sprite.getSprite(0, 90),
    		    Sprite.getSprite(1, 90),
    		    Sprite.getSprite(2, 90),
    		    Sprite.getSprite(3, 90),
    		    Sprite.getSprite(4, 90),
    		    Sprite.getSprite(5, 90),
    		    Sprite.getSprite(6, 90),
    		    Sprite.getSprite(7, 90)
    		    };
    
        // Walking Left
        public static Texture2D[] spritesLeft = {
    		    Sprite.getSprite(0, -90),
    		    Sprite.getSprite(1, -90),
    		    Sprite.getSprite(2, -90),
    		    Sprite.getSprite(3, -90),
    		    Sprite.getSprite(4, -90),
    		    Sprite.getSprite(5, -90),
    		    Sprite.getSprite(6, -90),
    		    Sprite.getSprite(7, -90)
    		    };
    
        // Walking Up Right
        public static Texture2D[] spritesUpRight = {
    		    Sprite.getSprite(0, 45),
    		    Sprite.getSprite(1, 45),
    		    Sprite.getSprite(2, 45),
    		    Sprite.getSprite(3, 45),
    		    Sprite.getSprite(4, 45),
    		    Sprite.getSprite(5, 45),
    		    Sprite.getSprite(6, 45),
    		    Sprite.getSprite(7, 45)
    		    };
    
        // Walking Up Left
        public static Texture2D[] spritesUpLeft = {
    		    Sprite.getSprite(0, -45),
    		    Sprite.getSprite(1, -45),
    		    Sprite.getSprite(2, -45),
    		    Sprite.getSprite(3, -45),
    		    Sprite.getSprite(4, -45),
    		    Sprite.getSprite(5, -45),
    		    Sprite.getSprite(6, -45),
    		    Sprite.getSprite(7, -45)
    		    };
    
        // Walking Down Right
        public static Texture2D[] spritesDownRight = {
    		    Sprite.getSprite(0, 135),
    		    Sprite.getSprite(1, 135),
    		    Sprite.getSprite(2, 135),
    		    Sprite.getSprite(3, 135),
    		    Sprite.getSprite(4, 135),
    		    Sprite.getSprite(5, 135),
    		    Sprite.getSprite(6, 135),
    		    Sprite.getSprite(7, 135)
    		    };
    
        // Walking Down Left
        public static Texture2D[] spritesDownLeft = {
    		    Sprite.getSprite(0, -135),
    		    Sprite.getSprite(1, -135),
    		    Sprite.getSprite(2, -135),
    		    Sprite.getSprite(3, -135),
    		    Sprite.getSprite(4, -135),
    		    Sprite.getSprite(5, -135),
    		    Sprite.getSprite(6, -135),
    		    Sprite.getSprite(7, -135)
    		    };

    
        // Idle sprites
        public static Texture2D spriteUp = Sprite.getSprite(0, 0);
        public static Texture2D spriteDown = Sprite.getSprite(0, 180);
        public static Texture2D spriteRight = Sprite.getSprite(0, 90);
        public static Texture2D spriteLeft = Sprite.getSprite(0, -90);

    
        // These are animation states
        public static Animation idleUp = new Animation(spriteUp, 2);
        public static Animation idleDown = new Animation(spriteDown, 2);
        public static Animation idleRight = new Animation(spriteRight, 2);
        public static Animation idleLeft = new Animation(spriteLeft, 2);
        public static Animation walkUp = new Animation(spritesUp, 2);
        public static Animation walkDown = new Animation(spritesDown, 2);
        public static Animation walkRight = new Animation(spritesRight, 2);
        public static Animation walkLeft = new Animation(spritesLeft, 2);
        public static Animation walkUpRight = new Animation(spritesUpRight, 2);
        public static Animation walkUpLeft = new Animation(spritesUpLeft, 2);
        public static Animation walkDownRight = new Animation(spritesDownRight, 2);
        public static Animation walkDownLeft = new Animation(spritesDownLeft, 2);

        // This is the actual animation
        public Animation animation = idleUp;

	    public Player(int x, int y)
        {
            texture = TextureManager.loadTexture("mob/player");
            posX = x;
            posY = y;
        }
	
	    public void Update()
	    {
		    animation.update();
	    }
	
	    public void Draw(SpriteBatch spriteBatch)
	    {
            spriteBatch.Draw(animation.getSprite(), new Rectangle(Ref.screenWidth / 2 - MathHelper.ceil(Ref.tileSize * Ref.pixelSize * Main.pixelScaleWidth / 2), Ref.screenHeight / 2 - MathHelper.ceil(Ref.tileSize * Ref.pixelSize * Main.pixelScaleHeight / 2), 32, 32), Color.White);
	    }
    }
}