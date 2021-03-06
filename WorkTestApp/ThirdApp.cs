using System;
using System.Text;


namespace WorkTestApp
{
    public static class ThirdApp
    {
        public static bool IsPalindrome(string mytext)
        {
            var cleanMyText = new StringBuilder();

            foreach (var member in mytext)
            {
                if (char.IsLetterOrDigit(member)) cleanMyText.Append(member);
            }

            var cleanString = cleanMyText.ToString().ToLower();

            var symbols = cleanString.ToCharArray();

            Array.Reverse(symbols);

            var backString  = new string(symbols);

            return cleanString == backString;
        }

    }
}
