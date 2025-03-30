using Estudo.Domain.Modal;
using Estudo.Domain.UI.Commands;
using MediatR;


public class DepositarCommand : ICommand
{
    private readonly ContaBancaria _account;
    private readonly float _amount;

    public DepositarCommand(ContaBancaria account, float amount)
    {
        _account = account;
        _amount = amount;
    }
}
