using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form notas = new ex00_notas();
            notas.Show();
        }

        private void btn_imc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form imc = new lista1_ex01_imc();
            imc.Show();
        }

        private void btn_idadenadadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form idade = new lista1_ex02_idadenadadores();
            idade.Show();
        }

        private void btn_4numeros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form quatronumeros = new lista2_ex01_4numeros();
            quatronumeros.Show();
        }

        private void btn_ordemcrescente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ordemcrescente = new lista2_ex02_ordemdecrescente();
            ordemcrescente.Show();
        }

        private void btn_poligonos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form poligonos = new lista2_ex03_poligonos();
            poligonos.Show();
        }

        private void btn_triangulos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form triangulos = new lista2_ex04_triangulos();
            triangulos.Show();
        }
    }
}
