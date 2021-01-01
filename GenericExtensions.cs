using System;

namespace YoukaiFox.CsharpExtensions
{
    public static class GenericExtensions
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Swap the two values provided between themselves.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <typeparam name="T"></typeparam>
        public static void Swap<T>(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the lesser value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <typeparam name="T"></typeparam>
        public static T Min<T>(T v1, T v2) where T : IComparable<T>
        {
            return v1.CompareTo(v2) < 0 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the greater value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        public static T Max(int v1, int v2)
        {
            return v1.CompareTo(v2) > 0 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Checks if <param name="self"></param> is present
        /// in the collection in <param name="items"></param>
        /// </summary>
        /// <returns>Returns true if the value is present, false otherwise.</returns>
        public static bool IsIn<T>(this T self, params T[] items)
        {
            if (self == null)
                throw new System.ArgumentNullException("self");

            return items.Contains(self);
        }

        // Author: From Stack Overflow.
        /// <summary>
        /// Checks if <param name="self"> is between <param name="lower">
        /// (inclusive) and <param name="upper"> (exclusive).
        /// </summary>
        /// <typeparam name="T">Any type implementing IComparable interface.</typeparam>
        /// <returns>Returns true if it's between the values.</returns>
        public static bool IsBetween<T>(this T self, T lower, T upper)
            where T : IComparable<T>
        {
            return self.CompareTo(lower) >= 0 && self.CompareTo(upper) < 0;
        }
    }
}
