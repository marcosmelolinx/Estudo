using Estudo.Aplication.Commands;
using Estudo.Domain.Modal;
using Estudo.Domain.UI.Commands;
using Estudo.UI.ConsoleApp.Service;

class Program
{
    static void Main(string[] args)
    {

        var contaService = new ContaService();

        string nome = contaService.LerNome();

        ContaBancaria conta = new ContaBancaria(nome, "Bradesco", 0);
        ICommand depositar = new DepositarCommand(conta,10);
        ICommand sacar = new SacarCommand(conta, 5);

        ICommandHandler invoke = new ICommandHandler();

        invoke.SetCommand(depositar);
        invoke.ExecuteCommand();
        invoke.SetCommand(sacar);
        invoke.ExecuteCommand();
        invoke.UndoCommand();

        Console.WriteLine(conta.Saldo);
        Console.ReadKey();

    }
}