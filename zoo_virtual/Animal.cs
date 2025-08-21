using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zoo_virtual
{
   public abstract class Animal
    {
        public string Nome { get; set; }

        protected Animal(string nome)
        {
            Nome = nome;
        }

        // Método abstrato para ser implementado nas subclasses
        public abstract void EmitirSom();
    }
}