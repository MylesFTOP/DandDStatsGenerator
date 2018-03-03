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

        static void Main(string[] args)
        {
            CharacterManager.SetUpSampleCharacters();
            GreetAllTheCharacters();
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
