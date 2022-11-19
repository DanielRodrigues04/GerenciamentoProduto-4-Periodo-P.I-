using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoProduto
{
    class Produto
    {
        string codigo;
        string nome;
        double peso;
        double precoCompra;
        double precoVenda;
        int quantidade;

        private static string dirArquivo = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.ToString()) + "/banco.txt";

        public static void exibirProdutos(ListView listView)
        {
            Cursor.Current = Cursors.WaitCursor;

            listView.Clear();
            listView.View = View.Details;
            listView.LabelEdit = false;
            listView.AllowColumnReorder = false;
            listView.FullRowSelect = false;
            listView.GridLines = true;

            listView.Columns.Add("Código", 70, HorizontalAlignment.Left);
            listView.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            listView.Columns.Add("Peso", 50, HorizontalAlignment.Left);
            listView.Columns.Add("Preço compra", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Preço venda", 100, HorizontalAlignment.Left);
            listView.Columns.Add("Quantidade", 70, HorizontalAlignment.Left);

            buscarProdutos()
                .OrderBy(p => p.codigo)
                .ToList()
                .ForEach(produto => {
                    var listViewItem = new ListViewItem(produto.codigo);
                    listViewItem.SubItems.Add(produto.nome);
                    listViewItem.SubItems.Add(produto.peso.ToString());
                    listViewItem.SubItems.Add(produto.precoCompra.ToString());
                    listViewItem.SubItems.Add(produto.precoVenda.ToString());
                    listViewItem.SubItems.Add(produto.quantidade.ToString());
                    listView.Items.Add(listViewItem);
                });

            Cursor.Current = Cursors.Default;
        }

        public Produto(string codigo, string nome, double peso, double precoCompra, double precoVenda, int quantidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.peso = peso;
            this.precoCompra = precoCompra;
            this.precoVenda = precoVenda;
            this.quantidade = quantidade;
        }

        private static Produto montarProduto(string linhaBanco)
        {
            var campos = linhaBanco.Split(';');

            var codigo = campos[0];
            var nome = campos[1];
            var peso = Convert.ToDouble(campos[2]);
            var precoCompra = Convert.ToDouble(campos[3]);
            var precoVenda = Convert.ToDouble(campos[4]);
            var quantidade = Convert.ToInt32(campos[5]);

            return new Produto(codigo, nome, peso, precoCompra, precoVenda, quantidade);
        }

        private static string montarLinhaBanco(Produto produto)
        {
            return produto.codigo + ";" + produto.nome + ";" + produto.peso + ";" + produto.precoCompra + ";" + produto.precoVenda + ";" + produto.quantidade;
        }

        public static List<Produto> buscarProdutos()
        {
            var produtos = new List<Produto>();
            var linhasBanco = File.ReadAllLines(dirArquivo).ToList();

            //Remover cabeçalho
            linhasBanco.RemoveAt(0);

            linhasBanco.ForEach(linhaBanco => produtos.Add(montarProduto(linhaBanco)));

            return produtos;
        }

        public static Produto buscar(String codigo)
        {
            var produtos = buscarProdutos();
            var produto = produtos.Find(p => p.codigo == codigo);

            return produto;
        }

        public static void inserir(Produto produto)
        {
            var linhasBanco = File.ReadAllLines(dirArquivo).ToList();
            var novaLinha = montarLinhaBanco(produto);

            linhasBanco.Insert(linhasBanco.Count, novaLinha);

            File.WriteAllLines(dirArquivo, linhasBanco);  
        }

        public static void excluir(String codigo)
        {
            var linhasBanco = File.ReadAllLines(dirArquivo).ToList();
            var novasLinhasBanco = new List<string>();

            linhasBanco.ForEach(linha =>
            {
                if (!linha.StartsWith(codigo + ";"))
                {
                    novasLinhasBanco.Add(linha);
                }
            });


            File.WriteAllLines(dirArquivo, novasLinhasBanco);
        }

        public static void atualizar(Produto novoProduto)
        {
            var novasLinhasBanco = new List<string>();
            var produtoAntigo = buscar(novoProduto.codigo);
            var produtos = buscarProdutos();

            produtos.Remove(produtoAntigo);
            produtos.Add(novoProduto);            
            produtos.ForEach(produto => novasLinhasBanco.Add(montarLinhaBanco(produto)));

            File.WriteAllLines(dirArquivo, novasLinhasBanco);
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Peso { get => peso; set => peso = value; }
        public double PrecoCompra { get => precoCompra; set => precoCompra = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
