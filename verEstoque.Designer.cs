namespace Trabalho_Alex
{
    partial class verEstoque
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
            Voltar = new Button();
            dataGridView1 = new DataGridView();
            botaoAtualizar = new Button();
            botaoAumentar = new Button();
            botaoDiminuir = new Button();
            textBox1 = new TextBox();
            botaoExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Voltar
            // 
            Voltar.Location = new Point(685, 403);
            Voltar.Name = "Voltar";
            Voltar.Size = new Size(75, 23);
            Voltar.TabIndex = 0;
            Voltar.Text = "voltar";
            Voltar.UseVisualStyleBackColor = true;
            Voltar.Click += Voltar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(585, 322);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // botaoAtualizar
            // 
            botaoAtualizar.Location = new Point(12, 403);
            botaoAtualizar.Name = "botaoAtualizar";
            botaoAtualizar.Size = new Size(75, 23);
            botaoAtualizar.TabIndex = 2;
            botaoAtualizar.Text = "Atualizar";
            botaoAtualizar.UseVisualStyleBackColor = true;
            botaoAtualizar.Click += botaoAtualizar_Click;
            // 
            // botaoAumentar
            // 
            botaoAumentar.Location = new Point(105, 403);
            botaoAumentar.Name = "botaoAumentar";
            botaoAumentar.Size = new Size(75, 23);
            botaoAumentar.TabIndex = 2;
            botaoAumentar.Text = "Aumentar";
            botaoAumentar.UseVisualStyleBackColor = true;
            botaoAumentar.Click += botaoAumentar_Click;
            // 
            // botaoDiminuir
            // 
            botaoDiminuir.Location = new Point(186, 403);
            botaoDiminuir.Name = "botaoDiminuir";
            botaoDiminuir.Size = new Size(75, 23);
            botaoDiminuir.TabIndex = 3;
            botaoDiminuir.Text = "Diminuir";
            botaoDiminuir.UseVisualStyleBackColor = true;
            botaoDiminuir.Click += botaoDiminuir_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(363, 400);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // botaoExcluir
            // 
            botaoExcluir.Location = new Point(267, 403);
            botaoExcluir.Name = "botaoExcluir";
            botaoExcluir.Size = new Size(75, 23);
            botaoExcluir.TabIndex = 5;
            botaoExcluir.Text = "Excluir";
            botaoExcluir.UseVisualStyleBackColor = true;
            botaoExcluir.Click += botaoExcluir_Click;
            // 
            // verEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botaoExcluir);
            Controls.Add(textBox1);
            Controls.Add(botaoDiminuir);
            Controls.Add(botaoAumentar);
            Controls.Add(botaoAtualizar);
            Controls.Add(dataGridView1);
            Controls.Add(Voltar);
            Name = "verEstoque";
            Text = "verEstoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Voltar;
        private DataGridView dataGridView1;
        private Button botaoAtualizar;
        private Button botaoAumentar;
        private Button botaoDiminuir;
        private TextBox textBox1;
        private Button botaoExcluir;
    }
}