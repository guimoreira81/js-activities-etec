using System.Net.Mail;

namespace Exercicios
{
    public partial class lista1_ex01_imc : Form
    {
        string res;
        double peso, imc, alt;
        public lista1_ex01_imc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            peso = Convert.ToDouble(txt_peso.Text);
            alt = Convert.ToDouble(txt_altura.Text);

            imc = peso / (alt * alt);

            if (imc < 18.5)
            {
                res = "MUITO MAGRO";
            }
            else if (imc < 25)
            {
                res = "NORMAL";
            }
            else if (imc < 30)
            {
                res = "SOBREPESO";
            }
            else if (imc < 35)
            {
                res = "OBESIDADE GRAU 1";
            }
            else if (imc < 40)
            {
                res = "OBESIDADE SEVERA";
            }
            else
            {
                res = "OBESIDADE MÓRBIDA";
            }

            MessageBox.Show("Seu IMC: " + imc + "\nClassificação: " + res);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu = new menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_peso.Clear();
            txt_altura.Clear();
        }
    }
}
