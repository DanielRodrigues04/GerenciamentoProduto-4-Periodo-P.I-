using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoProduto
{
    public partial class FormBemVindo : Form
    {

        static String caminhoDB = @"C:\Users\2018101836\Downloads\GerenciamentoProduto\BancoDeDados\banco.txt";

        public FormBemVindo()
        {
            InitializeComponent();
        }

        private List<Produto> carregarProdutosDB()
        {
            List<Produto> produtos = new List<Produto>();
            var linhas = File.ReadAllLines(caminhoDB).ToList();

            //a fazer, ver como remover o primeiro elemento de uma lista
            linhas.ForEach(linha => {
                var campos = linha.Split(';');
                var codigo = campos[0];
                var nome = campos[1];
                var precoCompra = Double.Parse(campos[2]);
                var precoVenda = Double.Parse(campos[3]);
                var peso = Double.Parse(campos[4]);
                var quantidade = int.Parse(campos[5]);

                var produto = new Produto(
                   codigo,
                   nome,
                   peso,
                   precoCompra,
                   precoVenda,
                   quantidade);

                produtos.Add(produto);
            });

            return produtos;
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaCadastro = new FormCadastroProduto();

            var produtos = carregarProdutosDB();

            telaCadastro.ShowDialog();
        }

        private void excluirProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaExclusao= new FormExclusaoProduto();

            telaExclusao.ShowDialog();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaEditar= new FormEditarProduto();

            telaEditar.ShowDialog();
        }
    }
}
