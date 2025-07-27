// Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.
using System;

class Principal
{
    static void Main()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
            { // verifica se o número é ímpar (resto da divisão por 2 diferente de 0)
                Console.WriteLine(i);
            }
        }
    }
}