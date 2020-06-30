using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    partial class ListaConsultaFilme : Form
    {
        Label lbl_ListaFilmes;
        Library.ListView lv_ListaFilmes;
        Library.Button btn_Alterar;
        Library.Button btn_Deletar;
        Library.Button btn_Consulta;
        Library.Button btn_Sair;
        Form parent;

        //Lista de consulta de filmes
        public void InitializeComponent(Form parent)
        {
            this.Text = "Lista de Filmes";
            this.Size = new Size(420, 430);
            this.BackColor = Color.Gray;
            this.parent = parent;

            this.lbl_ListaFilmes = new Label();
            this.lbl_ListaFilmes.Text = "Lista de Filmes :";
            this.lbl_ListaFilmes.Location = new Point(20, 10);
            this.lbl_ListaFilmes.AutoSize = true;
            this.Controls.Add(lbl_ListaFilmes);

            this.lv_ListaFilmes = new Library.ListView();
            this.lv_ListaFilmes.Location = new Point(20, 40);
            this.lv_ListaFilmes.Size = new Size(360, 220);
            ListViewItem filmes = new ListViewItem();
            foreach (FilmeModels filme in FilmeController.GetFilmes())
            {
                ListViewItem lv_ListaFilme = new ListViewItem(filme.IdFilme.ToString());
                lv_ListaFilme.SubItems.Add(filme.Titulo);
                lv_ListaFilme.SubItems.Add(filme.DataLancamento);
                lv_ListaFilme.SubItems.Add(filme.ValorLocacaoFilme.ToString());
                lv_ListaFilme.SubItems.Add(filme.EstoqueFilme.ToString());
                lv_ListaFilme.SubItems.Add(filme.Sinopse);
                lv_ListaFilmes.Items.Add(lv_ListaFilme);
            }
            this.lv_ListaFilmes.MultiSelect = false;
            this.lv_ListaFilmes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Título", -2, HorizontalAlignment.Left);
            this.lv_ListaFilmes.Columns.Add("Data Lançamento", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Preço", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Estoque", -2, HorizontalAlignment.Center);
            this.lv_ListaFilmes.Columns.Add("Sinopse", -2, HorizontalAlignment.Left);
            this.Controls.Add(lv_ListaFilmes);

            this.btn_Alterar = new Library.Button();
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.Location = new Point(30, 280);
            this.btn_Alterar.Size = new Size(150, 25);
            this.btn_Alterar.BackColor = Color.Black;
            this.btn_Alterar.ForeColor = Color.White;
            this.btn_Alterar.Click += new EventHandler(this.btn_AlterarFilmeClick);
            this.Controls.Add(btn_Alterar);

            this.btn_Deletar = new Library.Button();
            this.btn_Deletar.Text = "DELETAR";
            this.btn_Deletar.Location = new Point(220, 280);
            this.btn_Deletar.Size = new Size(150, 25);
            this.btn_Deletar.BackColor = Color.Black;
            this.btn_Deletar.ForeColor = Color.White;
            this.btn_Deletar.Click += new EventHandler(this.btn_DeletarFilmeClick);
            this.Controls.Add(btn_Deletar);

            this.btn_Consulta = new Library.Button();
            this.btn_Consulta.Text = "CONSULTA";
            this.btn_Consulta.Location = new Point(30, 320);
            this.btn_Consulta.Size = new Size(150, 25);
            this.btn_Consulta.Click += new EventHandler(this.btn_ConsultaClick);
            this.Controls.Add(btn_Consulta);

            this.btn_Sair = new Library.Button();
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.Location = new Point(220, 320);
            this.btn_Sair.Size = new Size(150, 25);
            this.btn_Sair.Click += new EventHandler(this.btn_SairClick);
            this.Controls.Add(btn_Sair);
        }
    }
}