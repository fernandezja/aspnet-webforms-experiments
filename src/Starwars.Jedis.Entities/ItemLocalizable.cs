using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Starwars.Jedis.Entities
{
    public class ItemLocalizable
    {
        public string Language { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }

        public ItemLocalizable(string language, string key, string value)
        {
            Language = language;
            Key = key;
            Value = value;
        }


        /// <summary>
        /// Return the name to format url. 
        /// Example: Obi-Wan Kenobi > obi-wan-kenobi
        /// </summary>
        public string Endpoint
        {
            get
            {
                return StringHelper.RemoveSpecialCharacters(
                       StringHelper.RemoveDiacritics(
                           Value.Replace(Constants.WHITESPACE_CHAR, Constants.HYPHEN_CHAR)))
                       .ToLower();
            }
        }
    }
}
