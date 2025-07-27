// Faça um programa que imprima na tela os números de 1 a 20, um abaixo do outro
using System;

class Principal
{
    static void Main()
    {

        for (int i = 1; i <= 21; i++)
        {
            if (i == 20)
            {
                break; // Interrompe o loop quando i == 5
            }
            Console.WriteLine(i);
        }

    }
}