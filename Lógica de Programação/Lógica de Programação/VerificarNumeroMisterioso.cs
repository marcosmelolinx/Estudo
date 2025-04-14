namespace Lógica_de_Programação;

public class VerificarNumeroMisterioso
{
    //A soma de todos os seus dígitos for um número par.
    //E o número não for divisível por 5.
    public void ValidarNumeroMisterioso()
    {
        Console.WriteLine("Digito o número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        if (NumeroDivisivel(numero) &&  EhSomaMistoriosa(numero))
            Console.WriteLine("Número é misterioso");
        else
            Console.WriteLine("Número não é misterioso");
            return;
    }

    public bool NumeroDivisivel(int numero)
    {
        if (numero % 5 == 0)
        {
            return false;
        }
        return true;

    }

    public bool EhSomaMistoriosa(int numero)
    {
        int Soma = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            Soma += digito;
            numero = numero / 10;
        }

        if (Soma % 2 == 0)
        {
            return true;
        }
        else
            return false;

    }
}
