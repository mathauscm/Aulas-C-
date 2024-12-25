using System;

class Aula08
{
    static void Main()
    {
        int v1, v2;
        char operacao;
        double resultado = 0;

        Console.Write("Digite o sinal da operação (+ , - , * , / ):  ");
        operacao = char.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        v2 = int.Parse(Console.ReadLine());

        if (operacao == '+')
        {
            resultado = v1 + v2;
        }
        else if (operacao == '-')
        {
            resultado = v1 - v2;
        }
        else if (operacao == '*')
        {
            resultado = v1 * v2;
        }
        else if (operacao == '/')
        {
            if (v2 != 0)  // Verifica se o divisor não é zero
            {
                resultado = (double)v1 / v2;  // Converte para double para evitar divisão inteira
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operação inválida.");
            return;
        }

        Console.WriteLine("O resultado de {0} {1} {2} é igual a {3}", v1, operacao, v2, resultado);
    }
}