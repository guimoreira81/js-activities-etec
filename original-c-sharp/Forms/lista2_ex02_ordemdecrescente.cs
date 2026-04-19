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
    public partial class lista2_ex02_ordemdecrescente : Form
    {
        float num1, num2, num3;
        public lista2_ex02_ordemdecrescente()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToSingle(txt_num1.Text);
            num2 = Convert.ToSingle(txt_num2.Text);
            num3 = Convert.ToSingle(txt_num3.Text);

            if (num1 >= num2 && num1 >= num3 && num2 >= num3)
            {
                MessageBox.Show("Ordem decrescente: " + num1 + " - " + num2 + " - " + num3);
            }
            else if (num1 >= num2 && num1 >= num3 && num3 >= num2)
            {
                MessageBox.Show("Ordem decrescente: " + num1 + " - " + num3 + " - " + num2);
            }
            else if (num2 >= num1 && num2 >= num3 && num1 >= num3)
            {
                MessageBox.Show("Ordem decrescente: " + num2 + " - " + num1 + " - " + num3);
            }
            else if (num2 >= num1 && num2 >= num3 && num3 >= num1)
            {
                MessageBox.Show("Ordem decrescente: " + num2 + " - " + num3 + " - " + num1);
            }
            else if (num3 >= num1 && num3 >= num2 && num1 >= num2)
            {
                MessageBox.Show("Ordem decrescente: " + num3 + " - " + num1 + " - " + num2);
            }
            else
            {
                MessageBox.Show("Ordem decrescente: " + num3 + " - " + num2 + " - " + num1);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            txt_num3.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
