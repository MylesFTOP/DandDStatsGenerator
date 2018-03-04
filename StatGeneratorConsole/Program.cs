<<<<<<< HEAD
﻿using DandDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGeneratorConsole
{
    class Program
    {
        private static List<Character> characters = CharacterManager.SetUpSampleCharacters();


        static void Main(string[] args)
        {
            var StrengthMin = 10;
            
            // characters = characters.OrderByDescending(x => x.LastName).ThenByDescending(x => x.Strength).ToList();
            characters = characters.Where(x => x.Strength >= StrengthMin).ToList();

            GreetAllTheCharacters();

            var count = characters.Count(x => x.Strength >= StrengthMin);

            Console.WriteLine($"Count = {count}");

            int strengthTotal = 0;

            // strengthTotal = characters.Sum(x => x.Strength);
            strengthTotal = characters.Where(x => x.Strength >= StrengthMin).Sum(x => x.Strength);

            Console.WriteLine($"Total strength = {strengthTotal}");

            Console.ReadLine();
        }

        private static void GreetAllTheCharacters()
        {
            string StrengthDescription;

            foreach (var character in characters)
            {
                if (character.Strength >= 15) { StrengthDescription = "very"; }
                if (character.Strength <= 11) { StrengthDescription = "not very"; }
                else { StrengthDescription = "pretty"; }
                Console.WriteLine($"Hi, {character.FullName}! You have a Strength of {character.Strength}! You are {StrengthDescription} strong!");
            }
        }
    }
}
=======
﻿using DandDLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatGeneratorConsole
{
    class Program
    {
        private static List<Character> characters = CharacterManager.SetUpSampleCharacters();

        static void Main(string[] args)
        {
            var StrengthMax = 15;

            // characters = characters.OrderByDescending(x => x.LastName).ThenByDescending(x => x.Strength).ToList();
            characters = characters.Where(x => x.Strength >= StrengthMax).ToList();

            GreetAllTheCharacters();

            var count = characters.Count(x => x.Strength >= StrengthMax);

            Console.WriteLine($"Count = {count}");

            int strengthTotal = 0;

            // strengthTotal = characters.Sum(x => x.Strength);
            strengthTotal = characters.Where(x => x.Strength >= StrengthMax).Sum(x => x.Strength);

            Console.WriteLine($"Total strength = {strengthTotal}");

            Console.ReadLine();
        }

        private static void GreetAllTheCharacters()
        {
            foreach (var character in characters)
            {
                Console.WriteLine($"Hi, {character.FirstName} {character.LastName}! You have a Strength of {character.Strength}!");
            }
        }
    }
}
>>>>>>> refs/remotes/origin/master
