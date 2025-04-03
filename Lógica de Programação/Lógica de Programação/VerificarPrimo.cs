using System;
using System.Collections.Generic;   

public class VerificarPrimo(){

public void VerificarEhPrimo(){

        System.Console.WriteLine("=====================================");
        System.Console.WriteLine("=== Verifica se o numero é primo ===");
        System.Console.WriteLine("=====================================");

        System.Console.WriteLine("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine()!);

        if (numero < 1) {
            System.Console.WriteLine($"O numero {numero} não é primo.");
            return;
        }
        else if (numero % numero == 0){
            System.Console.WriteLine("O numero é primo.");
        }
        if(numero >= 2){
            for (int i = 2; i <= Math.Sqrt(numero);i++){
                if (numero % i == 0){
                    System.Console.WriteLine($"O numero {numero} não é primo.");
                    return;
                }
            }
        }
        return;
    }   
}