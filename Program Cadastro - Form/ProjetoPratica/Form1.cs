using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPratica
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            //criar uma lista e incluir um objeto na lista
            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dataGridViewFornecedores.DataSource = listaFornecedores;
        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {

            if (textNomeDoFornecedor.Text != string.Empty)
            {
                fornecedor.NomedoFornecedor = textNomeDoFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do Fornecedor!");
            }
            if (textEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = textEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o Endereco!");
            }
            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não digitou o nome do Contato!");
            }
            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
                MessageBox.Show("Você não digitou o Telefone!");
            }

            return fornecedor;
        }
    }
}
