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
    public partial class lista2_ex04_triangulos : Form
    {
        double valorA, valorB, valorC;
        public lista2_ex04_triangulos()
        {
            InitializeComponent();
        }

        private void lista2_ex04_triangulos_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            valorA = Convert.ToDouble(txt_valorA.Text);
            valorB = Convert.ToDouble(txt_valorB.Text);
            valorC = Convert.ToDouble(txt_valorC.Text);

            if (valorA > 0 && valorB > 0 && valorC > 0 &&
                (valorA < valorB + valorC) &&
                (valorB < valorA + valorC) &&
                (valorC < valorA + valorB))
            {
                if (valorA == valorB && valorB == valorC)
                {
                    MessageBox.Show("O triângulo é EQUILÁTERO");
                    pct_triangulo.Image = Image.FromFile(@"equilatero.png");
                }
                else if (valorA != valorB && valorA != valorC && valorB != valorC)
                {
                    MessageBox.Show("O triângulo é ESCALENO");
                    pct_triangulo.Image = Image.FromFile(@"escaleno.png");
                }
                else
                {
                    MessageBox.Show("O triângulo é ISÓSCELES");
                    pct_triangulo.Image = Image.FromFile(@"isosceles.png");
                }
            }
            else
            {
                MessageBox.Show("Não é um triângulo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valorA.Clear();
            txt_valorB.Clear();
            txt_valorC.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
