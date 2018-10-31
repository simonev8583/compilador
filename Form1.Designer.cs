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
            this.cargarBtn = new System.Windows.Forms.Button();
            this.traducirBtn = new System.Windows.Forms.Button();
            this.archivoTxtBoxMulti = new System.Windows.Forms.TextBox();
            this.tablaSimbolos = new System.Windows.Forms.DataGridView();
            this.tablaErrores = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCosnola
            // 
            this.checkCosnola.AutoSize = true;
            this.checkCosnola.Checked = true;
            this.checkCosnola.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCosnola.Location = new System.Drawing.Point(60, 12);
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
            this.checkArchivo.Location = new System.Drawing.Point(160, 12);
            this.checkArchivo.Name = "checkArchivo";
            this.checkArchivo.Size = new System.Drawing.Size(62, 17);
            this.checkArchivo.TabIndex = 1;
            this.checkArchivo.Text = "Archivo";
            this.checkArchivo.UseVisualStyleBackColor = true;
            this.checkArchivo.CheckedChanged += new System.EventHandler(this.checkArchivo_CheckedChanged);
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Location = new System.Drawing.Point(29, 40);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.Size = new System.Drawing.Size(238, 189);
            this.textBoxConsola.TabIndex = 3;
            this.textBoxConsola.TextChanged += new System.EventHandler(this.textBoxConsola_TextChanged);
            // 
            // cargarBtn
            // 
            this.cargarBtn.Location = new System.Drawing.Point(297, 173);
            this.cargarBtn.Name = "cargarBtn";
            this.cargarBtn.Size = new System.Drawing.Size(87, 37);
            this.cargarBtn.TabIndex = 4;
            this.cargarBtn.Text = "Cargar";
            this.cargarBtn.UseVisualStyleBackColor = true;
            this.cargarBtn.Click += new System.EventHandler(this.cargarBtn_Click);
            // 
            // traducirBtn
            // 
            this.traducirBtn.Location = new System.Drawing.Point(297, 240);
            this.traducirBtn.Name = "traducirBtn";
            this.traducirBtn.Size = new System.Drawing.Size(87, 37);
            this.traducirBtn.TabIndex = 5;
            this.traducirBtn.Text = "Traducir";
            this.traducirBtn.UseVisualStyleBackColor = true;
            this.traducirBtn.Click += new System.EventHandler(this.traducirBtn_Click);
            // 
            // archivoTxtBoxMulti
            // 
            this.archivoTxtBoxMulti.Location = new System.Drawing.Point(29, 240);
            this.archivoTxtBoxMulti.Multiline = true;
            this.archivoTxtBoxMulti.Name = "archivoTxtBoxMulti";
            this.archivoTxtBoxMulti.Size = new System.Drawing.Size(238, 189);
            this.archivoTxtBoxMulti.TabIndex = 6;
            // 
            // tablaSimbolos
            // 
            this.tablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolos.Location = new System.Drawing.Point(407, 24);
            this.tablaSimbolos.Name = "tablaSimbolos";
            this.tablaSimbolos.Size = new System.Drawing.Size(490, 223);
            this.tablaSimbolos.TabIndex = 7;
            // 
            // tablaErrores
            // 
            this.tablaErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaErrores.Location = new System.Drawing.Point(407, 278);
            this.tablaErrores.Name = "tablaErrores";
            this.tablaErrores.Size = new System.Drawing.Size(490, 223);
            this.tablaErrores.TabIndex = 8;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(297, 302);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(87, 37);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar Tablas";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(948, 513);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.tablaErrores);
            this.Controls.Add(this.tablaSimbolos);
            this.Controls.Add(this.archivoTxtBoxMulti);
            this.Controls.Add(this.traducirBtn);
            this.Controls.Add(this.cargarBtn);
            this.Controls.Add(this.textBoxConsola);
            this.Controls.Add(this.checkArchivo);
            this.Controls.Add(this.checkCosnola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkCosnola;
        private System.Windows.Forms.CheckBox checkArchivo;
        private System.Windows.Forms.TextBox textBoxConsola;
        private System.Windows.Forms.Button cargarBtn;
        private System.Windows.Forms.Button traducirBtn;
        private System.Windows.Forms.TextBox archivoTxtBoxMulti;
        private System.Windows.Forms.DataGridView tablaSimbolos;
        private System.Windows.Forms.DataGridView tablaErrores;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

