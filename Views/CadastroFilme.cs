using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    public partial class CadastroFilme : Form
    {
        FilmeModels filme;
        public CadastroFilme(Form parent, int id = 0)
        {
            try
            {
                filme = FilmeController.GetFilme(id);
            }
            catch
            {

            }
            InitializeComponent(parent, id > 0);
        }

        private void btn_ConfirmarClick(object sender, EventArgs e)
        {
            try
            {
                if ((txt_Titulo.Text != string.Empty)
                && (mtxt_DataLancamento.Text != string.Empty)
                && (rtxt_Sinopse.Text != string.Empty)
                && (cb_Valor.Text != string.Empty)
                && (num_Estoque.Value != 0))
                {
                    if (filme == null)
                    {
                        FilmeController.CadastrarFilme(
                            txt_Titulo.Text,
                            mtxt_DataLancamento.Text,
                            rtxt_Sinopse.Text,
                            cb_Valor.Text == "R$ 0.99"
                            ? 0.99
                                : cb_Valor.Text == "R$ 1.99"
                                ? 1.99
                                    : cb_Valor.Text == "R$ 2.99"
                                    ? 2.99
                                    : cb_Valor.Text == "R$ 3.99"
                                        ? 3.99
                                        : cb_Valor.Text == "R$ 4.99"
                                            ? 4.99
                                            : 5.99,
                            (int)num_Estoque.Value
                        );
                        MessageBox.Show("Cadastrado!");

                    }
                    else
                    {
                        FilmeController.AlterarFilme(
                            filme.IdFilme,
                            txt_Titulo.Text,
                            mtxt_DataLancamento.Text,
                            rtxt_Sinopse.Text,
                            cb_Valor.Text == "R$ 0.99"
                            ? 0.99
                                : cb_Valor.Text == "R$ 1.99"
                                ? 1.99
                                    : cb_Valor.Text == "R$ 2.99"
                                    ? 2.99
                                        : cb_Valor.Text == "R$ 3.99"
                                        ? 3.99
                                            : 4.99,
                            (int)num_Estoque.Value
                         );
                        MessageBox.Show("Alterado");
                    }
                    this.Close();
                    this.parent.Show();
                }
                else
                {
                    MessageBox.Show("Preencha Todos Os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha Todos Os Campos!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.txt_Titulo.Text = filme.Titulo;
            this.mtxt_DataLancamento.Text = filme.DataLancamento;
            this.rtxt_Sinopse.Text = filme.Sinopse;
            this.cb_Valor.SelectedValue = filme.ValorLocacaoFilme;
            this.num_Estoque.Value = filme.EstoqueFilme;
        }
    }
}