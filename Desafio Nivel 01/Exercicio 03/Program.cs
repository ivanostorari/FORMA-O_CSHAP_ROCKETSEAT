using System;

class Programa
{
    static void Main()
    {
        // Declaração dos valores do tipo double
        double valor1 = 10.0;
        double valor2 = 5.0;

        // Soma
        double soma = valor1 + valor2;
        Console.WriteLine($"Soma: {soma}");

        // Subtração
        double subtracao = valor1 - valor2;
        Console.WriteLine($"Subtração: {subtracao}");

        // Multiplicação
        double multiplicacao = valor1 * valor2;
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        // Divisão com verificação se o segundo número é 0
        if (valor2 != 0)
        {
            double divisao = valor1 / valor2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        else
        {
            Console.WriteLine("Divisão: Não é possível dividir por zero.");
        }

        // Média
        double media = (valor1 + valor2) / 2;
        Console.WriteLine($"Média: {media}");
    }
}
