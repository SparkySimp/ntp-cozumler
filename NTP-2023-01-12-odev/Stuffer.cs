﻿using System;
using Debug = System.Diagnostics.Debug;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Text;

namespace SparkySimp.ArrayUtils
{
    /// <summary>
    /// Provides methods to stuff arrays with random numbers.
    /// </summary>
    static public class Stuffer
    {
        /// <summary>
        /// Alias for <see cref="Stuffer.GenerateUniqueRandomNumbers(int, int, int, int?)"/>.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="prngSeed"></param>
        /// <returns></returns>
        public static int[] GenerateUnique(int count, int max = Int32.MaxValue, int min = Int32.MinValue, int? prngSeed = null) 
            => GenerateUniqueRandomNumbers(count, max: max, min: min, prngSeed: prngSeed);
        /// <summary>
        /// Generates a set of unique random numbers.
        /// </summary>
        /// <param name="count">The amount of numbers to produce</param>
        /// <param name="max">Maximum possible number.</param>
        /// <param name="min">Minimum possible number.</param>
        /// <returns>The set of generated numbers.</returns>
        /// <exception cref="InvalidOperationException">Thrown when number count is not positive, or when the minimum value is lower than the number count. </exception>
        public static int[] GenerateUniqueRandomNumbers(int count, int max = Int32.MaxValue, int min = Int32.MinValue, int? prngSeed = null)
        {
            Random prng = new Random(prngSeed ?? DateTime.UtcNow.Ticks.GetHashCode());
            if (count <= 0)
                throw new InvalidOperationException(message: "Amount of numbers to generate must be positive.");
            // I'm smelling some mistakes here.
            int[] numbers = new int[count];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = -1;
            }
            int generatedNumber = prng.Next(min, max);
            for (int i = 0; i < numbers.Length; i++) // Special thanks to Emrah Porgalı...
            {
                if (Array.IndexOf(numbers, generatedNumber = prng.Next(min, max)) == -1)
                {
                    Debug.WriteLine(generatedNumber);
                    numbers[i] = generatedNumber;
                }
                else i--; // repeat this iteration.
            }
            return numbers;
        }

        /// <summary>
        /// Generates random bytes of specified amount
        /// </summary>
        /// <param name="count">Count of bytes to produce.</param>
        /// <param name="prngSeed">Random numb</param>
        /// <returns>A set of random bytes.</returns>
        public static byte[] GenerateRandomBytes(int count, int? prngSeed = null)
        {
            byte[] bytes = new byte[count];
            Random prng = new Random(Seed: prngSeed ?? DateTime.UtcNow.Ticks.GetHashCode());
            prng.NextBytes(bytes);
            return bytes;
        }
    }
    /// <summary>
    /// Implements <see cref="IComparable{Bitmap}.CompareTo(Bitmap)"/>.
    /// </summary>
    static public class BmpComparer
    {
        public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }
        public static int CompareTo(this Bitmap self, Bitmap other)
        {
            if (GetHash(self) != GetHash(other))
                return 1;
            else return 0;
        }
    }
}
