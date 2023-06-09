﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGUMagazine
{
    public partial class SelectActionForm : Form
    {
        public SelectActionForm()
        {
            InitializeComponent();
        }

        private void EnviarArticulo_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendArticleForm sendArticleForm= new SendArticleForm();
            sendArticleForm.ShowDialog();
            this.Show();
        }

        private void EvaluarArticulo_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluarArticuloForm evaluarArticuloForm = new EvaluarArticuloForm();
            evaluarArticuloForm.ShowDialog();
            this.Show();
        }

        private void ListadoDeArticulos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaArticulos listaArticulos = new ListaArticulos();
            listaArticulos.ShowDialog();
            this.Show();
        }

        private void ConfeccionarEjemplar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConfeccionarEjemplar confeccionarEjemplar = new ConfeccionarEjemplar();
            confeccionarEjemplar.ShowDialog();
            this.Show();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
