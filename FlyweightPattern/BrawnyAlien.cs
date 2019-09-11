using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class BrawnyAlien : IAlien
    {
        private int hitPoints;
        private string attackMethod;
        private string powerup;

        public BrawnyAlien()
        {
            attackMethod = "Super Punch";
        }

        public void SetPowerup(string newPowerup)
        {
            powerup = newPowerup;
        }

        public void Objective()
        {
            Console.WriteLine("I am a Brawny Alien. I will use my " + attackMethod + " and my " + powerup + " to defeat the Earthlings!");
        }
    }
}
