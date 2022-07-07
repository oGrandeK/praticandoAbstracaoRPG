using AbstraindoRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Consumables
{
    public static class MpPotion
    {
        // Método em que aumenta a mana do jogador(player)
        public static void UseConsumable(Jogador player)
        {
            player.Mana += 50;
        }
    }
}
