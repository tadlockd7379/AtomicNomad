using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicNomad.game
{
    class Player : LivingEntity
    {
        public Player(string id, double hp, double attackPower) : base(id, "the main player of the game", hp, attackPower)
        {
            // stuff here in the future for player only
        }
    }
}
