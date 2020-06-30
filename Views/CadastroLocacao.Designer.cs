using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    partial class CadastroLocacao : Form
    {
        Label lbl_ListaCliente;
        Label lbl_ListaFilme;
        Library.ListView lv_ListaClientes;
        Library.ListView lv_ListaFilmes;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        // Entrada de dados de locaçao
        public void InitializeComponent(Form parent)
        {
            this.Text = "Cadastro da Locação";
            this.Size = new Size(420, 480);
            this.BackColor = Color.Gray;
            this.parent = parent;

            this.lbl_ListaCliente = new Label();
            this.lbl_ListaCliente.Text = "Selecione um Cliente :";
            this.lbl_ListaCliente.Location = new Point(20, 10);
            this.lbl_ListaCliente.AutoSize = true;
            this.Controls.Add(lbl_ListaCliente);

            this.lv_ListaClientes = new Library.ListView();
            this.lv_ListaClientes.Location = new Point(20, 40);
            this.lv_ListaClientes.Size = new Size(360, 120);
            ListViewItem clientes = new ListViewItem();
            foreach (ClienteModels cliente in ClienteController.GetClientes())
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.NomeCliente);
                lv_ListaCliente.SubItems.Add(cliente.DataNascimento);
                lv_ListaCliente.SubItems.Add(cliente.CpfCliente);
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.lv_ListaClientes.MultiSelect = false;
            this.lv_ListaClientes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaClientes);

            this.lbl_ListaFilme = new Label();
            this.lbl_ListaFilme.Text = "Selecione os Filmes :";
            this.lbl_ListaFilme.Location = new Point(20, 190);
            this.lbl_ListaFilme.AutoSize = true;
            this.Controls.Add(lbl_ListaFilme);

            this.lv_ListaFilmes = new Library.ListView();
            this.lv_ListaFilmes.Location = new Point(20, 220);
            this.lv_ListaFilmes.Size = new Size(360, 120);
            this.lv_ListaFilmes.CheckBoxes = true;
            ListViewItem filmes = new ListViewItem();
            foreach (FilmeModels filme in FilmeController.GetFilmes())
            {
                ListViewItem lv_ListaFilme = new ListViewItem(filme.IdFilme.ToString());
                lv_ListaFilme.SubItems.Add(filme.Titulo);
                lv_ListaFilme.SubItems.Add(filme.DataLancamento);
                lv_ListaFilme.SubItems.Add(filme.ValorLocacaoFilme.ToString());
                lv_ListaFilme.SubItems.Add(filme.EstoqueFilme.ToString());
                lv_ListaFilmes.Items.Add(lv_ListaFilme);
            }
            this.lv_ListaFilmes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Título", -2, HorizontalAlignment.Left);
            this.lv_ListaFilmes.Columns.Add("Data Lançamento", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Preço", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Estoque", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaFilmes);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(100, 360);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(100, 390);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}