namespace PixelSpark.CsharpExtensionMethods
{
    public static class BoolExtensions 
    {
        // Author: Soft Boiled Games
        /// <summary>
        /// Converts the boolean to an int value, as in C language.
        /// </summary>
        /// <returns>1 for true and 0 for false.</returns>
        public static int ToInt(this bool self)
        {
            return self ? 1 : 0;
        }
    }
}