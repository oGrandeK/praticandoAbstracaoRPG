using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Models;

namespace AbstraindoRPG.Classes
{
    public class Knight : IClass
    {
        public string Class { get; } = "Knight";

        public Knight(Jogador player)
        {
            player.Health += 100;
            player.Mana += 0;

            player.Strength += 150;
            player.Armour += 75;
        }
    }
}
