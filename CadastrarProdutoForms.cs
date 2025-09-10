using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Close();
            Form1 formsPrincial = new Form1();
            formsPrincial.Show();
        }
    }
}
