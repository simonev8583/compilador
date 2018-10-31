using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador.AnalisisSintactico
{
    class AnalisisSintactico
    {
        private ComponenteLexico componente;
        private AnalisisLexico.AnalisisLexico anaLex = new AnalisisLexico.AnalisisLexico();
        private string entrada;
        private bool depurar = true;

        public void analizar(bool depurarEntrada)
        {
            try
            {
                componente = anaLex.devolverComponenteLexico();
                depurar = depurarEntrada;
                entrada = "";
                if (ManejadorErrores.obtenerManejadorErrores().programaTieneErrore())
                {
                    MessageBox.Show("el programa esta mal escrito. verigique los errores presentados...");
                }
                else if (componente.categoria.Equals("FIN DE ARCHIVO"))
                {
                    MessageBox.Show("el programa esta mal escrito. verigique los errores presentados...");
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
       

       

        private void reportarError(string causa, string falla, string solucion)
        {
            ManejadorErrores.obtenerManejadorErrores().reportarError(
                Error.crear (componente.letralexema,"SINTACTICO", causa, solucion,
                componente.numeroLinea, componente.posicionInicial,
                componente.posicionFinal));
        }


    }
}
