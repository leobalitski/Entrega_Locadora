using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Locadora_LeonardoBF
{
    static class Program
    {
        [STAThread]
        static void Main()
        {           
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaPrincipal());        
        }
    
        public class TelaPrincipal : Form 
        {        
            Library.Button btn_CadastroCliente;
            Library.Button btn_ConsultaListaClientes;
            Library.Button btn_CadastroFilme;
            Library.Button btn_ConsultaListaFilmes;
            Library.Button btn_CadastroLocacao;
            Library.Button btn_ConsultaListaLocacoes;
            Library.Button btn_MenuSair;

            public TelaPrincipal ()
            {
                this.Text = "BlockBuster - Leonardo B. Filipini";
                this.Size = new Size(400, 390);
                this.BackColor = Color.DimGray;
           
                this.btn_CadastroCliente = new Library.Button();
                this.btn_CadastroCliente.Location = new Point(90, 30);
                this.btn_CadastroCliente.Text = "Cadastro Cliente";
                this.Controls.Add(btn_CadastroCliente);
                this.btn_CadastroCliente.Click += new EventHandler(btn_CadastroClienteClick);

                this.btn_ConsultaListaClientes = new Library.Button();
                this.btn_ConsultaListaClientes.Location = new Point(90, 60);
                this.btn_ConsultaListaClientes.Text = "Lista e Consulta Clientes";
                this.Controls.Add(btn_ConsultaListaClientes);
                this.btn_ConsultaListaClientes.Click += new EventHandler(btn_ConsultaListaClientesClick);

                this.btn_CadastroFilme = new Library.Button();
                this.btn_CadastroFilme.Location = new Point(90, 110);
                this.btn_CadastroFilme.Text = "Cadastro Filme";
                this.Controls.Add(btn_CadastroFilme);
               this.btn_CadastroFilme.Click += new EventHandler(btn_CadastroFilmeClick);

                this.btn_ConsultaListaFilmes = new Library.Button();
                this.btn_ConsultaListaFilmes.Location = new Point(90, 140);
                this.btn_ConsultaListaFilmes.Text = "Lista e Consulta Filmes";
                this.Controls.Add(btn_ConsultaListaFilmes);
                this.btn_ConsultaListaFilmes.Click += new EventHandler(btn_ConsultaListaFilmesClick);

                this.btn_CadastroLocacao = new Library.Button();
                this.btn_CadastroLocacao.Location = new Point(90, 190);
                this.btn_CadastroLocacao.Text = "Cadastro Locação";
                this.Controls.Add(btn_CadastroLocacao);
                this.btn_CadastroLocacao.Click += new EventHandler(btn_CadastroLocacaoClick);
                
                this.btn_ConsultaListaLocacoes = new Library.Button();
                this.btn_ConsultaListaLocacoes.Location = new Point(90, 220);
                this.btn_ConsultaListaLocacoes.Text = "Lista e Consulta Locações";
                this.Controls.Add(btn_ConsultaListaLocacoes);
                this.btn_ConsultaListaLocacoes.Click += new EventHandler(btn_ConsultaListaLocacoesClick);

                this.btn_MenuSair = new Library.Button();
                this.btn_MenuSair.Location = new Point(90, 270);
                this.btn_MenuSair.Size = new Size(200, 40);
                this.btn_MenuSair.Text = "SAIR";
                this.Controls.Add(btn_MenuSair);
                this.btn_MenuSair.Click += new EventHandler(btn_MenuSairClick);
            }

            private void btn_CadastroClienteClick(object sender, EventArgs e)
            {
                CadastroCliente cadastrarClienteClick = new CadastroCliente(this);
                cadastrarClienteClick.Show();
            }

            private void btn_ConsultaListaClientesClick(object sender, EventArgs e)
            {
                
                ListaConsultaCliente listaClienteClick = new ListaConsultaCliente(this);
                listaClienteClick.Show();
            }

            private void btn_CadastroFilmeClick(object sender, EventArgs e)
            {
                CadastroFilme cadastrarFilmeClick = new CadastroFilme(this);
                cadastrarFilmeClick.Show();
            }
            
            private void btn_ConsultaListaFilmesClick(object sender, EventArgs e)
            {
                ListaConsultaFilme listaFilmeClick = new ListaConsultaFilme(this);
                listaFilmeClick.Show();
            }
            
            private void btn_CadastroLocacaoClick(object sender, EventArgs e)
            {
                CadastroLocacao cadastrarLocacaoClick = new CadastroLocacao(this);
                cadastrarLocacaoClick.Show();
            }
            
            private void btn_ConsultaListaLocacoesClick(object sender, EventArgs e)
            {
                ListaConsultaLocacao listaLocacaoClick = new ListaConsultaLocacao(this);
                listaLocacaoClick.Show();
            }
            
            private void btn_MenuSairClick(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
}