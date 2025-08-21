using agenda_contatos;

Agenda agenda = new Agenda();
            int opcao;

            do
            {
                Console.WriteLine("\n--- Menu Agenda ---");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Listar Contatos");
                Console.WriteLine("3 - Editar Contato");
                Console.WriteLine("4 - Remover Contato");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                    opcao = -1;

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        string telefone = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        agenda.AdicionarContato(new Contato(nome, telefone, email));
                        break;

                    case 2:
                        agenda.ListarContatos();
                        break;

                    case 3:
                        Console.Write("Digite o nome do contato a editar: ");
                        string nomeEditar = Console.ReadLine();
                        agenda.EditarContato(nomeEditar);
                        break;

                    case 4:
                        Console.Write("Digite o nome do contato a remover: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemoverContato(nomeRemover);
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);
