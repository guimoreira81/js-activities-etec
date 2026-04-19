namespace Exercicios
{
    partial class lista2_ex02_ordemdecrescente
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
            lbl_titulo = new Label();
            lbl_num3 = new Label();
            lbl_num2 = new Label();
            txt_num3 = new TextBox();
            btn_sair = new Button();
            btn_limpar = new Button();
            txt_num2 = new TextBox();
            txt_num1 = new TextBox();
            btn_enviar = new Button();
            lbl_num1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(309, 76);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(212, 15);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "ORDEM DECRESCENTE DOS NÚMEROS";
            // 
            // lbl_num3
            // 
            lbl_num3.AutoSize = true;
            lbl_num3.Location = new Point(142, 222);
            lbl_num3.Name = "lbl_num3";
            lbl_num3.Size = new Size(139, 15);
            lbl_num3.TabIndex = 20;
            lbl_num3.Text = "Digite o terceiro número:";
            // 
            // lbl_num2
            // 
            lbl_num2.AutoSize = true;
            lbl_num2.Location = new Point(142, 171);
            lbl_num2.Name = "lbl_num2";
            lbl_num2.Size = new Size(145, 15);
            lbl_num2.TabIndex = 19;
            lbl_num2.Text = "Digite o segundo número:";
            // 
            // txt_num3
            // 
            txt_num3.Location = new Point(142, 240);
            txt_num3.Name = "txt_num3";
            txt_num3.Size = new Size(100, 23);
            txt_num3.TabIndex = 18;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(529, 287);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 16;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(430, 287);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 15;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(142, 189);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 13;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(142, 139);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 14;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(325, 287);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 12;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // lbl_num1
            // 
            lbl_num1.AutoSize = true;
            lbl_num1.Location = new Point(142, 121);
            lbl_num1.Name = "lbl_num1";
            lbl_num1.Size = new Size(147, 15);
            lbl_num1.TabIndex = 11;
            lbl_num1.Text = "Digite o primeiro número: ";
            // 
            // button1
            // 
            button1.Location = new Point(637, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 23;
            button1.Text = "Voltar para o Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lista2_ex02_ordemdecrescente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_num3);
            Controls.Add(lbl_num2);
            Controls.Add(txt_num3);
            Controls.Add(btn_sair);
            Controls.Add(btn_limpar);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_num1);
            Name = "lista2_ex02_ordemdecrescente";
            Text = "lista2_ex02_ordemcrescente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_num3;
        private Label lbl_num2;
        private TextBox txt_num3;
        private Button btn_sair;
        private Button btn_limpar;
        private TextBox txt_num2;
        private TextBox txt_num1;
        private Button btn_enviar;
        private Label lbl_num1;
        private Button button1;
    }
}