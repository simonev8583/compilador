using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compilador.Transversal;
using System.Windows.Forms;

namespace Compilador.AnalisisSintactico
{
    class AnalisisSintacticoTextoMorse
    {
        private ComponenteLexico componente;
        private AnalisisLexico.AnalisisLexicoTextoMorse anaLex = new AnalisisLexico.AnalisisLexicoTextoMorse();
        private string entrada;
        private bool depurar = true;

        public void analizar(bool depurarEntrada)
        {
            try
            {
                //componente = anaLex.devolverComponenteLexico();
                formarPalabra();
                depurar = depurarEntrada;
                entrada = "";
                if (ManejadorErrores.obtenerManejadorErrores().programaTieneErrore())
                {
                    MessageBox.Show("el programa esta mal escrito. verigique los errores presentados...");
                }
                else if (componente.categoria.Equals("FIN DE ARCHIVO"))
                {
                    MessageBox.Show("Se logro formar la cadena");
                }
                else
                {
                    MessageBox.Show("El programa esta mal escrito, ya que faltaron componentes por evaluar...");
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message);
            }
        }

        public void formarPalabra()
        {
            componente = anaLex.devolverComponenteLexico();
            string cadena = "";
            while (!"FIN DE ARCHIVO".Equals(componente.categoria))
            {
                if (componente.categoria.Equals("Letra"))
                {
                    cadena += componente.letralexema;
                }
                else if (componente.categoria.Equals("Espacio"))
                {
                    cadena += componente.letralexema;
                }
                else if (componente.categoria.Equals("Número"))
                {
                    cadena += componente.letralexema;
                }
                componente = anaLex.devolverComponenteLexico();

            }
            Console.WriteLine(cadena + " esta cadena");
            // return cadena;
        }




        private void reportarError(string causa, string falla, string solucion)
        {
            ManejadorErrores.obtenerManejadorErrores().reportarError(
                Error.crear(componente.letralexema, "SINTACTICO", causa, solucion,
                componente.numeroLinea, componente.posicionInicial,
                componente.posicionFinal));
        }

    }
}
