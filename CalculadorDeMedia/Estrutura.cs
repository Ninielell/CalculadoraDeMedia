using System;

namespace CalculadorDeMedia;
class Estrutura
{

    public static void Start(int value)
    {
        
        double[] notas = new double[value];

        for (int i = 0; i < notas.Length; i++)
        {
            var pos = i+1;
            Console.Write($"Digite o {pos}º valor: ");
            notas[i] = double.Parse(Console.ReadLine());           
        }
        
        double total = 0;
        
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }

        Console.WriteLine($"A média dos valores dados é: {divisao(total, notas.Length)}!");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    public static int Menu()
    {

        Console.WriteLine("Olá, qual o valor que deseja fazer a média de suas notas?");
        Thread.Sleep(1000);
        Console.WriteLine("Exemplo: 5 para receber a média de 5 notas!");
        Console.Write("Digite o valor que deseja: ");
        int value = int.Parse(Console.ReadLine());
        Thread.Sleep(1000);
        Console.Clear();
        Loading();
        Console.WriteLine("Atenção! Utilize , para valores quebrados!");
        return value;
    }

    public static double divisao(double Total, int Qnt)
    {
        var div = Total / Qnt;
        
        return div;   
    }
    public static void Loading()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Carregando"); 
            for (int x = 0; x < 3; x++)
            {
                var ponto = ". ";
                Console.Write(ponto);
                Thread.Sleep(500);
            }
            Console.Clear();
            Thread.Sleep(300);
        }
    }
}