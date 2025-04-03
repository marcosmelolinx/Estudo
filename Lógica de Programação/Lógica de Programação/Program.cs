




while (true){
    System.Console.WriteLine("\n Hello, World!");

    System.Console.WriteLine("O que deseja fazer?");
    System.Console.WriteLine("1 - Verificar se um número é perfeito");
    System.Console.WriteLine("2 - Verificar se um número é primo");
    System.Console.WriteLine("0 - Sair do programa");

    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            NumeroPerfeito numeroPerfeito = new NumeroPerfeito();
            numeroPerfeito.VerificarNumeroPerfeito();
            break;
        case 2:
            VerificarPrimo verificarPrimo = new VerificarPrimo();
            verificarPrimo.VerificarEhPrimo();
            break;
        case 0:
            System.Console.WriteLine("Você saiu do programa.");
            return;
        default:
            System.Console.WriteLine("Opção inválida.");
            break;
    }
}