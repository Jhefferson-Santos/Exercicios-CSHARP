// Desenvolva um gerador de tabuada, capaz de gerar a tabuada de qualquer número inteiro
// entre 1 a 10. O usuário deve informar de qual número ele deseja ver a tabuada. A saída deve
// ser conforme o exemplo abaixo: Tabuada de 5: 5 X 1 = 5 5 X 2 = 10 ... 5 X 10 = 50


using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Olá seja bem vindo\nDigite escolha a tabuada que deseja saber a resposta");

        int entrada = Convert.ToInt32(Console.ReadLine());

        switch (entrada)
        {
            case 1:
                Console.WriteLine("Você selecionou a tabuada do 01:\n1x1 = 1");
                break;
            case 2:
                Console.WriteLine("Você selecionou a tabuada do 02:\n2X1 = 2");
                break;
            case 3:
                Console.WriteLine("Você selecionou a tabuada do 3:\n3X1 = 3");
                break;
            default:
                Console.WriteLine("Opção invalida tente novamente");
                break;
        }
    }
}