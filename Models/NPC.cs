using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraindoRPG.Models
{
    public class NPC : Personagem
    {
        public override string Name { get; }

        public void NPCThing()
        {
            Console.WriteLine($"Hello adventurer, my name is {Name} and i'm a NPC who does NPC things");
        }
    }
}
