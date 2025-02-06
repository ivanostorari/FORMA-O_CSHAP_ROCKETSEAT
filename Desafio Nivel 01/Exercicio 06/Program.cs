using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        // Obter a data e hora atual
        DateTime dataAtual = DateTime.Now;

        // Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
        string formatoCompleto = dataAtual.ToString("dddd, dd MMMM yyyy, HH:mm:ss", new CultureInfo("pt-BR"));
        Console.WriteLine($"Formato completo: {formatoCompleto}");

        // Apenas a data no formato "01/03/2024"
        string formatoData = dataAtual.ToString("dd/MM/yyyy");
        Console.WriteLine($"Apenas a data: {formatoData}");

        // Apenas a hora no formato de 24 horas
        string formatoHora = dataAtual.ToString("HH:mm:ss");
        Console.WriteLine($"Apenas a hora: {formatoHora}");

        // A data com o mês por extenso
        string formatoMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"));
        Console.WriteLine($"Data com o mês por extenso: {formatoMesExtenso}");
    }
}
