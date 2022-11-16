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
        public FormBemVindo()
        {
            InitializeComponent();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaCadastro = new FormCadastroProduto();
            var produtos = Produto.buscarProdutos();

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
