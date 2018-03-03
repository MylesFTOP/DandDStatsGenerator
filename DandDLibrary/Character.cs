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

        public int ExperiencePoints { get; set; }
        public int HitPoints { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        public double Level
        {
            get
            {
                // Placeholder code - this will need to be updated with proper calculation
                var Level = Math.Floor(ExperiencePoints / 1000d);
                return Level;
            }
        }

    }
}
