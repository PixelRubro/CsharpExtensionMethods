using System.Collections.Generic;

namespace YoukaiFox.CsharpExtensions
{
    public static class DictionaryExtensions 
    {
        // Author: github.com/sponticelli.
        /// <summary>
        /// Adds the <paramref name="key"/>-<paramref name="value"/> pair if it doesn't contain the <paramref name="key"/> already.
        /// Returns true if pair is added, false otherwise.
        /// </summary>
        public static bool AddIfNotContains<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key,
            TValue value)
        {
            if (self.ContainsKey(key))
            {
                return false;
            }

            self.Add(key, value);
            return true;
        }

        // Author: github.com/sponticelli.
        /// <summary>
        /// If <paramref name="self"/> contains <paramref name="key"/>, sets the value to <paramref name="value"/>;
        /// otherwise adds a new <paramref name="key"/>-<paramref name="value"/> pair to it.
        /// Returns true if pair is added, false otherwise.
        /// </summary>
        public static bool AddOrSet<TKey, TValue>(this IDictionary<TKey, TValue> self, TKey key, TValue value)
        {
            if (self.ContainsKey(key))
            {
                self[key] = value;
                return false;
            }

            self.Add(key, value);
            return true;
        }
    }
}