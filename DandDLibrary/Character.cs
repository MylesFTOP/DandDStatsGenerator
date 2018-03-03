using System;
using System.Collections.Generic;
using System.Text;

namespace DandDLibrary
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intellect { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

    }
}
