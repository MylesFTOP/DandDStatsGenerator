using DandDLibrary;
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
