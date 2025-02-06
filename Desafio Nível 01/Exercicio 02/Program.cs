using System;

class Programa
{
    static void Main()
    {
        // Solicitar o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Solicitar o sobrenome do usuário
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        // Concatenar o nome e o sobrenome
        string nomeCompleto = nome + " " + sobrenome;

        // Exibir o nome completo
        Console.WriteLine($"Nome completo: {nomeCompleto}");
    }
}