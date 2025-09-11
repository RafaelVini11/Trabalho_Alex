using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Alex.infraestrutura;

namespace Trabalho_Alex
{
    public partial class CadastrarProdutoForms : Form
    {
        public CadastrarProdutoForms()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {

            Form1 formsPrincial = new Form1();
            formsPrincial.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textoPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {

                string nome = textoNome.Text;
                decimal preco = decimal.Parse(textoPreco.Text);
                int quantidade = int.Parse(textoQuantidade.Text);

                DBconnection bancoDados = new DBconnection();

                String queryBanco = "INSERT INTO produto (nome,preco,quantidade) VALUES (@nome,@preco,@quantidade)";

                using (var comando = new NpgsqlCommand(queryBanco, bancoDados.Connection))
                {
                    comando.Parameters.AddWithValue("nome", textoNome.Text);
                    comando.Parameters.AddWithValue("preco", preco);
                    comando.Parameters.AddWithValue("quantidade", quantidade);

                    comando.ExecuteNonQuery();

                }

                MessageBox.Show("Produto cadastrado");
                textoNome.Clear();
                textoPreco.Clear();
                textoQuantidade.Clear();

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao salvar" + ex.Message);
                
            }
        }

        private void textoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
