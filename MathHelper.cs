using System;

namespace Plasma_Rev
{
    public class MathHelper
    {
        public static int ceil(double x)
        {
            return (int)Math.Round(x);
        }

        public static int fastFloor(double x)
        {
            int xi = (int)x;
            return x < xi ? xi - 1 : xi;
        }

        public static double toRad(int deg)
        {
            return (double)(deg * (Math.PI / 180));
        }

        public static int toDeg(double rad)
        {
            return (int)(rad * (180 / Math.PI));
        }
    }
}
