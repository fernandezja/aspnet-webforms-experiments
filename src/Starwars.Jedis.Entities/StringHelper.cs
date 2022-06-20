using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Starwars.Jedis.Entities
{
    public abstract class StringHelper
    {
        public static string RemoveSpecialCharacters(string text)
        {
            var sb = new StringBuilder();

            foreach (char c in text)
            {
                if ((c >= '0' && c <= '9')
                    || (c >= 'A' && c <= 'Z')
                    || (c >= 'a' && c <= 'z')
                    || c == '-')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            
            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
