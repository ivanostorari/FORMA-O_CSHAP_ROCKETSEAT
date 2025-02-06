using System;

class Programa
{
    static void Main()
    {
        // Solicitar o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Exibir a mensagem de boas-vindas personalizada
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
}
