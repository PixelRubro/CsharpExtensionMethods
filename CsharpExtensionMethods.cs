namespace YoukaiFox.CsharpExtensions
{
    public static class CsharpExtensionMethods
    {
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
                Swap(ref items[i], ref items[randomInt]);
            }
        }

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
                Swap(ref items[i], ref items[r]);
            }
        }

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

        /// <summary>
        /// Swap the two values provided.
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
    }
}