using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_virtual
{
   public class Elefante : Animal
    {
        public Elefante(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} trombeta: Pruuuuuuu!");
        }
    }
}