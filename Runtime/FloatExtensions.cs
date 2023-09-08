namespace VermillionVanguard.CsharpExtensionMethods
{
    public static class FloatExtensions 
    {
        // Author: Soft Boiled Games
        /// <summary>
        /// Checks if <paramref name="self"/> is approximately equal to 
        /// <paramref name="compared"/> within the tolerance 
        /// <paramref name="tolerance"/>
        /// </summary>
        /// <param name="compared">Number to be compared.</param>
        /// <param name="tolerance">Range on which the number is approximately equals.</param>
        /// <returns>Returns true if compared value is within tolerated equality range</returns>
        public static bool Approximately(this float self, float compared, float tolerance = 0.01f)
        {
            float difference = self - compared;

            if (difference < 0)
                difference *= -1;

            return difference < tolerance;
        }
    }
}