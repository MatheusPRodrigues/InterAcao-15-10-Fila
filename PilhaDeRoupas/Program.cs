// Pilha de Roupas

using PilhaDeRoupas;

void ExibirInfoDasRoupas(Roupa r)
{
    Console.Clear();

    Console.WriteLine("===== ROUPA SELECIONADA =====");
    Console.WriteLine($"Categoria: {r.Categoria}");
    Console.WriteLine($"Cor: {r.Cor}");
}

void EmpilharRoupa(Pilha p)
{
    Roupa roupa = new Roupa();

    Console.Write("Digite a categoria da roupa: ");
    roupa.Categoria = Console.ReadLine();
    
    Console.Write("Digite a cor da roupa: ");
    roupa.Cor = Console.ReadLine();

    p.Empilhar(roupa);
}

void PegarUmaRoupaDaPilha(Pilha p)
{
    Roupa roupa = p.Desempilhar();

    if (roupa == null)
        Console.WriteLine("Não há nenhuma roupa na pilha!");
    else
        ExibirInfoDasRoupas(roupa);

    Console.ReadKey();
}

void ExibirRoupas(Pilha p)
{
    Console.Clear();

    Console.WriteLine("====== EXIBINDO ROUPAS ======");
    p.ExibirPilha();

    Console.ReadKey();
}

void MenuPrincipal()
{
    Pilha pilha = new Pilha();

    bool repetir = true;
    do
    {
        Console.Clear();

        Console.WriteLine("====== PILHA DE ROUPAS ======");
        Console.WriteLine("1 - Empihar roupa");
        Console.WriteLine("2 - Pegar uma roupa");
        Console.WriteLine("3 - Exibir roupas");
        Console.WriteLine("0 - Sair");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                EmpilharRoupa(pilha);
                break;
            case "2":
                PegarUmaRoupaDaPilha(pilha);
                break;
            case "3":
                ExibirRoupas(pilha);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Programa encerrado");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                break;
        }
    }
    while (repetir);
}

MenuPrincipal();