using AbstraindoRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Weapons
{
    public class Staff : Weapon
    {
        public string WeaponType;
        public int Damage;

        public Staff(Jogador player) : base(player, 30)
        {
            WeaponType = "Staff";
        }
    }
}
