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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {           
            var codigo = txtBxCodigo.Text;
            var nome = txtBxNome.Text;
            var peso = Convert.ToDouble(maskedTextBoxPeso.Text);
            var precoCompra = Convert.ToDouble(maskedTextBoxPrecoCompra.Text);
            var precoVenda= Convert.ToDouble(maskedTextBoxPrecoVenda.Text);
            var quantidade = Convert.ToInt32(numericUpDownQtdeProdutos.Value);

            var produto = new Produto(codigo, nome, peso, precoCompra, precoVenda, quantidade);

            Produto.inserir(produto);

            MessageBox.Show("Cadastro concluído com sucesso", "Aviso");

            Close();
        }
    }
}
