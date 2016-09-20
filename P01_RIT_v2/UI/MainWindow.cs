﻿using MetroFramework.Forms;
using P01_RIT_v2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P01_RIT_v2.UI
{
    public partial class MainWindow : MetroForm
    {
        public MainWindow() {
            InitializeComponent();
            textBoxPrefijo.Text = Opciones.Instance.Prefijo;
            textBoxColeccion.Text = Opciones.Instance.RutaColeccion;
            textBoxInvertido.Text = Opciones.Instance.RutaArchivos;
        }

        private void buttonColeccion_Click( object sender, EventArgs e ) {
            folderBrowserDialog.Description = "Escoge la carpeda donde esta almacenada la colección";
            folderBrowserDialog.ShowDialog();
            textBoxColeccion.Text = folderBrowserDialog.SelectedPath;
            Opciones.Instance.RutaColeccion = folderBrowserDialog.SelectedPath;
            Opciones.Instance.guardarOpciones();
        }

        private void buttonInvertido_Click( object sender, EventArgs e ) {
            folderBrowserDialog.Description = "Escoge la carpeda donde almacenará el archivo invertido";
            folderBrowserDialog.ShowDialog();
            textBoxColeccion.Text = folderBrowserDialog.SelectedPath;
            Opciones.Instance.RutaArchivos = folderBrowserDialog.SelectedPath;
            Opciones.Instance.guardarOpciones();
        }


    }
}