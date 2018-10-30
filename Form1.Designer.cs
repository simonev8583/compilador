namespace Compilador
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkCosnola = new System.Windows.Forms.CheckBox();
            this.checkArchivo = new System.Windows.Forms.CheckBox();
            this.textBoxConsola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkCosnola
            // 
            this.checkCosnola.AutoSize = true;
            this.checkCosnola.Checked = true;
            this.checkCosnola.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCosnola.Location = new System.Drawing.Point(62, 235);
            this.checkCosnola.Name = "checkCosnola";
            this.checkCosnola.Size = new System.Drawing.Size(67, 17);
            this.checkCosnola.TabIndex = 0;
            this.checkCosnola.Text = "Consola ";
            this.checkCosnola.UseVisualStyleBackColor = true;
            this.checkCosnola.CheckedChanged += new System.EventHandler(this.checkCosnola_CheckedChanged);
            // 
            // checkArchivo
            // 
            this.checkArchivo.AutoSize = true;
            this.checkArchivo.Location = new System.Drawing.Point(173, 235);
            this.checkArchivo.Name = "checkArchivo";
            this.checkArchivo.Size = new System.Drawing.Size(62, 17);
            this.checkArchivo.TabIndex = 1;
            this.checkArchivo.Text = "Archivo";
            this.checkArchivo.UseVisualStyleBackColor = true;
            this.checkArchivo.CheckedChanged += new System.EventHandler(this.checkArchivo_CheckedChanged);
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Location = new System.Drawing.Point(62, 22);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.Size = new System.Drawing.Size(173, 189);
            this.textBoxConsola.TabIndex = 3;
            this.textBoxConsola.TextChanged += new System.EventHandler(this.textBoxConsola_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(699, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxConsola);
            this.Controls.Add(this.checkArchivo);
            this.Controls.Add(this.checkCosnola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCosnola;
        private System.Windows.Forms.CheckBox checkArchivo;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.Button button1;
    }
}

