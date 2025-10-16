// Simulação de Atendimento em um Banco

using FilaAtendimentoBanco;

void AdicionarClienteNaFila(Pessoa pessoa, Banco banco)
{
    if (pessoa.EhPrioritario)
        banco.FilaPrioritaria.Enfileirar(pessoa);
    else
        banco.FilaNormal.Enfileirar(pessoa);
}

bool AdicionarPrioridade()
{
    string opcaoDePrioridade;
    do
    {
        Console.Write("(1 - Prioridade | 2 - Normal): ");
        opcaoDePrioridade = Console.ReadLine();
    }
    while (opcaoDePrioridade != "1" && opcaoDePrioridade != "2");

    if (opcaoDePrioridade == "1")
        return true;
    else
        return false;
}

void AdicionarCliente(Banco banco)
{
    Console.Write("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();

    Console.Write("Digite a idade da pessoa: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Pessoa pessoa = new Pessoa(nome, idade, AdicionarPrioridade());
    AdicionarClienteNaFila(pessoa, banco);
}

void ExibirFilaPrioritaria(Banco banco)
{
    Console.WriteLine($"===== FILA PRIORITÁRIA - TAMANHO: {banco.FilaPrioritaria.Tamanho()} =====");
    banco.FilaPrioritaria.MostrarFila();
}

void ExibirFilaNormal(Banco banco)
{
    Console.WriteLine($"===== FILA NORMAL - TAMANHO: {banco.FilaNormal.Tamanho()} =====");
    banco.FilaNormal.MostrarFila();
}

void MostrarFilas(Banco banco)
{
    Console.Clear();
    ExibirFilaPrioritaria(banco);
    Console.WriteLine();
    ExibirFilaNormal(banco);
    Console.ReadKey();
}

void ExibirCliente(Pessoa pessoa)
{
    Console.Clear();
    Console.WriteLine("===== CHAMANDO =====");
    Console.WriteLine($"Nome: {pessoa.Nome}");
    Console.WriteLine($"Idade: {pessoa.Idade}");
}

void AtenderCliente(Banco banco)
{
    Pessoa pessoaParaAtender = banco.AtenderCliente();
    if (pessoaParaAtender != null && pessoaParaAtender.Nome != null)
        ExibirCliente(pessoaParaAtender);
    else if (pessoaParaAtender == null)
        Console.WriteLine("Não há mais clientes para serem atendidos!");

    Console.ReadKey();
}

void MenuPrincipal()
{
    Banco banco = new Banco();

    bool repetir = true;
    do
    {
        Console.Clear();
        Console.WriteLine("======= BANCO =======");
        Console.WriteLine("[1] Adicionar cliente");
        Console.WriteLine("[2] Atender próximo cliente");
        Console.WriteLine("[3] Mostrar fila");
        Console.WriteLine("[0] Sair");
        Console.Write("=> ");
        string opcao = Console.ReadLine() ?? "-1";

        switch (opcao)
        {
            case "1":
                AdicionarCliente(banco);
                break;
            case "2":
                AtenderCliente(banco);
                break;
            case "3":
                MostrarFilas(banco);   
                break;
            case "0":
                Console.Clear();
                repetir = false;
                Console.WriteLine("Programa finalizado");
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                break;
        }
    }
    while (repetir);
}

MenuPrincipal();