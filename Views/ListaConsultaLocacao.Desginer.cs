using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    partial class ListaConsultaLocacao : Form
    {
        Label lbl_ListaLocacoes;
        Library.ListView lv_ListaLocacoes;
        Library.Button btn_Consulta;
        Library.Button btn_Sair;
        Form parent;

        // Rent data entry
        public void InitializeComponent(Form parent)
        {
            this.Text = "Lista de Locações";
            this.Size = new Size(420, 410);
            this.BackColor = Color.Gray;
            this.parent = parent;

            this.lbl_ListaLocacoes = new Label();
            this.lbl_ListaLocacoes.Text = "Lista de Locacoes :";
            this.lbl_ListaLocacoes.Location = new Point(20, 10);
            this.lbl_ListaLocacoes.AutoSize = true;
            this.Controls.Add(lbl_ListaLocacoes);

            this.lv_ListaLocacoes = new Library.ListView();
            this.lv_ListaLocacoes.Location = new Point(20, 40);
            this.lv_ListaLocacoes.Size = new Size(360, 220);
            ListViewItem locacoes = new ListViewItem();
            foreach (LocacaoModels locacao in LocacaoController.GetLocacoes())
            {
                ListViewItem lv_ListaLocacao = new ListViewItem(locacao.IdLocacao.ToString());
                ClienteModels cliente = ClienteController.GetCliente(locacao.IdCliente);
                lv_ListaLocacao.SubItems.Add(cliente.NomeCliente.ToString());
                lv_ListaLocacao.SubItems.Add(cliente.CpfCliente.ToString());
                lv_ListaLocacao.SubItems.Add(locacao.DataLocacao.ToString("dd/MM/yyyy"));
                lv_ListaLocacao.SubItems.Add(locacao.CalculoDataDevol().ToString("dd/MM/yyyy"));
                lv_ListaLocacao.SubItems.Add(locacao.QtdeFilmes().ToString());
                lv_ListaLocacao.SubItems.Add(locacao.ValorTotal().ToString("C2"));
                lv_ListaLocacoes.Items.Add(lv_ListaLocacao);
            }
            this.lv_ListaLocacoes.MultiSelect = false;
            this.lv_ListaLocacoes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaLocacoes.Columns.Add("Locatário", -2, HorizontalAlignment.Left);
            this.lv_ListaLocacoes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lv_ListaLocacoes.Columns.Add("Data Locação", -2, HorizontalAlignment.Center);
            this.lv_ListaLocacoes.Columns.Add("Data Devolução", -2, HorizontalAlignment.Center);
            this.lv_ListaLocacoes.Columns.Add("Qtde Filmes", -2, HorizontalAlignment.Center);
            this.lv_ListaLocacoes.Columns.Add("Total", -2, HorizontalAlignment.Left);
            this.Controls.Add(lv_ListaLocacoes);

            this.btn_Consulta = new Library.Button();
            this.btn_Consulta.Text = "CONSULTA";
            this.btn_Consulta.Location = new Point(100, 280);
            this.btn_Consulta.Click += new EventHandler(this.btn_ConsultaClick);
            this.Controls.Add(btn_Consulta);

            this.btn_Sair = new Library.Button();
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.Location = new Point(100, 320);
            this.btn_Sair.Click += new EventHandler(this.btn_SairClick);
            this.Controls.Add(btn_Sair);
        }
    }
}