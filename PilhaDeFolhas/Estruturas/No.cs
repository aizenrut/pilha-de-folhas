//Autores: Igor Christofer Eisenhut e
//         Manoella Marcondes Junkes

using System.Collections.Generic;

namespace PilhaDeFolhas.Estruturas
{
    public class No
    {
        public int Valor { get; }
        public No Esquerda { get; }
        public No Direita { get; }

        public No(int valor, No esquerda, No direita)
        {
            Valor = valor;
            Esquerda = esquerda;
            Direita = direita;
        }

        public void CalcularPilha(IDictionary<int, int> pilhas, int indiceAtual)
        {
            if (pilhas.ContainsKey(indiceAtual))
                pilhas[indiceAtual] += Valor;
            else
                pilhas.Add(indiceAtual, Valor);

            if (Esquerda != null)
                Esquerda.CalcularPilha(pilhas, indiceAtual - 1);

            if (Direita != null)
                Direita.CalcularPilha(pilhas, indiceAtual + 1);
        }
    } 
}
