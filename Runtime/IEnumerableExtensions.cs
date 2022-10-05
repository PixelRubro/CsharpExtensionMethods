using System.Collections.Generic;
using System.Linq;

namespace SoftBoiledGames.CsharpExtensionMethods
{
    public static class IEnumerableExtensions 
    {
        // Author: github.com/sponticelli.
        /// <summary>
        /// Returns true if the list is null or has 0 object.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> self)
        {
            return self == null || !self.Any();
        }
    }
}