using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_virtual
{
    public class Leao : Animal
    {
        public Leao (string nome):base(nome){ }
           public override void EmitirSom() => Console.WriteLine($"{Nome} ruge: Roooooar!");
    }
}