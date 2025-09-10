namespace Trabalho_Alex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VerProdutos_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
           
            CadastrarProdutoForms telaCadastro = new CadastrarProdutoForms();
            telaCadastro.ShowDialog();
           
        }
    }
}
