//Autores: Igor Christofer Eisenhut e
//         Manoella Marcondes Junkes

using PilhaDeFolhas.Estruturas;
using System;

namespace PilhaDeFolhas
{
    class Program
    {
        static void Main(string[] args)
        {
            var esquerda1 = new No(10, null, null);
            var direita1 = new No(20, null, null);

            var esquerda2 = new No(30, null, null);
            var direita2 = new No(40, null, null);

            var no1 = new No(50, esquerda1, direita1);
            var no2 = new No(60, esquerda2, direita2);

            var raiz = new No(1, no1, no2);

            var arvore = new Arvore(raiz);
            var resultado = arvore.CalcularPilhas();

            foreach (var pilha in resultado)
            {
                Console.WriteLine($"Índice: {pilha.Key}");
                Console.WriteLine($"Somatóro: {pilha.Value}");
                Console.WriteLine();
            }
        }
    }
}
