using Estudo.Aplication.Handlers;
using Estudo.Core;
using Estudo.Domain.Modal;

class Program
{
    static void Main(string[] args)
    {

        var dispartcher = new CommandDispatcher();
        var conta = new ContaBancaria("Marcos", "Itau",10);

        Console.WriteLine(conta);

        var sacarCommandHandler = new SacarCommandHandler();

        var depositarCommand = new DepositarCommand(conta, 10);
        dispartcher.Dispatch(depositarCommand);

        Console.ReadKey();


    }
}