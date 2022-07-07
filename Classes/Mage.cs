using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Models;

namespace AbstraindoRPG.Classes
{
    public class Mage : IClass
    {
        public string Class { get; } = "Mage";

        public Mage(Jogador player)
        {
            player.Health += 50;
            player.Mana += 100;

            player.Strength += 0;
            player.Armour += 30;
        }
    }
}
