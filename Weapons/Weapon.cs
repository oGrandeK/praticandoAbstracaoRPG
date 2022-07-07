using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Models;

namespace AbstraindoRPG.Weapons
{
    public abstract class Weapon : IEquip
    {
        public string WeaponType { get; }

        protected Weapon(Jogador jogador, int damage)
        {
            jogador.WeaponDamage = damage;
        }
    }
}
