var animais = new Dictionary<int, zoo_virtual.Animal>
            {
                { 1, new zoo_virtual.Leao("lion") },
                { 2, new zoo_virtual.Macaco("monkey") },
                { 3, new zoo_virtual.Elefante("fante") }
            };

            while (true)
            {
                Console.WriteLine("\n=== Zoo Virtual ===");
                Console.WriteLine("Escolha um animal para visitar:");
                Console.WriteLine("1 - Leão");
                Console.WriteLine("2 - Macaco");
                Console.WriteLine("3 - Elefante");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                string? entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out int opcao))
                {
                    Console.WriteLine("Entrada inválida. Digite um número.");
                    continue;
                }

                if (opcao == 0)
                {
                    Console.WriteLine("Até logo!");
                    break;
                }

                if (animais.TryGetValue(opcao, out var animal))
                {
                    Console.WriteLine($"\nVisitando {animal.Nome}...");
                    animal.EmitirSom();
                }
                else
                {
                    Console.WriteLine("Opção inexistente. Tente novamente.");
                }
            }
    