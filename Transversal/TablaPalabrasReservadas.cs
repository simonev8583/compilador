using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    class TablaPalabrasReservadas
    {
        private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();
        private Dictionary<String, ComponenteLexico> tablaPalabrasReservadas = new Dictionary<string, ComponenteLexico>();

        //inicializador de la tabla con las palabras reservadas.
        private TablaPalabrasReservadas()
        {
            //Acá hay que poner todas las posibles combinaciones de las palabras en minuscilas o mayusculas
            tablaPalabrasReservadas.Add("SELECT", ComponenteLexico.crear("Select", "SELECT"));
            tablaPalabrasReservadas.Add("FROM", ComponenteLexico.crear("From", "FROM"));
            tablaPalabrasReservadas.Add("WHERE", ComponenteLexico.crear("Where", "WHERE"));
            tablaPalabrasReservadas.Add("ORDER BY", ComponenteLexico.crear("Order by", "ORDER BY"));
            tablaPalabrasReservadas.Add("OR", ComponenteLexico.crear("Or", "CONECTOR O"));
            tablaPalabrasReservadas.Add("AND", ComponenteLexico.crear("And", "CONECTOR Y"));
            tablaPalabrasReservadas.Add("ASC", ComponenteLexico.crear("Asc", "ASC"));
            tablaPalabrasReservadas.Add("DESC", ComponenteLexico.crear("Desc", "DESC"));

        }
        public static TablaPalabrasReservadas ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public ComponenteLexico obtenerPalabraReservada(String palabra)
        {
            ComponenteLexico retorno = null;
            if (tablaPalabrasReservadas.ContainsKey(palabra))
            {
                retorno = tablaPalabrasReservadas[palabra].clonar();
            }
            return retorno;
        }

    }
}
