using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Classes;
using AbstraindoRPG.Consumables;
using AbstraindoRPG.Weapons;

namespace AbstraindoRPG.Models
{
    public class Jogador : Personagem
    {
        IClass classe;
        IEquip equip;

        public int Health { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int Exp { get; set; } = 0;

        public override string Name { get; }
        public int Strength { get; set; }
        public int Armour { get; set; }
        public int WeaponDamage { get; set; }

        // Construtores --------------------------------------
        public Jogador()
        {

        }

        // Construtor que define os atributos do jogador dependendo de sua classe e sua arma
        // segundo argumento(classe): 1 -> Knight, 2 -> Archer, 3 -> Mage
        // terceiro arumento(equip): 1 -> Sword, 2 -> Bow, 3 -> Staff
        public Jogador(string name, int classe, int equip)
        {
            Name = name;

            if (classe == 1) { this.classe = new Knight(this); }
            if (classe == 2) { this.classe = new Archer(this); }
            if (classe == 3) { this.classe = new Mage(this); }

            if (equip == 1) { this.equip = new Sword(this); }
            if (equip == 2) { this.equip = new Bow(this); }
            if (equip == 3) { this.equip = new Staff(this); }
        }
        ///---------------------------------------------------

        // Métodos -------------------------------------------
        public void Attack()
        {
            Console.WriteLine($"{Name} attacked!");
        }

        // Método em que a instância atual ataca outra instância
        // target -> instância alvo do ataque
        public void Attack(Jogador target)
        {

            Console.WriteLine($"{Name} attacked {target.Name}");
            target.Health -= WeaponDamage;
        }

        // Método que mostra todas as informações úteis da instância
        public void Show()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Mana: {Mana}");
            Console.WriteLine($"Exp: {Exp}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Armour: {Armour}");
            Console.WriteLine("----------------------------------");
        }
        // ---------------------------------------------------

        public override string ToString()
        {
            return $"Name: {Name} \nHealth: {Health}";
        }
    }
}
