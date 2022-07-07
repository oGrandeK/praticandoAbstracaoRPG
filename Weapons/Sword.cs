using AbstraindoRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Weapons
{
    public class Sword : Weapon
    {
        public string WeaponType;
        
        public Sword(Jogador player) : base(player, 100)
        {
            WeaponType = "Sword";
        }
    }
}
