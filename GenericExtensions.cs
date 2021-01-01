namespace YoukaiFox.CsharpExtensions
{
    public static class GenericExtensions
    {
        // Author: Youkai Fox Studio
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

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the lesser value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <typeparam name="T"></typeparam>
        public static int Min(int v1, int v2)
        {
            return v1 < v2 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the lesser value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        public static float Min(float v1, float v2)
        {
            return v1 < v2 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the greater value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        public static int Max(int v1, int v2)
        {
            return v1 > v2 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns the greater value between <param name="v1"></param>
        /// and <param name="v2"></param>.
        /// </summary>
        public static float Max(float v1, float v2)
        {
            return v1 > v2 ? v1 : v2;
        }

        // Author: Youkai Fox Studio
        /// <summary>
        /// Checks if <param name="self"> is present in <param name="items">.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="items"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>Returns true if the value is present, false otherwise.</returns>
        public static bool IsIn<T>(this T self, params T[] items)
        {
            if (self == null)
                throw new System.ArgumentNullException("self");

            return items.Contains(self);
        }
    }
}
