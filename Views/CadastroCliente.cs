using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    public partial class CadastroCliente : Form
    {
        ClienteModels cliente;
        public CadastroCliente(Form parent, int id = 0)
        {
            try
            {
                cliente = ClienteController.GetCliente(id);
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
                if ((txt_NomeCliente.Text != string.Empty)
                && (mtxt_DataNascimento.Text != string.Empty)
                && (mtxt_CpfCLiente.Text != string.Empty)
                && (cb_DiasDevolucao.Text != string.Empty))
                {
                    if (cliente == null)
                    {
                        ClienteController.CadastrarCliente(
                        txt_NomeCliente.Text,
                        mtxt_DataNascimento.Text,
                        mtxt_CpfCLiente.Text,
                        cb_DiasDevolucao.Text == "1 Dia"
                            ? 1
                            : cb_DiasDevolucao.Text == "2 Dias"
                                ? 2
                                : cb_DiasDevolucao.Text == "3 Dias"
                                    ? 3
                                    : cb_DiasDevolucao.Text == "4 Dias"
                                        ? 4
                                        : 5
                        );
                        MessageBox.Show("Cadastrado");

                    }
                    else
                    {
                        ClienteController.AlterarCliente(
                        cliente.IdCliente,
                        txt_NomeCliente.Text,
                        mtxt_DataNascimento.Text,
                        mtxt_CpfCLiente.Text,
                        cb_DiasDevolucao.Text == "1 Dia"
                            ? 1
                            : cb_DiasDevolucao.Text == "2 Dias"
                                ? 2
                                : cb_DiasDevolucao.Text == "3 Dias"
                                    ? 3
                                    : cb_DiasDevolucao.Text == "4 Dias"
                                        ? 4
                                        : 5
                        );
                        MessageBox.Show("Alterado!");
                    }
                    this.Close();
                    this.parent.Show();
                }
                else
                {
                    MessageBox.Show("Preencha os Campos!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Preencha os Campos!");
            }
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.txt_NomeCliente.Text = cliente.NomeCliente;
            this.mtxt_DataNascimento.Text = cliente.DataNascimento;
            this.mtxt_CpfCLiente.Text = cliente.CpfCliente;
            this.cb_DiasDevolucao.SelectedValue = cliente.DiasDevolucao;
        }
    }
}