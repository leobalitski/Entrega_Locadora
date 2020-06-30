using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    public partial class CadastroLocacao : Form
    {
        public CadastroLocacao(Form parent)
        {
            InitializeComponent(parent);
        }
        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((lv_ListaClientes.SelectedItems.Count > 0) && (lv_ListaFilmes.CheckedItems.Count > 0))
                {
                    string IdCliente = this.lv_ListaClientes.SelectedItems[0].Text;
                    ClienteModels cliente = ClienteController.GetCliente(Int32.Parse(IdCliente));
                    LocacaoModels locacao = LocacaoController.Add(cliente);

                    foreach (ListViewItem Filme in this.lv_ListaFilmes.CheckedItems)
                    {
                        FilmeModels filme = FilmeController.GetFilme(Int32.Parse(Filme.Text));
                        locacao.AdicionarFilme(filme);
                    }
                    MessageBox.Show("Cadastrado!");
                    this.Close();
                    this.parent.Show();
                }
                else
                {
                    MessageBox.Show("Selecione um CLiente!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Selecione os Filmes!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}