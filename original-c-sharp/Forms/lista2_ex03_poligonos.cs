using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Exercicios
{
    public partial class lista2_ex03_poligonos : Form
    {
        int lados;
        double medida, area;
        public lista2_ex03_poligonos()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            lados = Convert.ToInt32(txt_lados.Text);
            medida = Convert.ToDouble(txt_medida.Text);

            if (lados == 3)
            {
                area = (medida * medida) / 2;
                MessageBox.Show("TRIÂNGULO\nÁrea: " + area + " cm");
            }
            else if (lados == 4)
            {
                area = medida * medida;
                MessageBox.Show("QUADRADO\nÁrea: " + area + " cm");
            }
            else if (lados == 5)
            {
                MessageBox.Show("PENTÁGONO");
            }
            else if (lados < 3)
            {
                MessageBox.Show("NÃO É UM POLÍGONO");
            }
            else if (lados > 5)
            {
                MessageBox.Show("POLÍGONO NÃO IDENTIFICADO");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_lados.Clear();
            txt_medida.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
