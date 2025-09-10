using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Alex
{
    class Produto
    {
        private int id;
        private string nome;
        private decimal preco;
        private int quantidade;

        public int GetId() {
            return id;
        }
        public void SetId(int value) {
            id = value;
        }

        public string GetNome() {
            return nome;
        }
        public void SetNome(String value) {
            nome = value;
             }

        public decimal GetPreco() {
            return preco;
        }
        public void SetPreco(decimal value) {
            preco = value;
        }

        public int GetQuantidade() {
            return quantidade;
        }

        public void SetQuantidade(int value) {
            quantidade = value;
        }

    }
}
