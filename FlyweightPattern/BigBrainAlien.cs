using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class BigBrainAlien : IAlien
    {
        private int hitPoints;
        private string attackMethod;
        private string powerup;

        public BigBrainAlien()
        {
            attackMethod = "Mind Control";
        }
        public void SetPowerup(string newPowerup)
        {
            powerup = newPowerup;
        }

        public void Objective()
        {
            Console.WriteLine("I am a Big Braing Alien. I will use my " + attackMethod + " and my " + powerup + " to defeat the Earthlings!");
        }
    }
}
