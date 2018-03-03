using System;
using System.Collections.Generic;
using System.Text;

namespace DandDLibrary
{
    class CharacterManager
    {
        public static List<Character> SetUpSampleCharacters()
        {
            List<Character> list = new List<Character>();

            list.Add(new Character { FirstName = "Bob", LastName = "Smith", Strength = 15 });
            list.Add(new Character { FirstName = "John", LastName = "Smith", Strength = 12 });
            list.Add(new Character { FirstName = "Buffy", LastName = "Summers", Strength = 19 });
            list.Add(new Character { FirstName = "Sarah Jessica", LastName = "Parker", Strength = 16 });
            list.Add(new Character { FirstName = "Professor", LastName = "Xavier", Strength = 11 });
            list.Add(new Character { FirstName = "Robin", LastName = "Locksley", Strength = 14 });

            return list;
        }
        
    }
}
