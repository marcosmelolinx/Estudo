namespace Estudo.Aplication.Handlers;


public class SacarCommandHandler : ICommandHandler<SacarCommand>
{
    public void Handle(SacarCommand command)
    {
        command.Conta.Sacar(command.Amount);
    }
}

