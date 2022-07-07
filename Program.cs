using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstraindoRPG.Models;
using AbstraindoRPG.Consumables;

namespace AbstraindoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var mervim = new Jogador("Mervim", 1, 1);
            var vandro = new Jogador("Vandro", 3, 3);

            mervim.Show();
            vandro.Show();

            mervim.Attack(vandro);
            vandro.Attack(mervim);

            vandro.Show();
            mervim.Show();

            HpPotion.UseConsumable(mervim);
            MpPotion.UseConsumable(mervim);
            mervim.Show();



            Console.ReadKey();


        }
    }
}