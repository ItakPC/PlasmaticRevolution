using System;
using System.Collections;
using System.Collections.Generic;
namespace Plasma_Rev
{
    public class Material
    {
        public static Material GRASS = new Material("grass");
        public static Material WATER = new Material("water");
        public static Material DEEPWATER = new Material("deepwater");
        public static Material SAND = new Material("sand");
        public static Material ROCK = new Material("rock");

        private List<string> reseourceIds;

        public Material(string resourceId)
        {
            reseourceIds = new List<string>();
            reseourceIds.Add(resourceId);
        }

        public string getResourceId(int i)
        {
            return reseourceIds[i];
        }
        Random r = new Random();
        public string getRandomResourceId()
        {
            return reseourceIds[r.Next(reseourceIds.Count)];
        }
    }
}