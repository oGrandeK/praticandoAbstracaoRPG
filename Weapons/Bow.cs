using AbstraindoRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Weapons
{
    public class Bow : Weapon
    {
        public string WeaponType;
        public int Damage;

        public Bow(Jogador player) : base(player, 45)
        {
            WeaponType = "Bow";
        }
    }
}
