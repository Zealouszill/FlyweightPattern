using System;

namespace FlyweightPattern
{
    class ProgramDriver
    {
        static void Main(string[] args)
        {
            AlienFactory HomeWorldFactory = new AlienFactory();
            Random rnd = new Random();

            IAlien[] AlienHomeWorldArmy = new IAlien[10];

            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(1, 3) == 1)
                {
                    AlienHomeWorldArmy[i] = HomeWorldFactory.prepareAlien("BrawnyAlien");
                }
                else
                {
                    AlienHomeWorldArmy[i] = HomeWorldFactory.prepareAlien("BigBrainAlien");
                }
                AlienHomeWorldArmy[i].Objective();
            }
        }
    }
}
