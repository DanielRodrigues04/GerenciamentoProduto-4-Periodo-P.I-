using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoProduto
{
    public partial class FormExclusaoProduto : Form
    {
        public FormExclusaoProduto()
        {
            InitializeComponent();

            Produto.exibirProdutos(listViewProdutos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var codigo = txtBxCodigo.Text;
            var produto = Produto.buscar(codigo);

            if (produto != null)
            {
                Produto.excluir(txtBxCodigo.Text);

                MessageBox.Show("Produto excluído com sucesso!", "Aviso", MessageBoxButtons.OK);

                Produto.exibirProdutos(listViewProdutos);
            }
            else
            {
                MessageBox.Show("Não foi localizado produto para o código: " + codigo, "Produto não encontrado", MessageBoxButtons.OK);
            }

            

        }
    }
}
