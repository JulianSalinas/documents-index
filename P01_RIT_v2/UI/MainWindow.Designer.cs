﻿namespace P01_RIT_v2.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxNombreInvertido = new MetroFramework.Controls.MetroTextBox();
            this.textBoxInvertido = new MetroFramework.Controls.MetroTextBox();
            this.textBoxInvertidoConsultas = new MetroFramework.Controls.MetroTextBox();
            this.buttonInvertidoConsultas = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.buttonInvertido = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.buttonColeccion = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.buttonIndexar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.textBoxPrefijo = new MetroFramework.Controls.MetroTextBox();
            this.textBoxColeccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextButton1 = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.buttonConsultaVectorial = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.textBoxConsultaVectorial = new MetroFramework.Controls.MetroTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRutaArchivoInvertido = new MetroFramework.Controls.MetroTextBox();
            this.buttonRutaArchivoInvertido = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(52, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 411);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxRutaArchivoInvertido);
            this.tabPage1.Controls.Add(this.buttonRutaArchivoInvertido);
            this.tabPage1.Controls.Add(this.metroLabel8);
            this.tabPage1.Controls.Add(this.metroLabel2);
            this.tabPage1.Controls.Add(this.textBoxNombreInvertido);
            this.tabPage1.Controls.Add(this.textBoxInvertido);
            this.tabPage1.Controls.Add(this.textBoxInvertidoConsultas);
            this.tabPage1.Controls.Add(this.buttonInvertidoConsultas);
            this.tabPage1.Controls.Add(this.buttonInvertido);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.buttonColeccion);
            this.tabPage1.Controls.Add(this.metroLabel4);
            this.tabPage1.Controls.Add(this.buttonIndexar);
            this.tabPage1.Controls.Add(this.textBoxPrefijo);
            this.tabPage1.Controls.Add(this.textBoxColeccion);
            this.tabPage1.Controls.Add(this.metroLabel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(653, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opciones e indexado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(88, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(183, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "Nombre del archivo invertido";
            // 
            // textBoxNombreInvertido
            // 
            // 
            // 
            // 
            this.textBoxNombreInvertido.CustomButton.Image = null;
            this.textBoxNombreInvertido.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.textBoxNombreInvertido.CustomButton.Name = "";
            this.textBoxNombreInvertido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxNombreInvertido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNombreInvertido.CustomButton.TabIndex = 1;
            this.textBoxNombreInvertido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNombreInvertido.CustomButton.UseSelectable = true;
            this.textBoxNombreInvertido.CustomButton.Visible = false;
            this.textBoxNombreInvertido.Lines = new string[] {
        "  Archivo Invertido"};
            this.textBoxNombreInvertido.Location = new System.Drawing.Point(88, 57);
            this.textBoxNombreInvertido.MaxLength = 32767;
            this.textBoxNombreInvertido.Name = "textBoxNombreInvertido";
            this.textBoxNombreInvertido.PasswordChar = '\0';
            this.textBoxNombreInvertido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNombreInvertido.SelectedText = "";
            this.textBoxNombreInvertido.SelectionLength = 0;
            this.textBoxNombreInvertido.SelectionStart = 0;
            this.textBoxNombreInvertido.Size = new System.Drawing.Size(339, 23);
            this.textBoxNombreInvertido.TabIndex = 27;
            this.textBoxNombreInvertido.Text = "  Archivo Invertido";
            this.textBoxNombreInvertido.UseSelectable = true;
            this.textBoxNombreInvertido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxNombreInvertido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxInvertido
            // 
            // 
            // 
            // 
            this.textBoxInvertido.CustomButton.Image = null;
            this.textBoxInvertido.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.textBoxInvertido.CustomButton.Name = "";
            this.textBoxInvertido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxInvertido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxInvertido.CustomButton.TabIndex = 1;
            this.textBoxInvertido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxInvertido.CustomButton.UseSelectable = true;
            this.textBoxInvertido.CustomButton.Visible = false;
            this.textBoxInvertido.Lines = new string[0];
            this.textBoxInvertido.Location = new System.Drawing.Point(35, 184);
            this.textBoxInvertido.MaxLength = 32767;
            this.textBoxInvertido.Name = "textBoxInvertido";
            this.textBoxInvertido.PasswordChar = '\0';
            this.textBoxInvertido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxInvertido.SelectedText = "";
            this.textBoxInvertido.SelectionLength = 0;
            this.textBoxInvertido.SelectionStart = 0;
            this.textBoxInvertido.Size = new System.Drawing.Size(524, 23);
            this.textBoxInvertido.TabIndex = 19;
            this.textBoxInvertido.UseSelectable = true;
            this.textBoxInvertido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxInvertido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxInvertidoConsultas
            // 
            // 
            // 
            // 
            this.textBoxInvertidoConsultas.CustomButton.Image = null;
            this.textBoxInvertidoConsultas.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.textBoxInvertidoConsultas.CustomButton.Name = "";
            this.textBoxInvertidoConsultas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxInvertidoConsultas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxInvertidoConsultas.CustomButton.TabIndex = 1;
            this.textBoxInvertidoConsultas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxInvertidoConsultas.CustomButton.UseSelectable = true;
            this.textBoxInvertidoConsultas.CustomButton.Visible = false;
            this.textBoxInvertidoConsultas.Lines = new string[0];
            this.textBoxInvertidoConsultas.Location = new System.Drawing.Point(35, 249);
            this.textBoxInvertidoConsultas.MaxLength = 32767;
            this.textBoxInvertidoConsultas.Name = "textBoxInvertidoConsultas";
            this.textBoxInvertidoConsultas.PasswordChar = '\0';
            this.textBoxInvertidoConsultas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxInvertidoConsultas.SelectedText = "";
            this.textBoxInvertidoConsultas.SelectionLength = 0;
            this.textBoxInvertidoConsultas.SelectionStart = 0;
            this.textBoxInvertidoConsultas.Size = new System.Drawing.Size(524, 23);
            this.textBoxInvertidoConsultas.TabIndex = 29;
            this.textBoxInvertidoConsultas.UseSelectable = true;
            this.textBoxInvertidoConsultas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxInvertidoConsultas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonInvertidoConsultas
            // 
            this.buttonInvertidoConsultas.Image = null;
            this.buttonInvertidoConsultas.Location = new System.Drawing.Point(565, 249);
            this.buttonInvertidoConsultas.Name = "buttonInvertidoConsultas";
            this.buttonInvertidoConsultas.Size = new System.Drawing.Size(51, 23);
            this.buttonInvertidoConsultas.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonInvertidoConsultas.TabIndex = 31;
            this.buttonInvertidoConsultas.Text = "...";
            this.buttonInvertidoConsultas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonInvertidoConsultas.UseSelectable = true;
            this.buttonInvertidoConsultas.UseVisualStyleBackColor = true;
            this.buttonInvertidoConsultas.Click += new System.EventHandler(this.buttonInvertidoConsultas_Click);
            // 
            // buttonInvertido
            // 
            this.buttonInvertido.Image = null;
            this.buttonInvertido.Location = new System.Drawing.Point(565, 184);
            this.buttonInvertido.Name = "buttonInvertido";
            this.buttonInvertido.Size = new System.Drawing.Size(51, 23);
            this.buttonInvertido.Style = MetroFramework.MetroColorStyle.Green;
            this.buttonInvertido.TabIndex = 26;
            this.buttonInvertido.Text = "...";
            this.buttonInvertido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonInvertido.UseSelectable = true;
            this.buttonInvertido.UseVisualStyleBackColor = true;
            this.buttonInvertido.Click += new System.EventHandler(this.buttonInvertido_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 227);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(294, 19);
            this.metroLabel1.TabIndex = 30;
            this.metroLabel1.Text = "Ruta para guardar los resultados de las consultas";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(35, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(219, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Ruta para guardar archivo invertido";
            // 
            // buttonColeccion
            // 
            this.buttonColeccion.Image = null;
            this.buttonColeccion.Location = new System.Drawing.Point(565, 122);
            this.buttonColeccion.Name = "buttonColeccion";
            this.buttonColeccion.Size = new System.Drawing.Size(51, 23);
            this.buttonColeccion.Style = MetroFramework.MetroColorStyle.Teal;
            this.buttonColeccion.TabIndex = 25;
            this.buttonColeccion.Text = "...";
            this.buttonColeccion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonColeccion.UseSelectable = true;
            this.buttonColeccion.UseVisualStyleBackColor = true;
            this.buttonColeccion.Click += new System.EventHandler(this.buttonColeccion_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(35, 100);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Ruta de la colección";
            // 
            // buttonIndexar
            // 
            this.buttonIndexar.Image = null;
            this.buttonIndexar.Location = new System.Drawing.Point(433, 57);
            this.buttonIndexar.Name = "buttonIndexar";
            this.buttonIndexar.Size = new System.Drawing.Size(183, 23);
            this.buttonIndexar.Style = MetroFramework.MetroColorStyle.Red;
            this.buttonIndexar.TabIndex = 20;
            this.buttonIndexar.Text = "Indexar Coleccion";
            this.buttonIndexar.UseSelectable = true;
            this.buttonIndexar.UseVisualStyleBackColor = true;
            this.buttonIndexar.Click += new System.EventHandler(this.buttonIndexar_Click);
            // 
            // textBoxPrefijo
            // 
            // 
            // 
            // 
            this.textBoxPrefijo.CustomButton.Image = null;
            this.textBoxPrefijo.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.textBoxPrefijo.CustomButton.Name = "";
            this.textBoxPrefijo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPrefijo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPrefijo.CustomButton.TabIndex = 1;
            this.textBoxPrefijo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPrefijo.CustomButton.UseSelectable = true;
            this.textBoxPrefijo.CustomButton.Visible = false;
            this.textBoxPrefijo.Lines = new string[0];
            this.textBoxPrefijo.Location = new System.Drawing.Point(35, 57);
            this.textBoxPrefijo.MaxLength = 32767;
            this.textBoxPrefijo.Name = "textBoxPrefijo";
            this.textBoxPrefijo.PasswordChar = '\0';
            this.textBoxPrefijo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPrefijo.SelectedText = "";
            this.textBoxPrefijo.SelectionLength = 0;
            this.textBoxPrefijo.SelectionStart = 0;
            this.textBoxPrefijo.Size = new System.Drawing.Size(47, 23);
            this.textBoxPrefijo.TabIndex = 17;
            this.textBoxPrefijo.UseSelectable = true;
            this.textBoxPrefijo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPrefijo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPrefijo.TextChanged += new System.EventHandler(this.textBoxPrefijo_TextChanged);
            // 
            // textBoxColeccion
            // 
            // 
            // 
            // 
            this.textBoxColeccion.CustomButton.Image = null;
            this.textBoxColeccion.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.textBoxColeccion.CustomButton.Name = "";
            this.textBoxColeccion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxColeccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxColeccion.CustomButton.TabIndex = 1;
            this.textBoxColeccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxColeccion.CustomButton.UseSelectable = true;
            this.textBoxColeccion.CustomButton.Visible = false;
            this.textBoxColeccion.Lines = new string[0];
            this.textBoxColeccion.Location = new System.Drawing.Point(35, 122);
            this.textBoxColeccion.MaxLength = 32767;
            this.textBoxColeccion.Name = "textBoxColeccion";
            this.textBoxColeccion.PasswordChar = '\0';
            this.textBoxColeccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxColeccion.SelectedText = "";
            this.textBoxColeccion.SelectionLength = 0;
            this.textBoxColeccion.SelectionStart = 0;
            this.textBoxColeccion.Size = new System.Drawing.Size(524, 23);
            this.textBoxColeccion.TabIndex = 18;
            this.textBoxColeccion.UseSelectable = true;
            this.textBoxColeccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxColeccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Prefijo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.metroLabel7);
            this.tabPage2.Controls.Add(this.metroTextButton1);
            this.tabPage2.Controls.Add(this.metroTextBox1);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.buttonConsultaVectorial);
            this.tabPage2.Controls.Add(this.textBoxConsultaVectorial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(653, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas y busquedas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(36, 123);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(135, 19);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Consulta estructurada";
            // 
            // metroTextButton1
            // 
            this.metroTextButton1.Image = null;
            this.metroTextButton1.Location = new System.Drawing.Point(439, 145);
            this.metroTextButton1.Name = "metroTextButton1";
            this.metroTextButton1.Size = new System.Drawing.Size(183, 23);
            this.metroTextButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTextButton1.TabIndex = 26;
            this.metroTextButton1.Text = "Realizar consulta";
            this.metroTextButton1.UseSelectable = true;
            this.metroTextButton1.UseVisualStyleBackColor = true;
            this.metroTextButton1.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(375, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(36, 145);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.Size = new System.Drawing.Size(397, 23);
            this.metroTextBox1.TabIndex = 25;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Consulta vectorial";
            // 
            // buttonConsultaVectorial
            // 
            this.buttonConsultaVectorial.Image = null;
            this.buttonConsultaVectorial.Location = new System.Drawing.Point(439, 81);
            this.buttonConsultaVectorial.Name = "buttonConsultaVectorial";
            this.buttonConsultaVectorial.Size = new System.Drawing.Size(183, 23);
            this.buttonConsultaVectorial.Style = MetroFramework.MetroColorStyle.Red;
            this.buttonConsultaVectorial.TabIndex = 22;
            this.buttonConsultaVectorial.Text = "Realizar consulta";
            this.buttonConsultaVectorial.UseSelectable = true;
            this.buttonConsultaVectorial.UseVisualStyleBackColor = true;
            this.buttonConsultaVectorial.Click += new System.EventHandler(this.buttonConsultaVectorial_Click);
            // 
            // textBoxConsultaVectorial
            // 
            // 
            // 
            // 
            this.textBoxConsultaVectorial.CustomButton.Image = null;
            this.textBoxConsultaVectorial.CustomButton.Location = new System.Drawing.Point(375, 1);
            this.textBoxConsultaVectorial.CustomButton.Name = "";
            this.textBoxConsultaVectorial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxConsultaVectorial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxConsultaVectorial.CustomButton.TabIndex = 1;
            this.textBoxConsultaVectorial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxConsultaVectorial.CustomButton.UseSelectable = true;
            this.textBoxConsultaVectorial.CustomButton.Visible = false;
            this.textBoxConsultaVectorial.Lines = new string[0];
            this.textBoxConsultaVectorial.Location = new System.Drawing.Point(36, 81);
            this.textBoxConsultaVectorial.MaxLength = 32767;
            this.textBoxConsultaVectorial.Name = "textBoxConsultaVectorial";
            this.textBoxConsultaVectorial.PasswordChar = '\0';
            this.textBoxConsultaVectorial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxConsultaVectorial.SelectedText = "";
            this.textBoxConsultaVectorial.SelectionLength = 0;
            this.textBoxConsultaVectorial.SelectionStart = 0;
            this.textBoxConsultaVectorial.Size = new System.Drawing.Size(397, 23);
            this.textBoxConsultaVectorial.TabIndex = 21;
            this.textBoxConsultaVectorial.UseSelectable = true;
            this.textBoxConsultaVectorial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxConsultaVectorial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBoxRutaArchivoInvertido
            // 
            // 
            // 
            // 
            this.textBoxRutaArchivoInvertido.CustomButton.Image = null;
            this.textBoxRutaArchivoInvertido.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.textBoxRutaArchivoInvertido.CustomButton.Name = "";
            this.textBoxRutaArchivoInvertido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxRutaArchivoInvertido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxRutaArchivoInvertido.CustomButton.TabIndex = 1;
            this.textBoxRutaArchivoInvertido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxRutaArchivoInvertido.CustomButton.UseSelectable = true;
            this.textBoxRutaArchivoInvertido.CustomButton.Visible = false;
            this.textBoxRutaArchivoInvertido.Lines = new string[0];
            this.textBoxRutaArchivoInvertido.Location = new System.Drawing.Point(35, 314);
            this.textBoxRutaArchivoInvertido.MaxLength = 32767;
            this.textBoxRutaArchivoInvertido.Name = "textBoxRutaArchivoInvertido";
            this.textBoxRutaArchivoInvertido.PasswordChar = '\0';
            this.textBoxRutaArchivoInvertido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRutaArchivoInvertido.SelectedText = "";
            this.textBoxRutaArchivoInvertido.SelectionLength = 0;
            this.textBoxRutaArchivoInvertido.SelectionStart = 0;
            this.textBoxRutaArchivoInvertido.Size = new System.Drawing.Size(524, 23);
            this.textBoxRutaArchivoInvertido.TabIndex = 33;
            this.textBoxRutaArchivoInvertido.UseSelectable = true;
            this.textBoxRutaArchivoInvertido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxRutaArchivoInvertido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonRutaArchivoInvertido
            // 
            this.buttonRutaArchivoInvertido.Image = null;
            this.buttonRutaArchivoInvertido.Location = new System.Drawing.Point(565, 314);
            this.buttonRutaArchivoInvertido.Name = "buttonRutaArchivoInvertido";
            this.buttonRutaArchivoInvertido.Size = new System.Drawing.Size(51, 23);
            this.buttonRutaArchivoInvertido.Style = MetroFramework.MetroColorStyle.Pink;
            this.buttonRutaArchivoInvertido.TabIndex = 35;
            this.buttonRutaArchivoInvertido.Text = "...";
            this.buttonRutaArchivoInvertido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.buttonRutaArchivoInvertido.UseSelectable = true;
            this.buttonRutaArchivoInvertido.UseVisualStyleBackColor = true;
            this.buttonRutaArchivoInvertido.Click += new System.EventHandler(this.buttonRutaArchivoInvertido_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(35, 292);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(293, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Ruta del archivo invertido para realizar consultas";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "Bienvenido";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxNombreInvertido;
        private MetroFramework.Controls.MetroTextBox textBoxInvertido;
        private MetroFramework.Controls.MetroTextBox textBoxInvertidoConsultas;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonInvertidoConsultas;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonInvertido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonColeccion;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonIndexar;
        private MetroFramework.Controls.MetroTextBox textBoxPrefijo;
        private MetroFramework.Controls.MetroTextBox textBoxColeccion;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton metroTextButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonConsultaVectorial;
        private MetroFramework.Controls.MetroTextBox textBoxConsultaVectorial;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Controls.MetroTextBox textBoxRutaArchivoInvertido;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton buttonRutaArchivoInvertido;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}