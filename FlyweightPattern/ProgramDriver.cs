// Author: Spencer Stewart
// Date: 9/10/2019
// Project: FlyweightPattern

/* Description:
 * 
 * Driver program to test the flyweight pattern functionality of
 * the user.
 * 
 */

using System;

namespace FlyweightPattern
{
    class ProgramDriver
    {
        static void Main(string[] args)
        {

            // Create watch variable to keep of milliseconds. How long the application took to run.
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // Size of the alien army.
            long armySize = 100000000;

            // Tell the user that the army is being created.
            Console.WriteLine("Now creating Home World Army... ... ...\n");

            // Create our factory and random varible.
            AlienFactory HomeWorldFactory = new AlienFactory();
            Random rnd = new Random();

            // Create a list of our army.
            IAlien[] AlienHomeWorldArmy = new IAlien[armySize];

            // for loop to create 10 aliens for our army.
            for (int i = 0; i < armySize; i++)
            {
                if (rnd.Next(1, 3) == 1)
                {
                    AlienHomeWorldArmy[i] = HomeWorldFactory.prepareAlien("BrawnyAlien");
                }
                else
                {
                    AlienHomeWorldArmy[i] = HomeWorldFactory.prepareAlien("BigBrainAlien");
                }
                //AlienHomeWorldArmy[i].Objective();
            }

            // Stop the watch to see the difference.
            watch.Stop();

            // Output how many milliseconds it took to run the code.
            Console.WriteLine("This is how long it took: " + watch.ElapsedMilliseconds);
        }
    }
}
