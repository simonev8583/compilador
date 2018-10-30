using System.Collections.Generic;

namespace Compilador.Transversal
{
    public class Archivo
    {
        private static Archivo INSTANCIA = new Archivo();
        private List<Linea> lineas = new List<Linea>();

        private Archivo() { }

        public static Archivo obtenerInstancia()
        {
            return INSTANCIA;
        }

        public void limpiarLineas()
        {
            lineas.Clear();
        }

        public void agregarLinea(Linea linea)
        {
            lineas.Add(linea);
        }

        public Linea obtenerLinea(int numeroLinea)
        {
            Linea retorno = null;
            if (numeroLinea > lineas.Count)
            {
                retorno = new Linea();
                retorno.Numero = numeroLinea;
                retorno.contenido = "@EOF@";
            }
            else
            {
                retorno = lineas[numeroLinea - 1];
            }
            return retorno;
        }

        public List<Linea> obtenerListaLineas()
        {
            if (lineas == null)
            {
                lineas = new List<Linea>();
            }
            return lineas;
        }
    }
}
