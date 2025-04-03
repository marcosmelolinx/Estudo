using Estudo.Aplication.Commands;
using Estudo.Domain.Modal;
using Estudo.Domain.UI.Commands;
using Estudo.UI.ConsoleApp.Service;
using Estudo.Aplication.Handlers;
using Estudo.Core;
using Estudo.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        var dispatcher = new CommandDispatcher();
        var conta = new ContaBancaria("Marcos", "Itau", 10);

        var contaService = new ContaService();

        string nome = contaService.LerNome();
        Console.WriteLine(conta.Nome);

        // Registra os handlers antes de enviar os comandos
        dispatcher.RegisterHandler(new DepositarCommandHandler());
        dispatcher.RegisterHandler(new SacarCommandHandler());
        dispatcher.RegisterHandler(new PedidoCommandHandler());

        ContaBancaria conta = new ContaBancaria(nome, "Bradesco", 0);
        ICommand depositar = new DepositarCommand(conta,10);
        ICommand sacar = new SacarCommand(conta, 5);

        ICommandHandler invoke = new ICommandHandler();
        var depositarCommand = new DepositarCommand(conta, 10);
        dispatcher.Dispatch(depositarCommand);

        var pedido = new Pedido(1, new Cliente(1, "Marcos"));
        var adicionarPedidoCommandHandler = new PedidoCommandHandler();
        var adicionarPedidoCommand = new FazerPedidoCommand(pedido.Cliente, pedido);

        dispatcher.Dispatch(adicionarPedidoCommand);

        Console.WriteLine($"{depositarCommand}");
        Console.WriteLine($"{adicionarPedidoCommand}");
        Console.WriteLine($"{pedido}");

        invoke.SetCommand(depositar);
        invoke.ExecuteCommand();
        invoke.SetCommand(sacar);
        invoke.ExecuteCommand();
        invoke.UndoCommand();

        Console.WriteLine(conta.Saldo);
        Console.ReadKey();
    }
}
