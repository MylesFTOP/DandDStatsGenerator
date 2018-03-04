<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandDLibrary
{
    public class CharacterManager
    {
        public static List<Character> SetUpSampleCharacters()
        {
            List<Character> characters = new List<Character>();

            characters.Add(new Character { FirstName = "Bob", LastName = "Smith", Strength = 15 } );
            characters.Add(new Character { FirstName = "John", LastName = "Smith", Strength = 12 } );
            characters.Add(new Character { FirstName = "Buffy", LastName = "Summers", Strength = 19 } );
            characters.Add(new Character { FirstName = "Roger", LastName = "Rabbit", Strength = 16 } );
            characters.Add(new Character { FirstName = "Professor", LastName = "Xavier", Strength = 11 } );
            characters.Add(new Character { FirstName = "Robin", LastName = "Locksley", Strength = 14 } );

            return characters;
        }
        
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandDLibrary
{
    public class CharacterManager
    {
        public static List<Character> SetUpSampleCharacters()
        {
            List<Character> characters = new List<Character>();

            characters.Add(new Character { FirstName = "Bob", LastName = "Smith", Strength = 15 } );
            characters.Add(new Character { FirstName = "John", LastName = "Smith", Strength = 12 } );
            characters.Add(new Character { FirstName = "Buffy", LastName = "Summers", Strength = 19 } );
            characters.Add(new Character { FirstName = "Roger", LastName = "Rabbit", Strength = 16 } );
            characters.Add(new Character { FirstName = "Professor", LastName = "Xavier", Strength = 11 } );
            characters.Add(new Character { FirstName = "Robin", LastName = "Locksley", Strength = 14 } );

            return characters;
        }
        
    }
}
>>>>>>> refs/remotes/origin/master
