using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agenda_contatos
{

 public class Agenda
    {
        private List<Contato> contatos = new List<Contato>();

        // CREATE
        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // READ
        public void ListarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato na agenda.");
                return;
            }

            Console.WriteLine("\n--- Lista de Contatos ---");
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
        }

        // UPDATE
        public void EditarContato(string nome)
        {
            var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato == null)
            {
                Console.WriteLine("Contato não encontrado!");
                return;
            }

            Console.Write("Novo nome: ");
            contato.Nome = Console.ReadLine();
            Console.Write("Novo telefone: ");
            contato.Telefone = Console.ReadLine();
            Console.Write("Novo email: ");
            contato.Email = Console.ReadLine();

            Console.WriteLine("Contato atualizado com sucesso!");
        }

        // DELETE
        public void RemoverContato(string nome)
        {
            var contato = contatos.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contato == null)
            {
                Console.WriteLine("Contato não encontrado!");
                return;
            }

            contatos.Remove(contato);
            Console.WriteLine("Contato removido com sucesso!");
        }
    }



}