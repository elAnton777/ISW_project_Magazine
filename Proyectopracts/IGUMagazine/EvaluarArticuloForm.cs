﻿using Magazine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGUMagazine
{
    public partial class EvaluarArticuloForm : Form
    {
        public EvaluarArticuloForm()
        {
            InitializeComponent();

            foreach (Area area in LoginForm.service.getAllAreas())
            {
                AreasComboBox.Items.Add(area.Name);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ArticulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AreaSeleccioada = AreasComboBox.Text;
            if (AreaSeleccioada != "")
            {
                Area area = LoginForm.service.FindAreaByName(AreaSeleccioada);
                foreach (Paper paper in area.EvaluationPending)
                {
                    ArticulosComboBox.Items.Add(paper.Title + " ");
                }
            }

        }
    }
}
