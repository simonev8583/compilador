using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
