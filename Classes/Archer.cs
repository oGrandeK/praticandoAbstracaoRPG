using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Models;

namespace AbstraindoRPG.Classes
{
    public class Archer : IClass
    {
        public string Class { get; } = "Archer";

        public Archer(Jogador player)
        {
            player.Health += 75;
            player.Mana += 50;

            player.Strength += 50;
            player.Armour += 50;
        }
    }
}
