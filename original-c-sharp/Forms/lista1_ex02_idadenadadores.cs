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
    public partial class lista1_ex02_idadenadadores : Form
    {
        int idade;
        string res;
        public lista1_ex02_idadenadadores()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            idade = Convert.ToInt32(txt_idade.Text);

            if (idade < 5)
            {
                res = "Você não pode ser classificado";
            }

            else if (idade >= 5 && idade <= 7)
            {
                res = "Infantil A";
            }
            else if (idade >= 8 && idade <= 10)
            {
                res = "Infantil B";
            }
            else if (idade >= 11 && idade <= 13)
            {
                res = "Juvenil A";
            }
            else if (idade >= 14 && idade <= 17)
            {
                res = "Juvenil B";
            }
            else if (idade >= 18 && idade <= 25)
            {
                res = "Sênior";
            }

            MessageBox.Show("Sua Classificação é: " + res);
        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_idade.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
