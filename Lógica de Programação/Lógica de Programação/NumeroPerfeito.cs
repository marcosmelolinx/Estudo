
public class NumeroPerfeito
{
    // Classe para verificar se um número é perfeito.
    public void VerificarNumeroPerfeito(){
        System.Console.WriteLine("=====================================");
        System.Console.WriteLine("=== Verifica se o numero é perfeito ===");
        System.Console.WriteLine("=====================================");

        System.Console.WriteLine("Digite um numero inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine()!);

        List<int> lista = new List<int>();
        int soma = 0;

        for (int i = 1; i < numero; i++) 
        if (numero % i == 0) 
        {
            lista.Add(i);
        }

        soma = lista.Sum();

        if (soma == numero){
            System.Console.WriteLine($"O numero {numero} é perfeito.");
        }
        else
        {
            System.Console.WriteLine($"O numero {numero} não é perfeito.");
        }
        return;
    }
}

