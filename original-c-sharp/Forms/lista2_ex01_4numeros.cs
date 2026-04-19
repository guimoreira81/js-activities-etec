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
    public partial class lista2_ex01_4numeros : Form
    {
        double num1, num2, num3, num4;
        public lista2_ex01_4numeros()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToSingle(txt_num1.Text);
            num2 = Convert.ToSingle(txt_num2.Text);
            num3 = Convert.ToSingle(txt_num3.Text);
            num4 = Convert.ToSingle(txt_num4.Text);

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                MessageBox.Show("O maior número é " + num1);
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                MessageBox.Show("O maior número é " + num2);
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                MessageBox.Show("O maior número é " + num3);
            }
            else if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                MessageBox.Show("O maior número é " + num4);
            }
            else
            {
                MessageBox.Show("Existem números iguais ou não foi possível determinar um maior");
            }

            if (num1 < num2 && num1 < num3 && num1 < num4)
            {
                MessageBox.Show("O menor número é " + num1);
            }
            else if (num2 < num1 && num2 < num3 && num2 < num4)
            {
                MessageBox.Show("O menor número é " + num2);
            }
            else if (num3 < num1 && num3 < num2 && num3 < num4)
            {
                MessageBox.Show("O menor número é " + num3);
            }
            else if (num4 < num1 && num4 < num2 && num4 < num3)
            {
                MessageBox.Show("O menor número é " + num4);
            }
            else
            {
                MessageBox.Show("Não há um único menor (há empate ou valores iguais)");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            txt_num3.Clear();
            txt_num4.Clear();
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
