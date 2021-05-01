
namespace lectorArchivo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabIngreso = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.cargarInfoConsola = new System.Windows.Forms.Button();
            this.botonCargarInfo = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.textRuta = new System.Windows.Forms.TextBox();
            this.salidaDatos = new System.Windows.Forms.RichTextBox();
            this.entradaDatosConsola = new System.Windows.Forms.RichTextBox();
            this.labelSalida = new System.Windows.Forms.Label();
            this.labelEntrada = new System.Windows.Forms.Label();
            this.checkConsola = new System.Windows.Forms.CheckBox();
            this.checkArchivo = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataSimbolos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataPalabrasReservadas = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataLiterales = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataDummys = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.ComponenteL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponenteP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponenteS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponenteD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIngreso.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSimbolos)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPalabrasReservadas)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterales)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDummys)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabIngreso
            // 
            this.tabIngreso.Controls.Add(this.tabPage1);
            this.tabIngreso.Controls.Add(this.tabPage2);
            this.tabIngreso.Controls.Add(this.tabPage3);
            this.tabIngreso.Location = new System.Drawing.Point(12, 12);
            this.tabIngreso.Name = "tabIngreso";
            this.tabIngreso.SelectedIndex = 0;
            this.tabIngreso.Size = new System.Drawing.Size(1372, 778);
            this.tabIngreso.TabIndex = 0;
            this.tabIngreso.SelectedIndexChanged += new System.EventHandler(this.tabIngreso_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.botonLimpiar);
            this.tabPage1.Controls.Add(this.cargarInfoConsola);
            this.tabPage1.Controls.Add(this.botonCargarInfo);
            this.tabPage1.Controls.Add(this.botonBuscar);
            this.tabPage1.Controls.Add(this.textRuta);
            this.tabPage1.Controls.Add(this.salidaDatos);
            this.tabPage1.Controls.Add(this.entradaDatosConsola);
            this.tabPage1.Controls.Add(this.labelSalida);
            this.tabPage1.Controls.Add(this.labelEntrada);
            this.tabPage1.Controls.Add(this.checkConsola);
            this.tabPage1.Controls.Add(this.checkArchivo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1364, 750);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Enabled = false;
            this.botonLimpiar.Location = new System.Drawing.Point(331, 118);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(220, 40);
            this.botonLimpiar.TabIndex = 21;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click_1);
            // 
            // cargarInfoConsola
            // 
            this.cargarInfoConsola.Enabled = false;
            this.cargarInfoConsola.Location = new System.Drawing.Point(642, 470);
            this.cargarInfoConsola.Name = "cargarInfoConsola";
            this.cargarInfoConsola.Size = new System.Drawing.Size(82, 37);
            this.cargarInfoConsola.TabIndex = 20;
            this.cargarInfoConsola.Text = "Cargar";
            this.cargarInfoConsola.UseVisualStyleBackColor = true;
            this.cargarInfoConsola.Click += new System.EventHandler(this.cargarInfoConsola_Click_1);
            // 
            // botonCargarInfo
            // 
            this.botonCargarInfo.Enabled = false;
            this.botonCargarInfo.Location = new System.Drawing.Point(380, 235);
            this.botonCargarInfo.Name = "botonCargarInfo";
            this.botonCargarInfo.Size = new System.Drawing.Size(119, 42);
            this.botonCargarInfo.TabIndex = 19;
            this.botonCargarInfo.Text = "Leer Información";
            this.botonCargarInfo.UseVisualStyleBackColor = true;
            this.botonCargarInfo.Click += new System.EventHandler(this.botonCargarInfo_Click_1);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Enabled = false;
            this.botonBuscar.Location = new System.Drawing.Point(183, 235);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(132, 42);
            this.botonBuscar.TabIndex = 18;
            this.botonBuscar.Text = "Buscar...";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click_1);
            // 
            // textRuta
            // 
            this.textRuta.Enabled = false;
            this.textRuta.Location = new System.Drawing.Point(183, 206);
            this.textRuta.Name = "textRuta";
            this.textRuta.ReadOnly = true;
            this.textRuta.Size = new System.Drawing.Size(441, 23);
            this.textRuta.TabIndex = 17;
            // 
            // salidaDatos
            // 
            this.salidaDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salidaDatos.Location = new System.Drawing.Point(740, 346);
            this.salidaDatos.Name = "salidaDatos";
            this.salidaDatos.ReadOnly = true;
            this.salidaDatos.Size = new System.Drawing.Size(441, 286);
            this.salidaDatos.TabIndex = 16;
            this.salidaDatos.Text = "";
            // 
            // entradaDatosConsola
            // 
            this.entradaDatosConsola.Enabled = false;
            this.entradaDatosConsola.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entradaDatosConsola.Location = new System.Drawing.Point(183, 346);
            this.entradaDatosConsola.Name = "entradaDatosConsola";
            this.entradaDatosConsola.Size = new System.Drawing.Size(441, 286);
            this.entradaDatosConsola.TabIndex = 15;
            this.entradaDatosConsola.Text = "";
            // 
            // labelSalida
            // 
            this.labelSalida.AutoSize = true;
            this.labelSalida.Location = new System.Drawing.Point(740, 313);
            this.labelSalida.Name = "labelSalida";
            this.labelSalida.Size = new System.Drawing.Size(38, 15);
            this.labelSalida.TabIndex = 14;
            this.labelSalida.Text = "Salida";
            // 
            // labelEntrada
            // 
            this.labelEntrada.AutoSize = true;
            this.labelEntrada.Location = new System.Drawing.Point(183, 313);
            this.labelEntrada.Name = "labelEntrada";
            this.labelEntrada.Size = new System.Drawing.Size(93, 15);
            this.labelEntrada.TabIndex = 13;
            this.labelEntrada.Text = "Entrada Consola";
            // 
            // checkConsola
            // 
            this.checkConsola.AutoSize = true;
            this.checkConsola.Location = new System.Drawing.Point(256, 130);
            this.checkConsola.Name = "checkConsola";
            this.checkConsola.Size = new System.Drawing.Size(69, 19);
            this.checkConsola.TabIndex = 12;
            this.checkConsola.Text = "Consola";
            this.checkConsola.UseVisualStyleBackColor = true;
            this.checkConsola.CheckedChanged += new System.EventHandler(this.checkConsola_CheckedChanged_1);
            // 
            // checkArchivo
            // 
            this.checkArchivo.AutoSize = true;
            this.checkArchivo.Location = new System.Drawing.Point(183, 130);
            this.checkArchivo.Name = "checkArchivo";
            this.checkArchivo.Size = new System.Drawing.Size(67, 19);
            this.checkArchivo.TabIndex = 11;
            this.checkArchivo.Text = "Archivo";
            this.checkArchivo.UseVisualStyleBackColor = true;
            this.checkArchivo.CheckedChanged += new System.EventHandler(this.checkArchivo_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1364, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla de Simbolos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1356, 740);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataSimbolos);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1348, 712);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Tabla de Simbolos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataSimbolos
            // 
            this.dataSimbolos.AllowUserToAddRows = false;
            this.dataSimbolos.AllowUserToDeleteRows = false;
            this.dataSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponenteS});
            this.dataSimbolos.Location = new System.Drawing.Point(3, 3);
            this.dataSimbolos.Name = "dataSimbolos";
            this.dataSimbolos.ReadOnly = true;
            this.dataSimbolos.RowTemplate.Height = 25;
            this.dataSimbolos.Size = new System.Drawing.Size(1342, 706);
            this.dataSimbolos.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataPalabrasReservadas);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1348, 712);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Tabla de Palabras Reservadas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataPalabrasReservadas
            // 
            this.dataPalabrasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPalabrasReservadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponenteP});
            this.dataPalabrasReservadas.Location = new System.Drawing.Point(3, 3);
            this.dataPalabrasReservadas.Name = "dataPalabrasReservadas";
            this.dataPalabrasReservadas.RowTemplate.Height = 25;
            this.dataPalabrasReservadas.Size = new System.Drawing.Size(1342, 706);
            this.dataPalabrasReservadas.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataLiterales);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1348, 712);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Tabla de Literales";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataLiterales
            // 
            this.dataLiterales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLiterales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponenteL});
            this.dataLiterales.Location = new System.Drawing.Point(3, 3);
            this.dataLiterales.Name = "dataLiterales";
            this.dataLiterales.RowTemplate.Height = 25;
            this.dataLiterales.Size = new System.Drawing.Size(1342, 706);
            this.dataLiterales.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataDummys);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1348, 712);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Tabla de Dummys";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataDummys
            // 
            this.dataDummys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDummys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComponenteD});
            this.dataDummys.Location = new System.Drawing.Point(0, 0);
            this.dataDummys.Name = "dataDummys";
            this.dataDummys.RowTemplate.Height = 25;
            this.dataDummys.Size = new System.Drawing.Size(1345, 706);
            this.dataDummys.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1364, 750);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errorres";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Location = new System.Drawing.Point(4, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1355, 740);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1347, 712);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Errores Lexicos";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1347, 712);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Errores Semanticos";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1347, 712);
            this.tabPage10.TabIndex = 2;
            this.tabPage10.Text = "Errores Sintacticos";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // ComponenteL
            // 
            this.ComponenteL.HeaderText = "Componente";
            this.ComponenteL.Name = "ComponenteL";
            // 
            // ComponenteP
            // 
            this.ComponenteP.HeaderText = "Componente";
            this.ComponenteP.Name = "ComponenteP";
            // 
            // ComponenteS
            // 
            this.ComponenteS.HeaderText = "Componente";
            this.ComponenteS.Name = "ComponenteS";
            this.ComponenteS.ReadOnly = true;
            // 
            // ComponenteD
            // 
            this.ComponenteD.HeaderText = "Componente";
            this.ComponenteD.Name = "ComponenteD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 791);
            this.Controls.Add(this.tabIngreso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabIngreso.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSimbolos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPalabrasReservadas)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLiterales)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDummys)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabIngreso;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button cargarInfoConsola;
        private System.Windows.Forms.Button botonCargarInfo;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.TextBox textRuta;
        private System.Windows.Forms.RichTextBox salidaDatos;
        private System.Windows.Forms.RichTextBox entradaDatosConsola;
        private System.Windows.Forms.Label labelSalida;
        private System.Windows.Forms.Label labelEntrada;
        private System.Windows.Forms.CheckBox checkConsola;
        private System.Windows.Forms.CheckBox checkArchivo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataSimbolos;
        private System.Windows.Forms.DataGridView dataPalabrasReservadas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView dataLiterales;
        private System.Windows.Forms.DataGridView dataDummys;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponenteS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponenteP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponenteL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponenteD;
    }
}

