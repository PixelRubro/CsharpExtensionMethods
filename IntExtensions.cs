namespace YoukaiFox.CsharpExtensions
{
    public static class IntExtensions
    {
        // Author: https://github.com/Deadcows
        /// <summary>
        /// Convert arabic numerals to roman numerals.
        /// </summary>
        /// <returns>Roman numeral as string.</returns>
        public static string ToRoman(this int self)
        {
            if (self > 999) return "M" + ToRoman(self - 1000);
            if (self > 899) return "CM" + ToRoman(self - 900);
            if (self > 499) return "D" + ToRoman(self - 500);
            if (self > 399) return "CD" + ToRoman(self - 400);
            if (self > 99) return "C" + ToRoman(self - 100);
            if (self > 89) return "XC" + ToRoman(self - 90);
            if (self > 49) return "L" + ToRoman(self - 50);
            if (self > 39) return "XL" + ToRoman(self - 40);
            if (self > 9) return "X" + ToRoman(self - 10);
            if (self > 8) return "IX" + ToRoman(self - 9);
            if (self > 4) return "V" + ToRoman(self - 5);
            if (self > 3) return "IV" + ToRoman(self - 4);
            if (self > 0) return "I" + ToRoman(self - 1);
            return "";
        }
    }
}