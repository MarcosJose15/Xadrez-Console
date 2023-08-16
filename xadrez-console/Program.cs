using System;
using tabuleiro;

namespace tabuleiro
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