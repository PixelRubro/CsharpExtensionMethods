using System;

namespace YoukaiFox.CsharpHelper
{
    public static class HelperMethods
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Swap the two values provided between themselves.
        /// </summary>
        public static void Swap<T>(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the smallest value between <paramref name="v1"/>
        /// and <paramref name="v2"/>.
        /// </summary>
        /// <typeparam name="T">A value implementing IComparable interface.</typeparam>
        public static T Min<T>(T v1, T v2) where T : IComparable<T>
        {
            return v1.CompareTo(v2) < 0 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the greatest value between <paramref name="v1"/>
        /// and <paramref name="v2"/>.
        /// </summary>
        /// <typeparam name="T">A value implementing IComparable interface.</typeparam>
        public static T Max<T>(T v1, T v2) where T : IComparable<T>
        {
            return v1.CompareTo(v2) > 0 ? v1 : v2;
        }
    }
}
