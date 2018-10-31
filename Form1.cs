using Compilador.Transversal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkCosnola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCosnola.Focused)
            {
                checkArchivo.CheckState = CheckState.Unchecked;
                //  groupBoxConsola.Hide();
                //  groupBoxArchivo.Show();
            }
        }

        private void checkArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkArchivo.Focused)
            {
                checkCosnola.CheckState = CheckState.Unchecked;
                //   groupBoxConsola.Show();
                //  groupBoxArchivo.Hide();
            }
        }

        private void textBoxConsola_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            archivoTxtBoxMulti.Clear();
            Archivo archivo = Archivo.obtenerInstancia();
            archivo.limpiarLineas();
            string[] lineas32 = textBoxConsola.Text.Split('\r');

            string texto2 = "";
            foreach (string linea23 in lineas32)
            {
                texto2 += linea23;
            }
            string[] lineas = texto2.Split('\n');
            Linea linea;
            string texto = "";
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int i = 1;

            using (StreamWriter outputFile = new StreamWriter(ruta + @"\Archivo.txt"))
            {
                foreach (string linea2 in lineas)
                {
                    linea = new Linea();
                    linea.contenido = linea2;
                    linea.Numero = i;
                    texto += i + "-->" + linea.contenido + "\r\n";
                    i++;
                    archivo.agregarLinea(linea);
                    outputFile.WriteLine(linea.contenido);
                }
            }
            archivoTxtBoxMulti.Text = texto;
        }

        private void traducirBtn_Click(object sender, EventArgs e)
        {
            AnalisisSintactico.AnalisisSintactico asintac = new AnalisisSintactico.AnalisisSintactico();
            asintac.analizar(false);
            /*foreach (ComponenteLexico componente in TablaSimbolos.ObtenerInstancia().ObtenerTodo())
            {
                MessageBox.Show("Lexema: " + componente.lexema + "\nCategoría: " + componente.categoria + "\nNúmero Línea: " + componente.numeroLinea + "\nPosición Inicial: " + componente.posicionInicial + "\nPosición Final: " + componente.posicionFinal);
            }
            */
            
            tablaSimbolos.DataSource = TablaSimbolos.ObtenerInstancia().ObtenerTodo();
            tablaErrores.DataSource = ManejadorErrores.obtenerManejadorErrores().ObtenerTodo();

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            TablaErrores.ObtenerInstancia().limpiar();
            TablaSimbolos.ObtenerInstancia().limpiar();
            ManejadorErrores.obtenerManejadorErrores().limpiarManejadorErrores();
            tablaSimbolos.DataSource = null;
            tablaErrores.DataSource = null;
        }
    }
}
