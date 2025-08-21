using System.Text;


string texto = "";
Console.WriteLine("Digite um texto:");
         texto = Console.ReadLine();

        var alteracoes = new Dictionary<char, char>
        {
            { 'a', '@' },
            { 'A', '@' },
            { 'e', '#' },
            { 'E', '#' },
            { 'i', '!' },
            { 'I', '!' },
            { 'o', '$' },
            { 'O', '$' },
            { 'u', '%' },
            { 'U', '%' }
        };

        // StringBuilder é mais eficiente para manipular strings em loop
        var sb = new StringBuilder();

        foreach (char c in texto)
        {
            if (alteracoes.ContainsKey(c))
                sb.Append(alteracoes[c]); // substitui
            else
                sb.Append(c); // mantém igual
        }

        Console.WriteLine("Texto alterado:");
        Console.WriteLine(sb.ToString());
    