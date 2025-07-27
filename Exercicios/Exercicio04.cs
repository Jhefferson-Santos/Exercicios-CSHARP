//Faça um programa que receba dois números inteiros e gere os números inteiros que estão no
// intervalo compreendido por eles.
using System;

class Principal
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine($"\nNúmeros inteiros entre {num1} e {num2}:");

        for (int i = num1 + 1; i < num2; i++)
        {
            Console.WriteLine(i);
        }
    }
}