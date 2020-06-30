using System;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_LeonardoBF
{
    partial class CadastroCliente : Form
    {
        Label lbl_Nome;
        Label lbl_DataNasc;
        Label lbl_CPF;
        Label lbl_DiasDevolucao;
        TextBox txt_NomeCliente;
        MaskedTextBox mtxt_DataNascimento;
        MaskedTextBox mtxt_CpfCLiente;
        ComboBox cb_DiasDevolucao;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            this.Text = "Cadastro de Cliente";
            this.Size = new Size(400, 420);
            this.BackColor = Color.Gray;
            this.parent = parent;

            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            this.lbl_Nome = new Label();
            this.lbl_Nome.Text = "Nome :";
            this.lbl_Nome.Location = new Point(40, 30);
            this.lbl_Nome.AutoSize = true;
            this.Controls.Add(lbl_Nome);

            this.txt_NomeCliente = new TextBox();
            this.txt_NomeCliente.Location = new Point(40, 50);
            this.txt_NomeCliente.Size = new Size(300, 30);
            this.Controls.Add(txt_NomeCliente);

            this.lbl_DataNasc = new Label();
            this.lbl_DataNasc.Text = "Data de Nascimento :";
            this.lbl_DataNasc.Location = new Point(40, 90);
            this.lbl_DataNasc.AutoSize = true;
            this.Controls.Add(lbl_DataNasc);

            this.mtxt_DataNascimento = new MaskedTextBox();
            this.mtxt_DataNascimento.Mask = " 00 / 00 / 0000 ";
            this.mtxt_DataNascimento.Location = new Point(40, 110);
            this.mtxt_DataNascimento.Size = new Size(200, 30);
            this.Controls.Add(mtxt_DataNascimento);

            this.lbl_CPF = new Label();
            this.lbl_CPF.Text = "CPF :";
            this.lbl_CPF.Location = new Point(40, 150);
            this.lbl_CPF.AutoSize = true;
            this.Controls.Add(lbl_CPF);

            this.mtxt_CpfCLiente = new MaskedTextBox();
            this.mtxt_CpfCLiente.Mask = " 000 , 000 , 000 - 00 ";
            this.mtxt_CpfCLiente.Location = new Point(40, 170);
            this.mtxt_CpfCLiente.Size = new Size(200, 30);
            this.mtxt_CpfCLiente.ReadOnly = isUpdate;
            this.Controls.Add(mtxt_CpfCLiente);

            this.lbl_DiasDevolucao = new Label();
            this.lbl_DiasDevolucao.Text = "Dias Devolução :";
            this.lbl_DiasDevolucao.Location = new Point(40, 210);
            this.lbl_DiasDevolucao.AutoSize = true;
            this.Controls.Add(lbl_DiasDevolucao);

            this.cb_DiasDevolucao = new ComboBox();
            this.cb_DiasDevolucao.Location = new Point(40, 230);
            this.cb_DiasDevolucao.Size = new Size(200, 30);
            this.cb_DiasDevolucao.Items.Add("1 dia");
            this.cb_DiasDevolucao.Items.Add("2 dias");
            this.cb_DiasDevolucao.Items.Add("3 dias");
            this.cb_DiasDevolucao.Items.Add("4 dias");
            this.cb_DiasDevolucao.Items.Add("5 dias");
            //this.cb_DiasDevolucao.AutoCompleteMode = AutoCompleteMode.Append;
            this.Controls.Add(cb_DiasDevolucao);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(90, 280);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(90, 310);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}