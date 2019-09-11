// Author: Spencer Stewart
// Date: 9/10/2019
// Project: FlyweightPattern

/* Description:
 * 
 * Interface to create multiple different kinds of aliens.
 * 
 */

namespace FlyweightPattern
{
    interface IAlien
    {
        void SetPowerup(string newPowerup);
        void Objective();

    }
}
