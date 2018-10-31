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
            this.TextoMorse = new System.Windows.Forms.Button();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.textBoxCadena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // checkCosnola
            // 
            this.checkCosnola.AutoSize = true;
            this.checkCosnola.Checked = true;
            this.checkCosnola.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCosnola.Location = new System.Drawing.Point(44, 12);
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
            this.checkArchivo.Location = new System.Drawing.Point(150, 12);
            this.checkArchivo.Name = "checkArchivo";
            this.checkArchivo.Size = new System.Drawing.Size(62, 17);
            this.checkArchivo.TabIndex = 1;
            this.checkArchivo.Text = "Archivo";
            this.checkArchivo.UseVisualStyleBackColor = true;
            this.checkArchivo.CheckedChanged += new System.EventHandler(this.checkArchivo_CheckedChanged);
            // 
            // textBoxConsola
            // 
            this.textBoxConsola.Location = new System.Drawing.Point(12, 35);
            this.textBoxConsola.Multiline = true;
            this.textBoxConsola.Name = "textBoxConsola";
            this.textBoxConsola.Size = new System.Drawing.Size(238, 189);
            this.textBoxConsola.TabIndex = 3;
            // 
            // cargarBtn
            // 
            this.cargarBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cargarBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cargarBtn.Location = new System.Drawing.Point(87, 430);
            this.cargarBtn.Name = "cargarBtn";
            this.cargarBtn.Size = new System.Drawing.Size(91, 47);
            this.cargarBtn.TabIndex = 4;
            this.cargarBtn.Text = "Cargar";
            this.cargarBtn.UseVisualStyleBackColor = false;
            this.cargarBtn.Click += new System.EventHandler(this.cargarBtn_Click);
            // 
            // traducirBtn
            // 
            this.traducirBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.traducirBtn.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traducirBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.traducirBtn.Location = new System.Drawing.Point(273, 230);
            this.traducirBtn.Name = "traducirBtn";
            this.traducirBtn.Size = new System.Drawing.Size(114, 37);
            this.traducirBtn.TabIndex = 5;
            this.traducirBtn.Text = "Morse a Texto";
            this.traducirBtn.UseVisualStyleBackColor = false;
            this.traducirBtn.Click += new System.EventHandler(this.traducirBtn_Click);
            // 
            // archivoTxtBoxMulti
            // 
            this.archivoTxtBoxMulti.Location = new System.Drawing.Point(12, 235);
            this.archivoTxtBoxMulti.Multiline = true;
            this.archivoTxtBoxMulti.Name = "archivoTxtBoxMulti";
            this.archivoTxtBoxMulti.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.archivoTxtBoxMulti.Size = new System.Drawing.Size(238, 189);
            this.archivoTxtBoxMulti.TabIndex = 6;
            // 
            // tablaSimbolos
            // 
            this.tablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaSimbolos.Location = new System.Drawing.Point(407, 40);
            this.tablaSimbolos.Name = "tablaSimbolos";
            this.tablaSimbolos.Size = new System.Drawing.Size(490, 189);
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
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLimpiar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLimpiar.Location = new System.Drawing.Point(273, 289);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(114, 56);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar Tablas";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // TextoMorse
            // 
            this.TextoMorse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.TextoMorse.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoMorse.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextoMorse.Location = new System.Drawing.Point(273, 175);
            this.TextoMorse.Name = "TextoMorse";
            this.TextoMorse.Size = new System.Drawing.Size(114, 37);
            this.TextoMorse.TabIndex = 10;
            this.TextoMorse.Text = "Texto a Morse";
            this.TextoMorse.UseVisualStyleBackColor = false;
            this.TextoMorse.Click += new System.EventHandler(this.TextoMorse_Click);
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.Location = new System.Drawing.Point(12, 115);
            this.textBoxArchivo.Multiline = true;
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.Size = new System.Drawing.Size(238, 30);
            this.textBoxArchivo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Analizador Lexico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Traducir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tabla de errores";
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCargarArchivo.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(79, 151);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(99, 37);
            this.buttonCargarArchivo.TabIndex = 15;
            this.buttonCargarArchivo.Text = "Cargar";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // textBoxCadena
            // 
            this.textBoxCadena.Location = new System.Drawing.Point(273, 548);
            this.textBoxCadena.Multiline = true;
            this.textBoxCadena.Name = "textBoxCadena";
            this.textBoxCadena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCadena.Size = new System.Drawing.Size(338, 123);
            this.textBoxCadena.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cadena Traducida";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(948, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCadena);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.TextoMorse);
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
        private System.Windows.Forms.Button TextoMorse;
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.TextBox textBoxCadena;
        private System.Windows.Forms.Label label4;
    }
}

