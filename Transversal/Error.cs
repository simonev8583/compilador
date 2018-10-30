using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class Error
    {
        public String lexema { get; set; }
        public String tipoError { get; set; }
        public String causa { get; set; }
        public String solucion { get; set; }
        public int numeroLinea { get; set; }
        public int posicionInicial { get; set; }
        public int posicionFinal { get; set; }

        public static Error crear(String lexema, String tipoError, String causa, String solucion, int numeroLinea, int posiscionInicial, int posiscionFinal)
        {
            Error retorno = new Error();
            retorno.lexema = lexema;
            retorno.tipoError = tipoError;
            retorno.numeroLinea = numeroLinea;
            retorno.posicionInicial = posiscionInicial;
            retorno.posicionFinal = posiscionFinal;
            retorno.causa = causa;
            retorno.solucion = solucion;
            return retorno;
        }


    }
}
