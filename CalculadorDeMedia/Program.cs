using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace CalculadorDeMedia;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var value = Estrutura.Menu();
        Estrutura.Start(value);
    }

    
}
