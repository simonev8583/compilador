using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    class TablaErrores
    {
        private static TablaErrores INSTANCIA = new TablaErrores();
        private Dictionary<string, List<Error>> tablaErrores = new Dictionary<string, List<Error>>();


        public static TablaErrores ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public void agregar(Error error)
        {
            if (this.tablaErrores.ContainsKey(error.lexema))
            {
                tablaErrores[error.lexema].Add(error);
            }
            else
            {
                List<Error> errores = new List<Error>();
                errores.Add(error);
                tablaErrores.Add(error.lexema, errores);
            }
        }

        public List<Error> obtenersimbolo(String lexema)
        {
            List<Error> lista = null;
            if (tablaErrores.ContainsKey(lexema))
            {
                lista = tablaErrores[lexema];
            }
            return lista;
        }

        public List<Error> ObtenerTodo()
        {
            return tablaErrores.Values.SelectMany(simbolo => simbolo).ToList();
        }

        public void limpiar()
        {
            tablaErrores.Clear();
        }

    }
}
