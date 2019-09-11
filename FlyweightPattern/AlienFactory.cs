// Author: Spencer Stewart
// Date: 9/10/2019
// Project: FlyweightPattern

/* Description:
 * 
 * AlienFactory is a class that will create a specific kind of alien, per the request
 * of the calling class/function.
 * 
 * If this certain model of enemy doesn't exist, make it and store it.
 * If it already exists, pull from the model we already have.
 * 
 */

using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    class AlienFactory
    {

        // Create a dictionary to hold all of our different types of aliens.
        static Dictionary<string, IAlien> AlienArmy = new Dictionary<string, IAlien>();

        // Function to create an alien.
        public IAlien prepareAlien(string alienSpecies)
        {
            // Create out alien.
            IAlien newAlien = null;

            /***********************************
             Code Segment show the shorter time
            ***********************************

            // If the alien model already exists, use it. Otherwise make a new one.
            if (AlienArmy.ContainsKey(alienSpecies))
            {
                newAlien = AlienArmy.GetValueOrDefault(alienSpecies);
            }
            else
            {
                switch (alienSpecies)
                {
                    // Create a Brawny Alien.
                    case "BrawnyAlien":
                        Console.WriteLine("Brawny Alien model has been created.");
                        newAlien = new BrawnyAlien();
                        newAlien.SetPowerup("Super Strength");
                        break;

                    // Create a Big Brain Alien.
                    case "BigBrainAlien":
                        Console.WriteLine("Big Brain Alien model has been created.");
                        newAlien = new BigBrainAlien();
                        newAlien.SetPowerup("Telekenesis");
                        break;

                    // Obligatory default statement.
                    default:
                        Console.WriteLine("Factory has made an illegal Alien spawn request.");
                        break;
                }

                // Add our alien model to our dictionary.
                AlienArmy.Add(alienSpecies, newAlien);

            }

            /**********************************
             Code Segment show the longer time
            **********************************/

            switch (alienSpecies)
            {
                // Create a Brawny Alien.
                case "BrawnyAlien":
                    newAlien = new BrawnyAlien();
                    newAlien.SetPowerup("Super Strength");
                    break;

                // Create a Big Brain Alien.
                case "BigBrainAlien":
                    newAlien = new BigBrainAlien();
                    newAlien.SetPowerup("Telekenesis");
                    break;

                // Obligatory default statement.
                default:
                    Console.WriteLine("Factory has made an illegal Alien spawn request.");
                    break;
            }

            /**********************************/

            // Return the alien to the called function.
            return newAlien;
        }
    }
}
