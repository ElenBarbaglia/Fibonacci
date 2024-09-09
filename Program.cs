using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {

            if (PertenceFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                Fim();
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
                Fim();
            }

        }
    }
    private static bool PertenceFibonacci(int num)
    {

        if (num < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        while (a < num)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == num;
    }

    static void Fim()
    {
        Console.WriteLine("Deseja fazer uma nova verificação?(Sim/Não)");
        string ver = Console.ReadLine();
        ver = ver?.ToLower();

        if (ver == "sim")
        {
            Main();
        }
        else if (ver == "não" ||  ver =="nao")
        {
            Console.WriteLine("Até a Próxima !");
            return;
        }
    }
}

