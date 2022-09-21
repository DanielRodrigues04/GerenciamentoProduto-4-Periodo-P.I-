using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoProduto
{
    class Produto
    {
        String codigo;
        String nome;
        Double peso;
        Double precoCompra;
        Double precoVenda;
        int quantidade;

        public Produto(string codigo, string nome, double peso, double precoCompra, double precoVenda, int quantidade)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Peso = peso;
            this.PrecoCompra = precoCompra;
            this.PrecoVenda = precoVenda;
            this.Quantidade = quantidade;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Peso { get => peso; set => peso = value; }
        public double PrecoCompra { get => precoCompra; set => precoCompra = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
