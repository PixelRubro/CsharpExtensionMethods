using System.Collections.Generic;

namespace YoukaiFox.CsharpExtensions
{
    public static class CollectionExtensions 
    {
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