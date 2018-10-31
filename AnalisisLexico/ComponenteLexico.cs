using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class ComponenteLexico
    {
        public string lexema { get; set; }
        public string letralexema { get; set; }
        public string categoria { get; set; }
        public int numeroLinea { get; set; }
        public int posicionInicial { get; set; }
        public int posicionFinal { get; set; }

        public string dummy { get; set; }
        public static ComponenteLexico crear(string lexema,string letralexema ,string categoria, int numeroLinea, int posiscionInicial, int posiscionFinal)
        {
            ComponenteLexico retorno = new ComponenteLexico();
            retorno.lexema = lexema;
            retorno.letralexema = letralexema;
            retorno.categoria = categoria;
            retorno.numeroLinea = numeroLinea;
            retorno.posicionInicial = posiscionInicial;
            retorno.posicionFinal = posiscionFinal;
            return retorno;
        }

        public static ComponenteLexico crear2(string lexema, string categoria, int numeroLinea, int posiscionInicial, int posiscionFinal)
        {
            ComponenteLexico retorno = new ComponenteLexico();
            retorno.lexema = lexema;
            retorno.categoria = categoria;
            retorno.numeroLinea = numeroLinea;
            retorno.posicionInicial = posiscionInicial;
            retorno.posicionFinal = posiscionFinal;
            return retorno;
        }

        public static ComponenteLexico crear(string lexema,string letralexema, string categoria)
        {
            return crear(lexema,letralexema, categoria, 0, 0, 0);
        }
        public static ComponenteLexico crear(string lexema, string categoria)
        {
            return crear2(lexema, categoria, 0, 0, 0);
        }

        public ComponenteLexico clonar()
        {
            return crear(this.lexema,this.letralexema, this.categoria, this.numeroLinea, this.posicionInicial, this.posicionFinal);
        }
    }
}
