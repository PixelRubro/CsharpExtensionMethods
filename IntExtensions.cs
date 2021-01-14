namespace YoukaiFox.CsharpExtensions
{
    public static class IntExtensions 
    {
        private const string V = "ABCDEFGHIJKLMNOPQRSTUWXYZ";
        const string Alphabet = V;

        public static char ToAlphabetLetter(this int self)
        {
            if ((self < 1) || (self > 25))
            {
                return '\0';
            }

            return Alphabet[self - 1];
        }
    }
}