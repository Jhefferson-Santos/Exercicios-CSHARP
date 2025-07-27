// Faça um programa que peça uma nota entre zero e dez.
// Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

using System;

class Principal
{
    static void Main()
    {
    inicio:
        Console.WriteLine("Seja bem-vindo\nPor favor digite uma nota entre 0 e 10:");

        string nota = Console.ReadLine();

        int notaConvertida;
        bool conversaoOk = int.TryParse(nota, out notaConvertida);

        if (conversaoOk && notaConvertida >= 0 && notaConvertida <= 10)
        {
            Console.WriteLine($"A nota digitada foi {notaConvertida}");
        }
        else
        {
            Console.WriteLine("Número inválido. Tente novamente.\n");
            goto inicio;
        }
    }
}