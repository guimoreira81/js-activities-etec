namespace Exercicios
{
    partial class lista2_ex04_triangulos
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
            lbl_valorA = new Label();
            lbl_valorB = new Label();
            lbl_valorC = new Label();
            txt_valorA = new TextBox();
            txt_valorB = new TextBox();
            txt_valorC = new TextBox();
            btn_enviar = new Button();
            btn_sair = new Button();
            btn_limpar = new Button();
            pct_triangulo = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_triangulo).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(323, 62);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(77, 15);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "TRIÂNGULOS";
            // 
            // lbl_valorA
            // 
            lbl_valorA.AutoSize = true;
            lbl_valorA.Location = new Point(162, 163);
            lbl_valorA.Name = "lbl_valorA";
            lbl_valorA.Size = new Size(134, 15);
            lbl_valorA.TabIndex = 1;
            lbl_valorA.Text = "Digite o valor do lado A:";
            // 
            // lbl_valorB
            // 
            lbl_valorB.AutoSize = true;
            lbl_valorB.Location = new Point(162, 218);
            lbl_valorB.Name = "lbl_valorB";
            lbl_valorB.Size = new Size(133, 15);
            lbl_valorB.TabIndex = 2;
            lbl_valorB.Text = "Digite o valor do lado B:";
            // 
            // lbl_valorC
            // 
            lbl_valorC.AutoSize = true;
            lbl_valorC.Location = new Point(162, 268);
            lbl_valorC.Name = "lbl_valorC";
            lbl_valorC.Size = new Size(134, 15);
            lbl_valorC.TabIndex = 3;
            lbl_valorC.Text = "Digite o valor do lado C:";
            // 
            // txt_valorA
            // 
            txt_valorA.Location = new Point(169, 183);
            txt_valorA.Name = "txt_valorA";
            txt_valorA.Size = new Size(100, 23);
            txt_valorA.TabIndex = 4;
            // 
            // txt_valorB
            // 
            txt_valorB.Location = new Point(162, 236);
            txt_valorB.Name = "txt_valorB";
            txt_valorB.Size = new Size(100, 23);
            txt_valorB.TabIndex = 5;
            // 
            // txt_valorC
            // 
            txt_valorC.Location = new Point(162, 297);
            txt_valorC.Name = "txt_valorC";
            txt_valorC.Size = new Size(100, 23);
            txt_valorC.TabIndex = 6;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(162, 373);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 7;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(273, 373);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 8;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(381, 373);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 9;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // pct_triangulo
            // 
            pct_triangulo.Location = new Point(481, 183);
            pct_triangulo.Name = "pct_triangulo";
            pct_triangulo.Size = new Size(109, 76);
            pct_triangulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_triangulo.TabIndex = 11;
            pct_triangulo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(491, 373);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 12;
            button1.Text = "Voltar para o Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lista2_ex04_triangulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pct_triangulo);
            Controls.Add(btn_limpar);
            Controls.Add(btn_sair);
            Controls.Add(btn_enviar);
            Controls.Add(txt_valorC);
            Controls.Add(txt_valorB);
            Controls.Add(txt_valorA);
            Controls.Add(lbl_valorC);
            Controls.Add(lbl_valorB);
            Controls.Add(lbl_valorA);
            Controls.Add(lbl_titulo);
            Name = "lista2_ex04_triangulos";
            Text = "lista2_ex04_triangulos";
            Load += lista2_ex04_triangulos_Load;
            ((System.ComponentModel.ISupportInitialize)pct_triangulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_valorA;
        private Label lbl_valorB;
        private Label lbl_valorC;
        private TextBox txt_valorA;
        private TextBox txt_valorB;
        private TextBox txt_valorC;
        private Button btn_enviar;
        private Button btn_sair;
        private Button btn_limpar;
        private PictureBox pct_triangulo;
        private Button button1;
    }
}