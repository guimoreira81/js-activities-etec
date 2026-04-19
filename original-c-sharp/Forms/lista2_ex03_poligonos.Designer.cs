namespace Exercicios
{
    partial class lista2_ex03_poligonos
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
            lbl_title = new Label();
            lbl_lados = new Label();
            lbl_medida = new Label();
            txt_lados = new TextBox();
            txt_medida = new TextBox();
            btn_enviar = new Button();
            btn_sair = new Button();
            btn_limpar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new Point(333, 62);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(73, 15);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "POLÍGONOS";
            // 
            // lbl_lados
            // 
            lbl_lados.AutoSize = true;
            lbl_lados.Location = new Point(125, 150);
            lbl_lados.Name = "lbl_lados";
            lbl_lados.Size = new Size(143, 15);
            lbl_lados.TabIndex = 1;
            lbl_lados.Text = "Digite o número de lados:";
            // 
            // lbl_medida
            // 
            lbl_medida.AutoSize = true;
            lbl_medida.Location = new Point(125, 218);
            lbl_medida.Name = "lbl_medida";
            lbl_medida.Size = new Size(222, 15);
            lbl_medida.TabIndex = 2;
            lbl_medida.Text = "Digite a medida do lado em centímetros:";
            // 
            // txt_lados
            // 
            txt_lados.Location = new Point(125, 168);
            txt_lados.Name = "txt_lados";
            txt_lados.Size = new Size(100, 23);
            txt_lados.TabIndex = 3;
            // 
            // txt_medida
            // 
            txt_medida.Location = new Point(125, 236);
            txt_medida.Name = "txt_medida";
            txt_medida.Size = new Size(100, 23);
            txt_medida.TabIndex = 4;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(125, 312);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(75, 23);
            btn_enviar.TabIndex = 5;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // btn_sair
            // 
            btn_sair.Location = new Point(231, 312);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(75, 23);
            btn_sair.TabIndex = 6;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = true;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(333, 312);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(75, 23);
            btn_limpar.TabIndex = 7;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(442, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 8;
            button1.Text = "Voltar para o Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lista2_ex03_poligonos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_limpar);
            Controls.Add(btn_sair);
            Controls.Add(btn_enviar);
            Controls.Add(txt_medida);
            Controls.Add(txt_lados);
            Controls.Add(lbl_medida);
            Controls.Add(lbl_lados);
            Controls.Add(lbl_title);
            Name = "lista2_ex03_poligonos";
            Text = "lista2_ex03_poligonos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private Label lbl_lados;
        private Label lbl_medida;
        private TextBox txt_lados;
        private TextBox txt_medida;
        private Button btn_enviar;
        private Button btn_sair;
        private Button btn_limpar;
        private Button button1;
    }
}