namespace YoukaiFox.SystemExtensions
{
    public static class ExtensionMethods
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
                Swap(items[i], items[randomInt]);
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
        /// Swap the two values provided between themselves.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <typeparam name="T"></typeparam>
        public static void Swap<T>(T v1, T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}