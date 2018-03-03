using System;
using System.Collections.Generic;
using System.Text;

namespace DandDLibrary
{
    class Die
    {
        // Individual die roll. Will be extended by subclasses for d4, d6, d20.

        public int Result { get; set; }

        // Also add method to roll, which randomly returns an integer greater than zero. 
        // Preferably has a max value for range that can be set separately, so only this needs to be overridden.
    }
}
