using System;

namespace AtomicNomad.game
{
    // Can't be put in class library since Random isn't random unless there's just one instance of it and it can't be static.
    class RNG
    {
        public Random random = new Random();

        public int RandomIntBetween(int int1, int int2)
        {
            return random.Next(int1, int2);
        }
    }
}
