using System;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
//Consulta cliente
{
    public partial class ListaConsultaCliente : Form
    {
        public ListaConsultaCliente(Form parent)
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

        private void btn_UpdateClienteClick(object sender, EventArgs e)
        {
            int IdCliente = Int32.Parse(this.lv_ListaClientes.SelectedItems[0].Text);
            CadastroCliente btn_UpdateClienteClick = new CadastroCliente(this, IdCliente);
            btn_UpdateClienteClick.Show();
        }

        private void btn_DeleteClienteClick(object sender, EventArgs e)
        {
            int IdCliente = Int32.Parse(this.lv_ListaClientes.SelectedItems[0].Text);
            DialogResult result = MessageBox.Show("Deseja Exluir Esse Cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try{
                ClienteController.DeletarCliente(IdCliente);
                this.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btn_ConsultaClick(object sender, EventArgs e)
        {
            int IdCliente = Int32.Parse(this.lv_ListaClientes.SelectedItems[0].Text);
            ClienteModels cliente = ClienteController.GetCliente(IdCliente);
            MessageBox.Show(
            $"---[ Dados do Cliente ]---------------------------\n" +  
            $"Nome: {cliente.NomeCliente}\n" +
            $"Data de Nascimento: {cliente.DataNascimento}\n" +
            $"CPF: {cliente.CpfCliente}\n" +
            $"Dias de Devolução: {cliente.DiasDevolucao}\n" +
            $"-------------------------------------------------------\n",
            "Consulta Cliente",
            MessageBoxButtons.OK
            );
        }

        private void btn_SairClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}