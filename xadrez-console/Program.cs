using System;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.ReadLine();

            Console.WriteLine("Sucesso! " + tab);
        }
    }
}