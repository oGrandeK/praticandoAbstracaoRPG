using AbstraindoRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Consumables
{
    public static class HpPotion
    {
        // Método em que aumenta a vida do jogador(player)
        public static void UseConsumable(Jogador player)
        {
            player.Health += 50;
        }
    }
}
