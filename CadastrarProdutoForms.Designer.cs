
namespace Trabalho_Alex
{
    partial class CadastrarProdutoForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Salvar = new Button();
            textoNome = new TextBox();
            textoPreco = new TextBox();
            textoQuantidade = new TextBox();
            Voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(227, 20);
            label1.Name = "label1";
            label1.Size = new Size(315, 54);
            label1.TabIndex = 0;
            label1.Text = "Tela de Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(328, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(328, 184);
            label3.Name = "label3";
            label3.Size = new Size(83, 37);
            label3.TabIndex = 2;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(292, 273);
            label4.Name = "label4";
            label4.Size = new Size(157, 37);
            label4.TabIndex = 3;
            label4.Text = "Quantidade";
            // 
            // Salvar
            // 
            Salvar.Location = new Point(284, 371);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(165, 41);
            Salvar.TabIndex = 4;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = true;
            Salvar.Click += Salvar_Click;
            // 
            // textoNome
            // 
            textoNome.Location = new Point(249, 137);
            textoNome.Name = "textoNome";
            textoNome.Size = new Size(236, 23);
            textoNome.TabIndex = 5;
            textoNome.TextChanged += textoNome_TextChanged;
            // 
            // textoPreco
            // 
            textoPreco.Location = new Point(249, 224);
            textoPreco.Name = "textoPreco";
            textoPreco.Size = new Size(236, 23);
            textoPreco.TabIndex = 6;
            textoPreco.TextChanged += textBox2_TextChanged;
            // 
            // textoQuantidade
            // 
            textoQuantidade.Location = new Point(249, 313);
            textoQuantidade.Name = "textoQuantidade";
            textoQuantidade.Size = new Size(236, 23);
            textoQuantidade.TabIndex = 7;
            textoQuantidade.TextChanged += textoQuantidade_TextChanged;
            // 
            // Voltar
            // 
            Voltar.Location = new Point(615, 387);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(150, 38);
            Voltar.TabIndex = 8;
            Voltar.Text = "Voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // CadastrarProdutoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Voltar);
            Controls.Add(textoQuantidade);
            Controls.Add(textoPreco);
            Controls.Add(textoNome);
            Controls.Add(Salvar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarProdutoForms";
            Text = "CadastrarProdutoForms";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Salvar;
        private TextBox textoNome;
        private TextBox textoPreco;
        private TextBox textoQuantidade;
        private Button Voltar;
    }
}