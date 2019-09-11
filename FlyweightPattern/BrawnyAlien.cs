// Author: Spencer Stewart
// Date: 9/10/2019
// Project: FlyweightPattern

/* Description:
 * 
 * Class that holds the definitions for Brawny Alien.
 * Inherits from the IAlien interface.
 * 
 */

using System;

namespace FlyweightPattern
{
    // Brawny Alien class definitions.
    class BrawnyAlien : IAlien
    {
        
        // Privates variables for the class
        private string attackMethod;
        private string powerup;

        // Give our Brawny Alien Super Punch for an attackMethod.
        public BrawnyAlien()
        {
            attackMethod = "Super Punch";
        }

        // Set the super power up for the brawny alien. Providing a little flexibility for which ability.
        public void SetPowerup(string newPowerup)
        {
            powerup = newPowerup;
        }

        // State the alien's objective.
        public void Objective()
        {
            Console.WriteLine("...Brawny Alien spawned...");
            Console.WriteLine("I am a Brawny Alien. I will use my " + attackMethod + " and my " + powerup + " to defeat the Earthlings!\n");
        }
    }
}
