using System;

namespace NomadLibrary
{
    public class RNG
    {
        public Random random = new Random();

        public int RandomIntBetween(int int1, int int2)
        {
            return random.Next(int1, int2);
        }
    }
}
