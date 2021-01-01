using System;

namespace YoukaiFox.CsharpExtensions
{
    public static class GenericExtensions
    {
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
