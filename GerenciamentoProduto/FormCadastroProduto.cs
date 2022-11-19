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

        public FormCadastroProduto(string codigo)
        {
            InitializeComponent();

            if (codigo != "")
            {
                txtBxCodigo.Text = codigo;
                txtBxCodigo.Enabled = false;
            }           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var produtos = Produto.buscarProdutos();
            var codigo = txtBxCodigo.Text;
            var codigoJaUtilizado = produtos.Exists(p => p.Codigo == codigo); 

            if (codigoJaUtilizado)
            {
                MessageBox.Show("Já existe produto com o código: " + codigo + " no sistema", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                var nome = txtBxNome.Text;
                var peso = Convert.ToDouble(maskedTextBoxPeso.Text);
                var precoCompra = Convert.ToDouble(maskedTextBoxPrecoCompra.Text);
                var precoVenda = Convert.ToDouble(maskedTextBoxPrecoVenda.Text);
                var quantidade = Convert.ToInt32(numericUpDownQtdeProdutos.Value);

                var produto = new Produto(codigo, nome, peso, precoCompra, precoVenda, quantidade);

                if (txtBxCodigo.Visible == false)
                {
                    Produto.atualizar(produto);
                    MessageBox.Show("Cadastro atualizado com sucesso", "Aviso", MessageBoxButtons.OK);
                }
                else
                {
                    Produto.inserir(produto);
                    MessageBox.Show("Cadastro concluído com sucesso", "Aviso", MessageBoxButtons.OK);
                }

                Close();
            }

            
        }
    }
}
