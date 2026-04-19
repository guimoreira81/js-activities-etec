namespace Exercicios
{
    partial class lista1_ex02_idadenadadores
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
            lbl_idade = new Label();
            txt_idade = new TextBox();
            btn_enviar = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lbl_idade
            // 
            lbl_idade.AutoSize = true;
            lbl_idade.Location = new Point(88, 78);
            lbl_idade.Name = "lbl_idade";
            lbl_idade.Size = new Size(39, 15);
            lbl_idade.TabIndex = 8;
            lbl_idade.Text = "Idade:";
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(161, 75);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(100, 23);
            txt_idade.TabIndex = 6;
            txt_idade.TextChanged += txt_idade_TextChanged;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(88, 124);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(237, 58);
            btn_enviar.TabIndex = 5;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(339, 291);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 10;
            button3.Text = "Voltar para o Menu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(97, 291);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lista1_ex02_idadenadadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 521);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lbl_idade);
            Controls.Add(txt_idade);
            Controls.Add(btn_enviar);
            Name = "lista1_ex02_idadenadadores";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_idade;
        private TextBox txt_idade;
        private Button btn_enviar;
        private Button button1;
        private Button btn_mudarForm2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}