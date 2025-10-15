using FilaManual;

void ExibirFila(Fila fila)
{
    Console.WriteLine("====== EXIBINDO FILA ======");
    fila.ImprimirFila();
    Console.ReadKey();
}

void InserirPessoaNaFila(Fila fila)
{
    Pessoa pessoa = new Pessoa();
    Console.WriteLine("Insira um nome para pessoa: ");
    pessoa.Nome = Console.ReadLine();

    fila.InserirPessoa(pessoa);
}

void RemoverPessoaDaFila(Fila fila)
{
    if (fila.RemoverPessoa())
        Console.WriteLine("Pessoa removida com sucesso!");
    else
        Console.WriteLine("A fila está vazia!");

    Console.ReadKey();
}

void ImprimirPrimeiraPosicaoDaFila(Fila fila)
{
    Pessoa pessoa = fila.PrimeiraPosicao();

    if (pessoa != null)
        Console.WriteLine($"A pessoa em primeira posição é {pessoa.Nome}");
    else
        Console.WriteLine($"Não há pessoa nas filas!");

    Console.ReadKey();
}

void VisualizarTamanhoDaFila(Fila fila)
{
    Console.WriteLine($"A fila possui um total de {fila.TamanhoFila()} pessoas");
    Console.ReadKey();
}

void MenuPrincipal()
{
    Fila fila = new Fila();

    bool repetir = true;
    do
    {
        Console.Clear();

        Console.WriteLine("1 - Inserir pessoa na fila");
        Console.WriteLine("2 - Remover pessoa da fila");
        Console.WriteLine("3 - Imprimir fila");
        Console.WriteLine("4 - Imprimir primeiro elemento da fila");
        Console.WriteLine("5 - Ver tamanho da fila");
        Console.WriteLine("0 - Encerrar programa");
        string opcaoDoUsuario = Console.ReadLine();

        switch (opcaoDoUsuario)
        {
            case "1":
                InserirPessoaNaFila(fila);
                break;
            case "2":
                RemoverPessoaDaFila(fila);
                break;
            case "3":
                ExibirFila(fila);
                break;
            case "4":
                ImprimirPrimeiraPosicaoDaFila(fila);
                break;
            case "5":
                VisualizarTamanhoDaFila(fila);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Programa encerrado!");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                break;
        }
    } while (repetir);
}

MenuPrincipal();