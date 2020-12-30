namespace YoukaiFox.CsharpExtensions
{
    public static class FloatExtensions 
    {
        // Author: Youkai Fox Studio
        /// <summary>
        /// Returns true if compared value is within tolerated equality range.
        /// </summary>
        /// <param name="compared">Number to be compared.</param>
        /// <param name="tolerance">Range on which the number is approximately equals.</param>
        /// <returns></returns>
        public static bool Approximately(this float self, float compared, float tolerance = 0.01f)
        {
            float difference = self - compared;

            if (difference < 0)
                difference *= -1;

            return difference < tolerance;
        }
    }
}