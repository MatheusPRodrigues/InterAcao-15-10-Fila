// Simulação de Atendimento em um Banco

using FilaAtendimentoBanco;

void AdicionarClienteNaFila(Cliente cliente, Banco banco)
{
    if (cliente.EhPrioritario)
        banco.FilaPrioritaria.Enfileirar(cliente);
    else
        banco.FilaNormal.Enfileirar(cliente);
}

void AdicionarCliente(Banco banco)
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();

    Console.Write("Digite a idade do cliente: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Cliente pessoa = new Cliente(nome, idade);
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

void ExibirCliente(Cliente cliente)
{
    Console.Clear();
    Console.WriteLine("===== CHAMANDO =====");
    Console.WriteLine($"Nome: {cliente.Nome}");
    Console.WriteLine($"Idade: {cliente.Idade}");
    Console.ReadKey(); 
}

void AtenderCliente(Banco banco)
{
    Cliente clienteParaAtender = banco.AtenderCliente();

    //TODO: Verificar se condição clienteParaAtender.Nome != null continua necessária
    if (clienteParaAtender != null)
    {
        ExibirCliente(clienteParaAtender);
        MostrarFilas(banco);
    }
    else if (clienteParaAtender == null)
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
                MostrarFilas(banco);
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