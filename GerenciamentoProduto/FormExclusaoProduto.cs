﻿using System;
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Produto.excluir(txtBxCodigo.Text);
        }
    }
}
