namespace Trabalho_Alex
{
    partial class Form1
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
            label1 = new Label();
            VerProdutos = new Button();
            Cadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(279, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 54);
            label1.TabIndex = 0;
            label1.Text = "ESTOQUE";
            label1.Click += label1_Click;
            // 
            // VerProdutos
            // 
            VerProdutos.Location = new Point(279, 101);
            VerProdutos.Name = "VerProdutos";
            VerProdutos.Size = new Size(189, 85);
            VerProdutos.TabIndex = 1;
            VerProdutos.Text = "Verificar Produtos";
            VerProdutos.UseVisualStyleBackColor = true;
            VerProdutos.Click += VerProdutos_Click;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(279, 257);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(190, 86);
            Cadastrar.TabIndex = 2;
            Cadastrar.Text = "Cadastrar Produto";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastrar);
            Controls.Add(VerProdutos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button VerProdutos;
        private Button Cadastrar;
    }
}
