using Estudo.Domain.Modal;
using Estudo.Domain.UI.Commands;

namespace Estudo.Aplication.Commands;

public class SacarCommand : ICommand
{
    public ContaBancaria Conta { get; set; }
    public float Amount { get; set; }

    public SacarCommand(ContaBancaria conta, float amount)
    {
        Conta = conta;
        Amount = amount;
    }

}
