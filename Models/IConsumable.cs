using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Models
{
    internal interface IConsumable
    {
        public static void UseConsumable(Jogador player)
        {
            player.Mana += 0;
        }
    }
}
