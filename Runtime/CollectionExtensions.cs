using System.Collections.Generic;

namespace VermillionVanguard.CsharpExtensionMethods
{
    public static class CollectionExtensions 
    {
        
        // Author: From Stack Overflow.
        /// <summary>
        /// Add multiple items to a collection at once.
        /// </summary>
        /// <param name="elements">Items to be added.</param>
        public static void AppendRange<T, S>(this ICollection<T> self, params S[] elements)
            where S : T
        {
            foreach (S item in elements)
            {
                self.Add(item);
            }
        }

        // Author: github.com/sponticelli.
        /// <summary>
        /// Adds item if it doesn't contain the <paramref name="item"/> already.
        /// Returns true if <paramref name="item"/> is added, false otherwise.
        /// </summary>
        public static bool AddIfNotContains<T>(this ICollection<T> self, T item)
        {
            if (self.Contains(item))
                return false;

            self.Add(item);
            return true;
        }
    }
}