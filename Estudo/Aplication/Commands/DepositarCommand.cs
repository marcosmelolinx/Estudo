using Estudo.Domain.Modal;
using Estudo.Domain.UI.Commands;
using MediatR;


public class DepositarCommand : ICommand
{
    public ContaBancaria Conta { get; set; }
    public float Amount { get; set; }

    public DepositarCommand(ContaBancaria account, float amount)
    {
        Conta = account;
        Amount = amount;
    }
}
