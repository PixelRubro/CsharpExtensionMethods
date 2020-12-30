namespace YoukaiFox.CsharpExtensions
{
    public static class MiscExtensions
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
    }
}
