namespace Exercicios
{
    partial class ex00_notas
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
            txt_nome = new TextBox();
            txt_nota1 = new TextBox();
            txt_nota2 = new TextBox();
            txt_nota3 = new TextBox();
            lbl_titulo = new Label();
            lbl_nome = new Label();
            lbl_nota1 = new Label();
            lbl_nota2 = new Label();
            lbl_nota3 = new Label();
            btn_enviar = new Button();
            btn_limpar = new Button();
            btn_sair = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(160, 145);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 0;
            // 
            // txt_nota1
            // 
            txt_nota1.Location = new Point(160, 199);
            txt_nota1.Name = "txt_nota1";
            txt_nota1.Size = new Size(100, 23);
            txt_nota1.TabIndex = 1;
            // 
            // txt_nota2
            // 
            txt_nota2.Location = new Point(160, 252);
            txt_nota2.Name = "txt_nota2";
            txt_nota2.Size = new Size(100, 23);
            txt_nota2.TabIndex = 2;
            // 
            // txt_nota3
            // 
            txt_nota3.Location = new Point(160, 303);
            txt_nota3.Name = "txt_nota3";
            txt_nota3.Size = new Size(100, 23);
            txt_nota3.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(208, 47);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(399, 44);
            lbl_titulo.TabIndex = 4;
            lbl_titulo.Text = "ANÁLISE DE NOTAS";
            lbl_titulo.Click += lbl_titulo_Click;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(160, 127);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(96, 15);
            lbl_nome.TabIndex = 5;
            lbl_nome.Text = "Digite seu nome:";
            // 
            // lbl_nota1
            // 
            lbl_nota1.AutoSize = true;
            lbl_nota1.Location = new Point(160, 181);
            lbl_nota1.Name = "lbl_nota1";
            lbl_nota1.Size = new Size(124, 15);
            lbl_nota1.TabIndex = 6;
            lbl_nota1.Text = "Digite a primeira nota:";
            // 
            // lbl_nota2
            // 
            lbl_nota2.AutoSize = true;
            lbl_nota2.Location = new Point(160, 234);
            lbl_nota2.Name = "lbl_nota2";
            lbl_nota2.Size = new Size(125, 15);
            lbl_nota2.TabIndex = 7;
            lbl_nota2.Text = "Digite a segunda nota:";
            lbl_nota2.Click += label4_Click;
            // 
            // lbl_nota3
            // 
            lbl_nota3.AutoSize = true;
            lbl_nota3.Location = new Point(160, 285);
            lbl_nota3.Name = "lbl_nota3";
            lbl_nota3.Size = new Size(119, 15);
            lbl_nota3.TabIndex = 8;
            lbl_nota3.Text = "Digite a terceira nota:";
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(362, 303);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 9;
            btn_enviar.Text = "CALCULAR";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(460, 303);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 10;
            btn_limpar.Text = "LIMPAR";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += button1_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(565, 303);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 11;
            btn_sair.Text = "SAIR";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // button1
            // 
            button1.Location = new Point(460, 343);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 12;
            button1.Text = "Voltar para o Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ex00_notas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 447);
            Controls.Add(button1);
            Controls.Add(btn_sair);
            Controls.Add(btn_limpar);
            Controls.Add(btn_enviar);
            Controls.Add(lbl_nota3);
            Controls.Add(lbl_nota2);
            Controls.Add(lbl_nota1);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_titulo);
            Controls.Add(txt_nota3);
            Controls.Add(txt_nota2);
            Controls.Add(txt_nota1);
            Controls.Add(txt_nome);
            Name = "ex00_notas";
            Text = "exercicioavulso_notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nome;
        private TextBox txt_nota1;
        private TextBox txt_nota2;
        private TextBox txt_nota3;
        private Label lbl_titulo;
        private Label lbl_nome;
        private Label lbl_nota1;
        private Label lbl_nota2;
        private Label lbl_nota3;
        private Button btn_enviar;
        private Button btn_limpar;
        private Button btn_sair;
        private Button button1;
    }
}