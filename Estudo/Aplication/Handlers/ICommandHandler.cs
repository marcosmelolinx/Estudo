﻿

using Estudo.Domain.UI.Commands;

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}