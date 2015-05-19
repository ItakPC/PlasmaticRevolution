using System.Collections.Generic;

namespace Plasma_Rev
{
    public class Ref
    {
        // MAIN
        public static string title = "Plasmatic Revolution";
        public static float optimisedSceenWidth = 1920;
        public static float optimisedSceenHeight = 1080;
        public static bool fullscreenWindow = false;
        public static int screenWidth = 800;
        public static int screenHeight = 600;

        // SCREEN
        public static float pixelSize = 3;
        public static int tileSize = 16;

        // GAME THREAD
        public static int updatesSec = 50;
        public static int framesSec = 100;
        public static long maxFSkip = 5;

        // GAME
        public static int SEED;

        // LISTENER
        public static List<int> pressedKeys = new List<int>();
        public static int mouseX;
        public static int mouseY;

        // CHUNK
        public static int tileAmountX = 16;
        public static int tileAmountY = 16;
        public static int chunkAmountX = 5;
        public static int chunkAmountY = 5;
    }
}
