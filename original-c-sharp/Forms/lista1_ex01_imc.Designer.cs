namespace Exercicios
{
    partial class lista1_ex01_imc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            txt_peso = new TextBox();
            txt_altura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_menu = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(340, 85);
            button1.Name = "button1";
            button1.Size = new Size(237, 58);
            button1.TabIndex = 0;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_peso
            // 
            txt_peso.Location = new Point(186, 76);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(100, 23);
            txt_peso.TabIndex = 1;
            txt_peso.TextChanged += textBox1_TextChanged;
            // 
            // txt_altura
            // 
            txt_altura.Location = new Point(186, 125);
            txt_altura.Name = "txt_altura";
            txt_altura.Size = new Size(100, 23);
            txt_altura.TabIndex = 2;
            txt_altura.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 79);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Peso:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 128);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Altura (com virgula):";
            // 
            // btn_menu
            // 
            btn_menu.Location = new Point(282, 327);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(106, 39);
            btn_menu.TabIndex = 6;
            btn_menu.Text = "Voltar para o Menu";
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 335);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(177, 335);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lista1_ex01_imc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 455);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_menu);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_altura);
            Controls.Add(txt_peso);
            Controls.Add(button1);
            Name = "lista1_ex01_imc";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_mudarForm2;
        private Button button1;
        private TextBox txt_peso;
        private TextBox txt_altura;
        private Label label1;
        private Label label2;
        private Button btn_menu;
        private Button button2;
        private Button button3;
    }
}
