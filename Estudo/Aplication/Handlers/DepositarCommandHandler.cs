namespace Estudo.Aplication.Handlers;


public class DepositarCommandHandler : ICommandHandler<DepositarCommand>
{
    public void Handle(DepositarCommand command)
    {
        command.Conta.Depositar(command.Amount);
    }
}
