// Author: Spencer Stewart
// Date: 9/10/2019
// Project: FlyweightPattern

/* Description:
 * 
 * Class that holds the definitions for Big Brain Alien.
 * Inherits from the IAlien interface.
 * 
 */


using System;

namespace FlyweightPattern
{
    // BigBrainAlien definitions.
    class BigBrainAlien : IAlien
    {
        // Private variables for our class.
        private string attackMethod;
        private string powerup;

        // Give the Big brain alien mind control powers.
        public BigBrainAlien()
        {
            attackMethod = "Mind Control";
        }
        
        // Give the alien a new power up, whatever it may be.
        public void SetPowerup(string newPowerup)
        {
            powerup = newPowerup;
        }

        // Give the objective of the alien.
        public void Objective()
        {
            Console.WriteLine("...Big Brain Alien spawned...");
            Console.WriteLine("I am a Big Braing Alien. I will use my " + attackMethod + " and my " + powerup + " to defeat the Earthlings!\n");
        }
    }
}
