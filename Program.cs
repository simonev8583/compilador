using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            /*
            Linea linea1 = new Linea();
            Linea linea2 = new Linea();
            //linea1.contenido = "..... ... -... ";
            linea1.contenido = "..... ... -... -.-- ";
            linea1.Numero = 1;
            linea2.contenido = "----- /. /-.. ";
            linea2.Numero = 2;
            Archivo.obtenerInstancia().agregarLinea(linea1);
            Archivo.obtenerInstancia().agregarLinea(linea2);

            AnalisisLexico.AnalisisLexico analexico = new AnalisisLexico.AnalisisLexico();
            ComponenteLexico comp = new ComponenteLexico();
            comp.categoria = "INICIO";

            while (!"FIN DE ARCHIVO".Equals(comp.categoria))
            {
                comp = analexico.devolverComponenteLexico();
                
            }

            List<ComponenteLexico> tabla =  TablaSimbolos.ObtenerInstancia().ObtenerTodo();
            for (int i = 0; i < tabla.Count; i++)
            {
                Console.WriteLine(tabla[i].categoria);
                Console.WriteLine(tabla[i].lexema);
                Console.WriteLine(tabla[i].letralexema);
                Console.WriteLine(tabla[i].numeroLinea);
                Console.WriteLine(tabla[i].posicionInicial);
                Console.WriteLine(tabla[i].posicionFinal);
            }

            List<Error> errores = TablaErrores.ObtenerInstancia().ObtenerTodo();
            for (int i = 0; i < errores.Count; i++)
            {
                Console.WriteLine(errores[i].tipoError);
                Console.WriteLine(errores[i].lexema);
                Console.WriteLine(errores[i].numeroLinea);
            }
            */
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
