using System;

namespace VermillionVanguard.CsharpExtensionMethods
{
    public static class GenericExtensions
    {
        // Author: Soft Boiled Games
        /// <summary>
        /// Checks if value is present in the provided array.
        /// </summary>
        public static bool IsIn<T>(this T self, params T[] items)
        {
            if (self == null)
                throw new System.ArgumentNullException("self");

            return items.Contains(self);
        }

        // Author: From Stack Overflow.
        /// <summary>
        /// Checks if <paramref name="self"/> value is between the values of the
        /// lower bound <paramref name="lower"/> (inclusive) and of the upper
        /// bound <paramref name="upper"/> (exclusive).
        /// </summary>
        /// <typeparam name="T">Any type implementing IComparable interface.</typeparam>
        public static bool IsBetween<T>(this T self, T lower, T upper)
            where T : IComparable<T>
        {
            return self.CompareTo(lower) >= 0 && self.CompareTo(upper) < 0;
        }
    }
}
