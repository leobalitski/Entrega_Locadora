using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF

// consulta locação dia qtd filmes etc.
{
    public partial class ListaConsultaLocacao : Form
    {
        public ListaConsultaLocacao(Form parent)
        {
            InitializeComponent(parent);
        }

        public void RefreshForm()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.RefreshForm));
            }
            Application.DoEvents();
        }
        private void btn_ConsultaClick(object sender, EventArgs e)
        {
            
            int IdLocacao = Int32.Parse(this.lv_ListaLocacoes.SelectedItems[0].Text);
            LocacaoModels locacao = LocacaoController.GetLocacao(IdLocacao);
            ClienteModels cliente = ClienteController.GetCliente(locacao.IdCliente);
            MessageBox.Show(
            $"---[ Dados do Cliente ]---------------------------\n" +            
            $"Id Cliente: {locacao.IdCliente}\n" +
            $"Nome: {cliente.NomeCliente}\n" +
            $"Data de Nascimento: {cliente.DataNascimento}\n" +
            $"CPF: {cliente.CpfCliente}\n" +
            $"-------------------------------------------------------\n" +

            $"---[ Dados da Locação ]--------------------------\n" +
            $"Id Locação: {locacao.IdLocacao}\n" +
            $"Data da Locação: {locacao.DataLocacao.ToString("dd/MM/yyyy")}\n" +
            $"Data da Devolução: {locacao.CalculoDataDevol().ToString("dd/MM/yyyy")}\n" +
            $"Qtde de Filmes: {locacao.QtdeFilmes().ToString()}\n" +
            $"Valor Total: {locacao.ValorTotal().ToString("C2")}\n" +
            $"-------------------------------------------------------\n" +

            $"---[  Filmes Locados  ]----------------------------\n" +
            $"{locacao.FilmesLocados()}\n" +
            $"-------------------------------------------------------\n",
            "Consulta Locação",
            MessageBoxButtons.OK
            );
        }

        private void btn_SairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}