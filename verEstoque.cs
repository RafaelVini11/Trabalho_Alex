using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Alex.infraestrutura;

namespace Trabalho_Alex
{
    public partial class verEstoque : Form
    {
        DBconnection bancoDeDados;
        public verEstoque()
        {
            InitializeComponent();
            bancoDeDados = new DBconnection();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                string query = "SELECT id_produto, nome, preco, quantidade FROM produto";
                using (var chamar = new NpgsqlDataAdapter(query, bancoDeDados.Connection))
                {
                    DataTable tabelaData = new DataTable();
                    chamar.Fill(tabelaData);
                    dataGridView1.DataSource = tabelaData;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("erro ao carregar produto" + ex.Message);

            }

        }

        private void Voltar_Click(object sender, EventArgs e)
        {


            Form1 formsPrincial = new Form1();
            formsPrincial.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botaoAtualizar_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void botaoAumentar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && int.TryParse(textBox1.Text, out int qtd))
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_produto"].Value);
                AtualizarQtd(id, qtd);

            }
            else
            {
                MessageBox.Show("Escolha um produto e informe uma quantidade real.");
            }
        }

        private void AtualizarQtd(int id, int valor)
        {
            try
            {
                string sql;
                if (valor > 0)
                {
                    sql = "UPDATE produto SET quantidade = quantidade + @valor WHERE id_produto =@id";
                }
                else
                {
                    sql = "UPDATE produto SET quantidade = quantidade + @valor WHERE id_produto = @id AND quantidade +@valor >=0";

                }
                using (var chamar = new NpgsqlCommand(sql, bancoDeDados.Connection))
                {
                    chamar.Parameters.AddWithValue("@valor", valor);
                    chamar.Parameters.AddWithValue("@id", id);
                    chamar.ExecuteNonQuery();
                }
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar atualizar " + ex.Message);

            }

        }

        private void botaoDiminuir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && int.TryParse(textBox1.Text, out int qtd))
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_produto"].Value);
                AtualizarQtd(id, -qtd);
            }
            else
            {
                MessageBox.Show("Selecione um produto e informe uma quantidade válida.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_produto"].Value);

                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que vai excluir" ,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
                if (resultado == DialogResult.Yes)
                {
                    ExcluirProduto(id);
                }
                else {
                    MessageBox.Show("OKbl");
                }

            }
        }


        private void ExcluirProduto(int id) {
            try
            {
                string sql = "DELETE FROM produto WHERE id_produto = @id";
                using (var excluir = new NpgsqlCommand(sql, bancoDeDados.Connection))
                {
                    excluir.Parameters.AddWithValue("@id", id);
                    excluir.ExecuteNonQuery();
                }
                MessageBox.Show("Item excluido");
                CarregarProdutos();
            }
            catch (Exception ex){
                MessageBox.Show("Erro ao tentar excluir o intem " + ex.Message);
            }
        }

    }
}
