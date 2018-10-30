using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class TablaSimbolos
    {
        private static TablaSimbolos INSTANCIA = new TablaSimbolos();
        private Dictionary<string, List<ComponenteLexico>> tablaSimbolos = new Dictionary<string, List<ComponenteLexico>>();

        public static TablaSimbolos ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public void agregar(ComponenteLexico componente)
        {
            if (this.tablaSimbolos.ContainsKey(componente.lexema))
            {
                tablaSimbolos[componente.lexema].Add(componente);
            }
            else
            {
                List<ComponenteLexico> componentes = new List<ComponenteLexico>();
                componentes.Add(componente);
                tablaSimbolos.Add(componente.lexema, componentes);
            }
        }

        public List<ComponenteLexico> obtenersimbolo(String lexema)
        {
            List<ComponenteLexico> lista = null;
            if (tablaSimbolos.ContainsKey(lexema))
            {
                lista = tablaSimbolos[lexema];
            }
            return lista;
        }

        public List<ComponenteLexico> ObtenerTodo()
        {
            return tablaSimbolos.Values.SelectMany(simbolo => simbolo).ToList();
        }

        public void limpiar()
        {
            tablaSimbolos.Clear();
        }
    }
}
