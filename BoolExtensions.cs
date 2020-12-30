namespace YoukaiFox.CsharpExtensions
{
    public static class BoolExtensions 
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Converts the boolean to an int value, as in C language.
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int ToInt(this bool self)
        {
            return self ? 1 : 0;
        }
    }
}