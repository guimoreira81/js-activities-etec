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
    public partial class ex00_notas : Form
    {
        string nome;
        float nota1, nota2, nota3, media;
        public ex00_notas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            nome = txt_nome.Text;
            nota1 = Convert.ToSingle(txt_nota1.Text);
            nota2 = Convert.ToSingle(txt_nota2.Text);
            nota3 = Convert.ToSingle(txt_nota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            if (media > 5)
            {
                MessageBox.Show("Olá, " + nome + " você foi aprovado com uma média de " + media);
            }
            else
            {
                MessageBox.Show("Olá, " + nome + " você foi reprovado com uma média de " + media);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_nota1.Clear();
            txt_nota2.Clear();
            txt_nota3.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }
    }
}
