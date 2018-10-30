using Compilador.Transversal;
using System;

namespace Compilador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Linea linea1 = new Linea();
            Linea linea2 = new Linea();
            linea1.contenido = "..... ... -... ";
            //linea1.contenido = "..... ... -... -.-- ";
            linea1.Numero = 1;
            linea2.contenido = "----- /. /-.. ";
            linea2.Numero = 2;
            Archivo.obtenerInstancia().agregarLinea(linea1);
            Archivo.obtenerInstancia().agregarLinea(linea2);

            AnalisisLexico.AnalisisLexico analexico = new AnalisisLexico.AnalisisLexico();
            analexico.devolverComponenteLexico();

            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
