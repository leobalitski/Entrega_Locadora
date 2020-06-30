using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    public partial class ListaConsultaFilme : Form
    {
        public ListaConsultaFilme(Form parent)
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

        private void btn_AlterarFilmeClick(object sender, EventArgs e)
        {
            int IdFilme = Int32.Parse(this.lv_ListaFilmes.SelectedItems[0].Text);
            CadastroFilme btn_UpdateFilmeClick = new CadastroFilme(this, IdFilme);
            btn_UpdateFilmeClick.Show();
        }

        private void btn_DeletarFilmeClick(object sender, EventArgs e)
        {
            int IdFilme = Int32.Parse(this.lv_ListaFilmes.SelectedItems[0].Text);
            DialogResult result = MessageBox.Show("Deseja Exluir Esse Filme?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try{
                FilmeController.DeletarFilme(IdFilme);
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
            int IdFilme = Int32.Parse(this.lv_ListaFilmes.SelectedItems[0].Text);
            FilmeModels filme = FilmeController.GetFilme(IdFilme);
            MessageBox.Show(
            $"---[ Dados do Filme ]-----------------------------------------------------------------\n" +
            $"Titulo: {filme.Titulo}\n" +
            $"Data de Lançamento: {filme.DataLancamento}\n" +
            $"Sinopse: {filme.Sinopse}\n" +
            $"Valor da Locação: {filme.ValorLocacaoFilme}\n" +
            $"Quantidade: {filme.EstoqueFilme}\n" +
            $"------------------------------------------------------------------------------------------\n",
            "Consulta Filme",
            MessageBoxButtons.OK
            );
        }

        private void btn_SairClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}