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
        private Dictionary<string, string> tablaPalabrasReservadas = new Dictionary<string, string>();

        //inicializador de la tabla con las palabras reservadas.
        private TablaPalabrasReservadas()
        {
            //Acá hay que poner todas las posibles combinaciones de las palabras en minuscilas o mayusculas
            tablaPalabrasReservadas.Add("A", ".- ");
            tablaPalabrasReservadas.Add("B", "-... ");
            tablaPalabrasReservadas.Add("C", "-.-. ");
            tablaPalabrasReservadas.Add("D", "-.. ");
            tablaPalabrasReservadas.Add("E", ". ");
            tablaPalabrasReservadas.Add("F", "..-. ");
            tablaPalabrasReservadas.Add("G", "--. ");
            tablaPalabrasReservadas.Add("H", ".... ");
            tablaPalabrasReservadas.Add("I", ".. ");
            tablaPalabrasReservadas.Add("J", ".--- ");
            tablaPalabrasReservadas.Add("K", "-.- ");
            tablaPalabrasReservadas.Add("L", ".-.. ");
            tablaPalabrasReservadas.Add("M", "-- ");
            tablaPalabrasReservadas.Add("N", "-. ");
            tablaPalabrasReservadas.Add("O", "--- ");
            tablaPalabrasReservadas.Add("P", ".--. ");
            tablaPalabrasReservadas.Add("Q", "--.- ");
            tablaPalabrasReservadas.Add("R", ".-. ");
            tablaPalabrasReservadas.Add("S", "... ");
            tablaPalabrasReservadas.Add("T", "- ");
            tablaPalabrasReservadas.Add("U", "..- ");
            tablaPalabrasReservadas.Add("V", "...- ");
            tablaPalabrasReservadas.Add("W", ".-- ");
            tablaPalabrasReservadas.Add("X", "-..- ");
            tablaPalabrasReservadas.Add("Y", "-.-- ");
            tablaPalabrasReservadas.Add("Z", "--.. ");
            tablaPalabrasReservadas.Add("a", ".- ");
            tablaPalabrasReservadas.Add("b", "-... ");
            tablaPalabrasReservadas.Add("c", "-.-. ");
            tablaPalabrasReservadas.Add("d", "-.. ");
            tablaPalabrasReservadas.Add("e", ". ");
            tablaPalabrasReservadas.Add("f", "..-. ");
            tablaPalabrasReservadas.Add("g", "--. ");
            tablaPalabrasReservadas.Add("h", ".... ");
            tablaPalabrasReservadas.Add("i", ".. ");
            tablaPalabrasReservadas.Add("j", ".--- ");
            tablaPalabrasReservadas.Add("k", "-.- ");
            tablaPalabrasReservadas.Add("l", ".-.. ");
            tablaPalabrasReservadas.Add("m", "-- ");
            tablaPalabrasReservadas.Add("n", "-. ");
            tablaPalabrasReservadas.Add("o", "--- ");
            tablaPalabrasReservadas.Add("p", ".--. ");
            tablaPalabrasReservadas.Add("q", "--.- ");
            tablaPalabrasReservadas.Add("r", ".-. ");
            tablaPalabrasReservadas.Add("s", "... ");
            tablaPalabrasReservadas.Add("t", "- ");
            tablaPalabrasReservadas.Add("u", "..- ");
            tablaPalabrasReservadas.Add("v", "...- ");
            tablaPalabrasReservadas.Add("w", ".-- ");
            tablaPalabrasReservadas.Add("x", "-..- ");
            tablaPalabrasReservadas.Add("y", "-.-- ");
            tablaPalabrasReservadas.Add("z", "--.. ");
            tablaPalabrasReservadas.Add("1", ".---- ");
            tablaPalabrasReservadas.Add("2", "..--- ");
            tablaPalabrasReservadas.Add("3", "...-- ");
            tablaPalabrasReservadas.Add("4", "....- ");
            tablaPalabrasReservadas.Add("5", "..... ");
            tablaPalabrasReservadas.Add("6", "-.... ");
            tablaPalabrasReservadas.Add("7", "--... ");
            tablaPalabrasReservadas.Add("8", "---.. ");
            tablaPalabrasReservadas.Add("9", "----. ");
            tablaPalabrasReservadas.Add("0", "----- ");
        }
        public static TablaPalabrasReservadas ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public string obtenerPalabraReservada(string palabra)
        {
            string retorno = null;
            if (tablaPalabrasReservadas.ContainsKey(palabra))
            {
                retorno = tablaPalabrasReservadas[palabra];
            }
            return retorno;
        }

    }
}
