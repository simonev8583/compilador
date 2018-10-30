using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class ManejadorErrores
    {
        private static ManejadorErrores INSTANCIA = new ManejadorErrores();
        private Dictionary<string, List<Error>> mapaErrores = new Dictionary<string, List<Error>>();

        public static ManejadorErrores obtenerManejadorErrores()
        {
            return INSTANCIA;
        }


        private ManejadorErrores()
        {
            mapaErrores.Add("LEXICOS", new List<Error>());
            mapaErrores.Add("SINTACTICOS", new List<Error>());
            mapaErrores.Add("SEMANTICOS", new List<Error>());

        }

        public void reportarError(Error error)
        {
            if (mapaErrores.ContainsKey(error.tipoError))
            {
                mapaErrores[error.tipoError].Add(error);
            }
        }

        public bool hayErrores(String tipoError)
        {
            if (mapaErrores.ContainsKey(tipoError))
            {
                return mapaErrores[tipoError].Count > 0;
            }
            else
            {
                return false;
            }
        }

        public Boolean programaTieneErrore()
        {
            return hayErrores("LEXICOS") || hayErrores("SINTACTICOS") || hayErrores("SEMANTICOS");
        }

        public List<Error> ObtenerTodo()
        {
            return mapaErrores.Values.SelectMany(simbolo => simbolo).ToList();
        }

        public List<Error> obtenerErrores(String tipoError)
        {
            if (mapaErrores.ContainsKey(tipoError))
            {
                return mapaErrores[tipoError];
            }
            else
            {
                return new List<Error>();
            }
        }

        public void limpiarManejadorErrores()
        {
            mapaErrores.Clear();
            Console.WriteLine(this.ObtenerTodo());
            //mapaErrores["LEXICOS"].Clear();
            //mapaErrores["SINTACTICO"].Clear();
            //mapaErrores["SEMANTICO"].Clear();
        }
    }
}
