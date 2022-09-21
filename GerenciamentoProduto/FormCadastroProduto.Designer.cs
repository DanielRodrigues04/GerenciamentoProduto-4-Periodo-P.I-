namespace GerenciamentoProduto
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxNome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleFinanceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPrecoCompra = new System.Windows.Forms.Label();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBxCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxPrecoCompra = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecoVenda = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDownQtdeProdutos = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.maskedTextBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtdeProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxNome
            // 
            this.txtBxNome.Location = new System.Drawing.Point(60, 61);
            this.txtBxNome.Name = "txtBxNome";
            this.txtBxNome.Size = new System.Drawing.Size(177, 20);
            this.txtBxNome.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(249, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.editarProdutoToolStripMenuItem,
            this.excluirProdutoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo produto";
            // 
            // editarProdutoToolStripMenuItem
            // 
            this.editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            this.editarProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editarProdutoToolStripMenuItem.Text = "Editar produto";
            // 
            // excluirProdutoToolStripMenuItem
            // 
            this.excluirProdutoToolStripMenuItem.Name = "excluirProdutoToolStripMenuItem";
            this.excluirProdutoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.excluirProdutoToolStripMenuItem.Text = "Excluir produto";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeEstoqueToolStripMenuItem,
            this.controleFinanceiroToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // controleDeEstoqueToolStripMenuItem
            // 
            this.controleDeEstoqueToolStripMenuItem.Name = "controleDeEstoqueToolStripMenuItem";
            this.controleDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controleDeEstoqueToolStripMenuItem.Text = "Controle de estoque";
            // 
            // controleFinanceiroToolStripMenuItem
            // 
            this.controleFinanceiroToolStripMenuItem.Name = "controleFinanceiroToolStripMenuItem";
            this.controleFinanceiroToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controleFinanceiroToolStripMenuItem.Text = "Controle financeiro";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // lblPrecoCompra
            // 
            this.lblPrecoCompra.AutoSize = true;
            this.lblPrecoCompra.Location = new System.Drawing.Point(12, 178);
            this.lblPrecoCompra.Name = "lblPrecoCompra";
            this.lblPrecoCompra.Size = new System.Drawing.Size(77, 13);
            this.lblPrecoCompra.TabIndex = 5;
            this.lblPrecoCompra.Text = "Preço Compra:";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Location = new System.Drawing.Point(12, 216);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(72, 13);
            this.lblPrecoVenda.TabIndex = 7;
            this.lblPrecoVenda.Text = "Preço Venda:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 100);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código:";
            // 
            // txtBxCodigo
            // 
            this.txtBxCodigo.Location = new System.Drawing.Point(60, 97);
            this.txtBxCodigo.Name = "txtBxCodigo";
            this.txtBxCodigo.Size = new System.Drawing.Size(177, 20);
            this.txtBxCodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Peso:";
            // 
            // maskedTextBoxPrecoCompra
            // 
            this.maskedTextBoxPrecoCompra.Location = new System.Drawing.Point(95, 175);
            this.maskedTextBoxPrecoCompra.Name = "maskedTextBoxPrecoCompra";
            this.maskedTextBoxPrecoCompra.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBoxPrecoCompra.TabIndex = 3;
            // 
            // maskedTextBoxPrecoVenda
            // 
            this.maskedTextBoxPrecoVenda.Location = new System.Drawing.Point(95, 213);
            this.maskedTextBoxPrecoVenda.Name = "maskedTextBoxPrecoVenda";
            this.maskedTextBoxPrecoVenda.Size = new System.Drawing.Size(142, 20);
            this.maskedTextBoxPrecoVenda.TabIndex = 4;
            // 
            // numericUpDownQtdeProdutos
            // 
            this.numericUpDownQtdeProdutos.Location = new System.Drawing.Point(95, 249);
            this.numericUpDownQtdeProdutos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQtdeProdutos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQtdeProdutos.Name = "numericUpDownQtdeProdutos";
            this.numericUpDownQtdeProdutos.Size = new System.Drawing.Size(142, 20);
            this.numericUpDownQtdeProdutos.TabIndex = 5;
            this.numericUpDownQtdeProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQtdeProdutos.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownQtdeProdutos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 251);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lblQuantidade.TabIndex = 17;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // maskedTextBoxPeso
            // 
            this.maskedTextBoxPeso.Location = new System.Drawing.Point(60, 137);
            this.maskedTextBoxPeso.Name = "maskedTextBoxPeso";
            this.maskedTextBoxPeso.Size = new System.Drawing.Size(177, 20);
            this.maskedTextBoxPeso.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(15, 293);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(222, 43);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 345);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.maskedTextBoxPeso);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.numericUpDownQtdeProdutos);
            this.Controls.Add(this.maskedTextBoxPrecoVenda);
            this.Controls.Add(this.maskedTextBoxPrecoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBxCodigo);
            this.Controls.Add(this.lblPrecoVenda);
            this.Controls.Add(this.lblPrecoCompra);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtBxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroProduto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtdeProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxNome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleFinanceiroToolStripMenuItem;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrecoCompra;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBxCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoCompra;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoVenda;
        private System.Windows.Forms.NumericUpDown numericUpDownQtdeProdutos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPeso;
        private System.Windows.Forms.Button btnCadastrar;
    }
}