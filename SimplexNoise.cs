using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plasma_Rev
{
    public class SimplexNoise
    {
        SimplexNoiseOctave[] octaves;
        double[] frequencies;
        double[] amplitudes;

        public SimplexNoise(int numberOfOctaves, double persistence)
        {
            Random random = new Random(Ref.SEED);

            octaves = new SimplexNoiseOctave[numberOfOctaves];
            frequencies = new double[numberOfOctaves];
            amplitudes = new double[numberOfOctaves];

            for (int i = 0; i < numberOfOctaves; i++)
            {
                octaves[i] = new SimplexNoiseOctave(random.Next());

                frequencies[i] = Math.Pow(2, i);
                amplitudes[i] = Math.Pow(persistence, octaves.Length - i);
            }
        }

        public double getNoise(int x, int y)
        {
            double result = 0;

            for (int i = 0; i < octaves.Length; i++)
            {
                result += octaves[i].noise(x / frequencies[i], y / frequencies[i]) * amplitudes[i];
            }

            return result;
        }
    }
}
