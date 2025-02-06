using System;

class Programa
{
    static void Main()
    {
        // Solicitar que o usuário digite uma ou mais palavras
        Console.Write("Digite uma ou mais palavras: ");
        string entrada = Console.ReadLine();

        // Contar a quantidade de caracteres
        int quantidadeCaracteres = entrada.Length;

        // Exibir a quantidade de caracteres
        Console.WriteLine($"Quantidade de caracteres: {quantidadeCaracteres}");
    }
}