namespace Estudo.Domain.Modal;

public class ContaBancaria
{
    public string Nome { get; set; }
    public string Banco { get; set; }
    public float Saldo { get; set; }

    public ContaBancaria(string nome, string banco, float saldo)
    {
        Nome = nome;
        Banco = banco;
        Saldo = saldo;
    }

    public void Depositar(float amount)
    {
        Saldo += amount;
        Console.WriteLine($"Depósito feito com sucesso: R$ {amount}.Novo balanço: R$ {Saldo}");
    }

    public void Sacar(float amount)
    {
        Saldo -= amount;
        Console.WriteLine($"Saque de R$ {amount} realizado. Novo balanço: R$ {Saldo}");
    }
}
