namespace Exercicios
{
    partial class menu
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
            lbl_lista1 = new Label();
            lbl_lista2 = new Label();
            btn_notas = new Button();
            btn_imc = new Button();
            btn_idadenadadores = new Button();
            btn_4numeros = new Button();
            btn_ordemcrescente = new Button();
            btn_poligonos = new Button();
            btn_triangulos = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Location = new Point(302, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(138, 15);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "SELECIONE O EXERCÍCIO";
            // 
            // lbl_lista1
            // 
            lbl_lista1.AutoSize = true;
            lbl_lista1.Location = new Point(341, 33);
            lbl_lista1.Name = "lbl_lista1";
            lbl_lista1.Size = new Size(40, 15);
            lbl_lista1.TabIndex = 1;
            lbl_lista1.Text = "Lista 1";
            // 
            // lbl_lista2
            // 
            lbl_lista2.AutoSize = true;
            lbl_lista2.Location = new Point(341, 186);
            lbl_lista2.Name = "lbl_lista2";
            lbl_lista2.Size = new Size(40, 15);
            lbl_lista2.TabIndex = 2;
            lbl_lista2.Text = "Lista 2";
            // 
            // btn_notas
            // 
            btn_notas.Location = new Point(319, 51);
            btn_notas.Name = "btn_notas";
            btn_notas.Size = new Size(85, 36);
            btn_notas.TabIndex = 3;
            btn_notas.Text = "Ex00 - Notas";
            btn_notas.UseVisualStyleBackColor = true;
            btn_notas.Click += btn_notas_Click;
            // 
            // btn_imc
            // 
            btn_imc.Location = new Point(319, 93);
            btn_imc.Name = "btn_imc";
            btn_imc.Size = new Size(85, 36);
            btn_imc.TabIndex = 4;
            btn_imc.Text = "Ex01 - IMC";
            btn_imc.UseVisualStyleBackColor = true;
            btn_imc.Click += btn_imc_Click;
            // 
            // btn_idadenadadores
            // 
            btn_idadenadadores.Location = new Point(319, 135);
            btn_idadenadadores.Name = "btn_idadenadadores";
            btn_idadenadadores.Size = new Size(85, 48);
            btn_idadenadadores.TabIndex = 5;
            btn_idadenadadores.Text = "Ex02 - Idade Nadadores";
            btn_idadenadadores.UseVisualStyleBackColor = true;
            btn_idadenadadores.Click += btn_idadenadadores_Click;
            // 
            // btn_4numeros
            // 
            btn_4numeros.Location = new Point(319, 214);
            btn_4numeros.Name = "btn_4numeros";
            btn_4numeros.Size = new Size(85, 40);
            btn_4numeros.TabIndex = 6;
            btn_4numeros.Text = "Ex01 - 4 Números";
            btn_4numeros.UseVisualStyleBackColor = true;
            btn_4numeros.Click += btn_4numeros_Click;
            // 
            // btn_ordemcrescente
            // 
            btn_ordemcrescente.Location = new Point(319, 260);
            btn_ordemcrescente.Name = "btn_ordemcrescente";
            btn_ordemcrescente.Size = new Size(85, 53);
            btn_ordemcrescente.TabIndex = 7;
            btn_ordemcrescente.Text = "Ex02 - Ordem Crescente";
            btn_ordemcrescente.UseVisualStyleBackColor = true;
            btn_ordemcrescente.Click += btn_ordemcrescente_Click;
            // 
            // btn_poligonos
            // 
            btn_poligonos.Location = new Point(319, 319);
            btn_poligonos.Name = "btn_poligonos";
            btn_poligonos.Size = new Size(85, 49);
            btn_poligonos.TabIndex = 8;
            btn_poligonos.Text = "Ex03 - Polígonos";
            btn_poligonos.UseVisualStyleBackColor = true;
            btn_poligonos.Click += btn_poligonos_Click;
            // 
            // btn_triangulos
            // 
            btn_triangulos.Location = new Point(319, 374);
            btn_triangulos.Name = "btn_triangulos";
            btn_triangulos.Size = new Size(85, 45);
            btn_triangulos.TabIndex = 9;
            btn_triangulos.Text = "Ex04 - Triângulos";
            btn_triangulos.UseVisualStyleBackColor = true;
            btn_triangulos.Click += btn_triangulos_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_triangulos);
            Controls.Add(btn_poligonos);
            Controls.Add(btn_ordemcrescente);
            Controls.Add(btn_4numeros);
            Controls.Add(btn_idadenadadores);
            Controls.Add(btn_imc);
            Controls.Add(btn_notas);
            Controls.Add(lbl_lista2);
            Controls.Add(lbl_lista1);
            Controls.Add(lbl_titulo);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_lista1;
        private Label lbl_lista2;
        private Button btn_notas;
        private Button btn_imc;
        private Button btn_idadenadadores;
        private Button btn_4numeros;
        private Button btn_ordemcrescente;
        private Button btn_poligonos;
        private Button btn_triangulos;
    }
}