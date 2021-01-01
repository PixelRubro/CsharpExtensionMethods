using System.Collections.Generic;

namespace YoukaiFox.CsharpExtensions
{
    public static class ArrayExtensions
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Shuffles the array using the Fisher-Yates method.
        /// </summary>
        /// <param name="items"></param>
        /// <typeparam name="T"></typeparam>
        public static void Shuffle<T>(this T[] items)
        {
            System.Random rng = new System.Random();
            int n = items.Length;

            for (int i = 0; i < n; i++)
            {
                int randomInt = rng.Next(0, i);
                GenericExtensions.Swap(ref items[i], ref items[randomInt]);
            }
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Shuffles the array using the Fisher-Yates method providing a seed for the random number generator.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="seed"></param>
        /// <typeparam name="T"></typeparam>
        public static void Shuffle<T>(this T[] items, int seed)
        {
            System.Random rng = new System.Random(seed);

            for (int i = items.Length - 1; i > 0; i--)
            {
                int r = rng.Next(i + 1);
                GenericExtensions.Swap(ref items[i], ref items[r]);
            }
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Get the first valid index in the collection.
        /// </summary>
        /// <param name="items"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int FirstValidIndex<T>(this T[] items)
        {
            if (items.Length > 0)
                return 0;

            return -1;
        }

        // Author: github.com/dracolytch/DracoSoftwareExtensionsForUnity
        /// <summary>
        /// For each component in an array, take an action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="callback">The action to take</param>
        public static void ForEachComponent<T>(this T[] array, System.Action<T> callback) where T : UnityEngine.Component
        {
            for (var i = 0; i < array.Length; i++)
            {
                callback.Invoke(array[i]);
            }
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns true if array contains element.
        /// </summary>
        /// <param name="element">Element to be searched for in the array.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool Contains<T>(this T[] self, T element)
        {
            if (self.Length == 0)
                return false;

            foreach(T item in self)
            {
                if(item.Equals(element))
                    return true;
            }

            return false;
        }
    }
}