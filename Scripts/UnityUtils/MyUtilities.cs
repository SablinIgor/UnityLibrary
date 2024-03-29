using UnityEngine;

namespace UnityUtils
{
    /// <summary>
    /// The main MyUtilities class.
    /// Contains all methods for performing basic math functions.
    /// </summary>
    public class MyUtilities {

        public int c2;
        
        /// <summary>
        /// Something useful.
        /// </summary>        
        public int d3;

        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">A int precision number.</param>
        /// <param name="b">A int precision number.</param>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        public void AddValues(int a, int b) {
            c = a + b;
        }
        
        /// <summary>
        /// Multiply two integers and returns the result.
        /// </summary>
        /// <param name="a">A int precision number.</param>
        /// <param name="b">A int precision number.</param>
        /// <returns>
        /// The multiply of two integers.
        /// </returns>
        public void MultiplyValues(int a, int b) {
            c = a * b;
        }        

        /// <summary>
        /// Generate random number.
        /// </summary>
        /// <param name="min">A lower limit of range.</param>
        /// <param name="max">A upper limit of range.</param>
        /// <returns>Random number</returns>
        public static int GenerateRandom(int min, int max) {
            System.Random rand = new System.Random();
            return rand.Next(min, max);
        }
    }
}
