using Estudo.Domain.UI.Commands;
using System.Reflection;

namespace Estudo.Core;

public class CommandDispatcher
{
    private readonly Dictionary<Type, object> _handlers = new Dictionary<Type, object>();

    public void RegisterHandler<TCommand>(ICommandHandler<TCommand> handler) where TCommand : ICommand
    {
        _handlers[typeof(TCommand)] = handler;
    }

    public void Dispatch(ICommand command)
    {
        Type commandType = command.GetType();
        if (_handlers.TryGetValue(commandType, out var handler))
        {
            MethodInfo method = handler.GetType().GetMethod("Handle");
            method.Invoke(handler, new object[] { command });
        }
        else
        {
            throw new InvalidOperationException($"No handler registered for {commandType.Name}");
        }
    }
}
