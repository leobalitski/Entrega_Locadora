using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Locadora_LeonardoBF
{
    partial class ListaConsultaCliente : Form
    {
        Label lbl_ListaCliente;
        Library.ListView lv_ListaClientes;
        Library.Button btn_Alterar;
        Library.Button btn_Deletar;
        Library.Button btn_Consulta;
        Library.Button btn_Sair;
        Form parent;

        // Dados consulta locação
        public void InitializeComponent(Form parent)
        {
            this.Text = "Lista de Clientes";
            this.Size = new Size(420, 430);
            this.BackColor = Color.Gray;
            this.parent = parent;

            this.lbl_ListaCliente = new Label();
            this.lbl_ListaCliente.Text = "Lista de Clientes :";
            this.lbl_ListaCliente.Location = new Point(20, 10);
            this.lbl_ListaCliente.AutoSize = true;
            this.Controls.Add(lbl_ListaCliente);

            this.lv_ListaClientes = new Library.ListView();
            this.lv_ListaClientes.Location = new Point(20, 40);
            this.lv_ListaClientes.Size = new Size(360, 220);

            ListViewItem clientes = new ListViewItem();
            foreach (ClienteModels cliente in ClienteController.GetClientes())
            {
                ListViewItem lv_ListaCliente = new ListViewItem(cliente.IdCliente.ToString());
                lv_ListaCliente.SubItems.Add(cliente.NomeCliente);
                lv_ListaCliente.SubItems.Add(cliente.DataNascimento);
                lv_ListaCliente.SubItems.Add(cliente.CpfCliente);
                lv_ListaCliente.SubItems.Add(cliente.DiasDevolucao.ToString());
                lv_ListaClientes.Items.Add(lv_ListaCliente);
            }
            this.lv_ListaClientes.MultiSelect = false;
            this.lv_ListaClientes.Columns.Add("ID", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            this.lv_ListaClientes.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("CPF", -2, HorizontalAlignment.Center);
            this.lv_ListaClientes.Columns.Add("Dias Devolução", -2, HorizontalAlignment.Center);
            this.Controls.Add(lv_ListaClientes);

            this.btn_Alterar = new Library.Button();
            this.btn_Alterar.Text = "ALTERAR";
            this.btn_Alterar.Location = new Point(30, 280);
            this.btn_Alterar.Size = new Size(150, 25);
            this.btn_Alterar.BackColor = Color.Black;
            this.btn_Alterar.ForeColor = Color.White;
            this.btn_Alterar.Click += new EventHandler(this.btn_UpdateClienteClick);
            this.Controls.Add(btn_Alterar);

            this.btn_Deletar = new Library.Button();
            this.btn_Deletar.Text = "DELETAR";
            this.btn_Deletar.Location = new Point(220, 280);
            this.btn_Deletar.Size = new Size(150, 25);
            this.btn_Deletar.BackColor = Color.Black;
            this.btn_Deletar.ForeColor = Color.White;
            this.btn_Deletar.Click += new EventHandler(this.btn_DeleteClienteClick);
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