using VermillionVanguard.CsharpExtensionMethods;

namespace VermillionVanguard.CsharpExtensionMethods
{
    public static class ArrayExtensions
    {
        // Author: Soft Boiled Games
        /// <summary>
        /// Shuffles the collection using the Fisher-Yates method.
        /// </summary>
        public static void Shuffle<T>(this T[] items)
        {
            if (items.Length == 0)
            {
                return;
            }

            System.Random rng = new System.Random();
            var n = items.Length;

            for (int i = 0; i < n; i++)
            {
                int randomInt = rng.Next(0, i);
                var temp = items[i];
                items[i] = items[randomInt];
                items[randomInt] = temp;
            }
        }

        // Author: Soft Boiled Games
        /// <summary>
        /// Shuffles the collection using the Fisher-Yates method
        /// providing a seed for the random number generator.
        /// </summary>
        /// <param name="seed">Random seed.</param>
        public static void Shuffle<T>(this T[] items, int seed)
        {
            if (items.Length == 0)
            {
                return;
            }
                
            System.Random rng = new System.Random(seed);

            for (int i = items.Length - 1; i > 0; i--)
            {
                int r = rng.Next(i + 1);
                var temp = items[i];
                items[i] = items[r];
                items[r] = temp;
            }
        }

        // Author: Soft Boiled Games
        /// <summary>
        /// Get the first valid index in the collection.
        /// </summary>
        public static int FirstValidIndex<T>(this T[] items)
        {
            return items.Length > 0 ? 0 : -1;
        }

        // Author: github.com/dracolytch/DracoSoftwareExtensionsForUnity
        /// <summary>
        /// For each component in an array, take an action.
        /// </summary>
        /// <param name="callback">The action to be taken.</param>
        public static void ForEachComponent<T>(this T[] array, System.Action<T> callback) where T : UnityEngine.Component
        {
            for (var i = 0; i < array.Length; i++)
            {
                callback.Invoke(array[i]);
            }
        }

        // Author: Soft Boiled Games
        /// <summary>
        /// Returns true if array <paramref name="self"/> contains <paramref name="element"/>.
        /// </summary>
        public static bool Contains<T>(this T[] self, T element)
        {
            if (self.Length == 0)
            {
                return false;
            }

            foreach (T item in self)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
    }
}