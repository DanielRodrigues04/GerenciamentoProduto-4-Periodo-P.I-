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
    public partial class FormEditarProduto : Form
    {
        public FormEditarProduto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var produto = Produto.buscar(txtBxCodigo.Text);

            Produto.atualizar(produto);
        }
    }
}
