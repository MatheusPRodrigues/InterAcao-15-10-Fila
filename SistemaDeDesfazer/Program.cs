//  Sistema de Desfazer (Undo) de Editor de Texto

using SistemaDeDesfazer;

void DigitarNovoTexto(EditorTexto e)
{
    Console.WriteLine("Digite o texto:");
    string texto = Console.ReadLine();

    e.Digitar(texto);
}

void DesfazerUltimaAcao(EditorTexto e)
{
    Texto texto = e.Desfazer();

    if (texto != null)
    {
        Console.WriteLine("====== ÚLTIMA AÇÃO ======");
        Console.WriteLine(e.Desfazer());
    }
    else
        Console.WriteLine("Não foi realizada nenhuma ação até o momento!");

    Console.ReadKey();
}

void MostarHistorico(EditorTexto e)
{
    Console.WriteLine("============ TEXTO ============");
    e.MostrarHistorico();
    Console.ReadKey();
}

void MenuPrincipal()
{
    EditorTexto editorTexto = new EditorTexto();
    editorTexto.Historico = new Pilha(10);

    bool repetir = true;
    do
    {
        Console.Clear();

        Console.WriteLine("1 - Digitar novo texto");
        Console.WriteLine("2 - Desfazer última ação");
        Console.WriteLine("3 - Mostrar histórico");
        Console.WriteLine("0 - Sair");
        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                DigitarNovoTexto(editorTexto);
                break;
            case "2":
                DesfazerUltimaAcao(editorTexto);
                break;
            case "3":
                MostarHistorico(editorTexto);
                break;
            case "0":
                Console.Clear();
                Console.WriteLine("Sistema encerrado!");
                repetir = false;
                break;
            default:
                Console.WriteLine("Opção inválida! Tente novamente!");
                Console.ReadKey();
                break;
        }
    }
    while (repetir);
}

MenuPrincipal();