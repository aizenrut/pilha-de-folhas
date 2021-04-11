//Autores: Igor Christofer Eisenhut e
//         Manoella Marcondes Junkes

using System.Collections.Generic;
using System.Linq;

namespace PilhaDeFolhas.Estruturas
{
    public class Arvore
    {
        public No Raiz { get; }

        public Arvore(No raiz) => Raiz = raiz;

        public KeyValuePair<int, int>[] CalcularPilhas()
        {
            var pilhas = new Dictionary<int, int>();

            Raiz.CalcularPilha(pilhas, 0);

            return pilhas
                .OrderBy(x => x.Key)
                .ToArray();
        }
    }
}
