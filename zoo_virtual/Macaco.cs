using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_virtual
{
    public class Macaco : Animal
    {
        public Macaco(string nome) : base(nome) { }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} grita: Uh uh ah ah!");
        }
    }
}