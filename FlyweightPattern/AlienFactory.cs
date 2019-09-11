using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class AlienFactory
    {
        static Dictionary<string, IAlien> AlienArmy = new Dictionary<string, IAlien>();

        public IAlien prepareAlien(string alienSpecies)
        {
            IAlien newAlien = null;

            if (AlienArmy.ContainsKey(alienSpecies))
            {
                newAlien = AlienArmy.GetValueOrDefault(alienSpecies);
            }
            else
            {
                switch (alienSpecies)
                {
                    case "BrawnyAlien":
                        Console.WriteLine("Brawny Alien has been spawned.");
                        newAlien = new BrawnyAlien();
                        newAlien.SetPowerup("Super Strength");
                        break;

                    case "BigBrainAlien":
                        Console.WriteLine("Big Brain Alien has been spawned.");
                        newAlien = new BigBrainAlien();
                        newAlien.SetPowerup("Telekenesis");
                        break;

                    default:
                        Console.WriteLine("Factory has made an illegal Alien spawn request.");
                        break;

                }
                AlienArmy.Add(alienSpecies, newAlien);
            }
            return newAlien;
        }
    }
}
