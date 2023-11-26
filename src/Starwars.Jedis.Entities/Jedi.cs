using System;
using System.Text;

namespace Starwars.Jedis.Entities
{
    public class Jedi
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public double Power { get; set; }
        public bool IsEnabled { get; set; }

        public string PowerFormatted { 
            get 
            {
                return string.Format("{0:N3}%", Power);
            } 
        }

        public Jedi(int id, string name)
        {
            Id = id;
            Name = name;
            Power = GetRandomNumber(1, id);
        }

        /// <summary>
        /// Return the name to format url. 
        /// Example: Obi-Wan Kenobi > obi-wan-kenobi
        /// </summary>
        public string Endpoint { 
            get{
                return StringHelper.RemoveSpecialCharacters(
                       StringHelper.RemoveDiacritics(
                           Name.Replace(Constants.WHITESPACE_CHAR, Constants.HYPHEN_CHAR)))
                       .ToLower();
            } 
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            var random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }

    }
}
