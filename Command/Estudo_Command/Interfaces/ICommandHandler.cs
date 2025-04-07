namespace Estudo_Command.Interfaces;

public interface ICommandHandler<T> where T : ICommand
{
    void Handle(ICommand command);

}
