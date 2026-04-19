namespace Exercicios
{
    partial class lista2_ex01_4numeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_num1 = new Label();
            btn_enviar = new Button();
            txt_num1 = new TextBox();
            btn_limpar = new Button();
            btn_sair = new Button();
            txt_num2 = new TextBox();
            txt_num4 = new TextBox();
            txt_num3 = new TextBox();
            lbl_num2 = new Label();
            lbl_num3 = new Label();
            lbl_num4 = new Label();
            lbl_titulo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(113, 82);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(147, 15);
            lbl_num1.TabIndex = 0;
            lbl_num1.Text = "Digite o primeiro número: ";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(308, 248);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 1;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(113, 100);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 2;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(408, 248);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 3;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(500, 248);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 4;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(113, 150);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 2;
            // 
            // txt_num4
            // 
            txt_num4.Location = new Point(113, 248);
            txt_num4.Name = "txt_num4";
            txt_num4.Size = new Size(100, 23);
            txt_num4.TabIndex = 5;
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(113, 201);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(100, 23);
            txt_num3.TabIndex = 6;
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(113, 132);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(145, 15);
            lbl_num2.TabIndex = 7;
            lbl_num2.Text = "Digite o segundo número:";
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.Location = new Point(113, 183);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(139, 15);
            lbl_num3.TabIndex = 8;
            lbl_num3.Text = "Digite o terceiro número:";
            // 
            // lbl_num4
            // 
            lbl_num4.AutoSize = true;
            lbl_num4.Location = new Point(113, 230);
            lbl_num4.Name = "lbl_num4";
            lbl_num4.Size = new Size(134, 15);
            lbl_num4.TabIndex = 9;
            lbl_num4.Text = "Digite o quarto número:";
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(308, 41);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(152, 15);
            lbl_titulo.TabIndex = 10;
            lbl_titulo.Text = "MAIOR E MENOR NÚMERO";
            // 
            // button1
            // 
            button1.Location = new Point(602, 247);
            button1.Name = "button1";
            button1.Size = new Size(75, 46);
            button1.TabIndex = 11;
            button1.Text = "Voltar para o Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lista2_ex01_4numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_num4);
            Controls.Add(lbl_num3);
            Controls.Add(lbl_num2);
            Controls.Add(txt_num3);
            Controls.Add(txt_num4);
            Controls.Add(btn_sair);
            Controls.Add(btn_limpar);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_num1);
            Name = "lista2_ex01_4numeros";
            Text = "lista2_ex01_4numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_num1;
        private Button btn_enviar;
        private TextBox txt_num1;
        private Button btn_limpar;
        private Button btn_sair;
        private TextBox txt_num2;
        private TextBox txt_num4;
        private TextBox txt_num3;
        private Label lbl_num2;
        private Label lbl_num3;
        private Label lbl_num4;
        private Label lbl_titulo;
        private Button button1;
    }
}