using System;
using System.Drawing;
using System.Windows.Forms;

namespace Locadora_LeonardoBF
{
    partial class CadastroFilme : Form
    {
        Label lbl_Titulo;
        Label lbl_DataLancamento;
        Label lbl_Sinopse;
        Label lbl_Valor;
        Label lbl_Estoque;
        TextBox txt_Titulo;
        MaskedTextBox mtxt_DataLancamento;
        RichTextBox rtxt_Sinopse;
        ComboBox cb_Valor;
        NumericUpDown num_Estoque;
        Library.Button btn_Confirmar;
        Library.Button btn_Cancelar;
        Form parent;

        public void InitializeComponent(Form parent, bool isUpdate)
        {
            this.Text = "Cadastro de Filme";
            this.Size = new Size(400, 450);
            this.BackColor = Color.Gray;
            this.parent = parent;

            if (isUpdate)
            {
                this.Load += new EventHandler(this.LoadForm);
            }

            this.lbl_Titulo = new Label();
            this.lbl_Titulo.Text = "Título :";
            this.lbl_Titulo.Location = new Point(40, 10);
            this.lbl_Titulo.AutoSize = true;
            this.Controls.Add(lbl_Titulo);

            this.txt_Titulo = new TextBox();
            this.txt_Titulo.Location = new Point(40, 30);
            this.txt_Titulo.Size = new Size(300, 30);
            this.Controls.Add(txt_Titulo);

            this.lbl_DataLancamento = new Label();
            this.lbl_DataLancamento.Text = "Data de Lançamento :";
            this.lbl_DataLancamento.Location = new Point(40, 70);
            this.lbl_DataLancamento.AutoSize = true;
            this.Controls.Add(lbl_DataLancamento);

            this.mtxt_DataLancamento = new MaskedTextBox();
            this.mtxt_DataLancamento.Mask = " 00 / 00 / 0000 ";
            this.mtxt_DataLancamento.Location = new Point(40, 90);
            this.mtxt_DataLancamento.Size = new Size(200, 30);
            this.Controls.Add(mtxt_DataLancamento);

            this.lbl_Sinopse = new Label();
            this.lbl_Sinopse.Text = "Sinopse :";
            this.lbl_Sinopse.Location = new Point(40, 130);
            this.lbl_Sinopse.AutoSize = true;
            this.Controls.Add(lbl_Sinopse);

            this.rtxt_Sinopse = new RichTextBox();
            this.rtxt_Sinopse.Location = new Point(40, 150);
            this.rtxt_Sinopse.Size = new Size(300, 50);
            this.Controls.Add(rtxt_Sinopse);

            this.lbl_Valor = new Label();
            this.lbl_Valor.Text = "Valor da Locação :";
            this.lbl_Valor.Location = new Point(40, 220);
            this.lbl_Valor.AutoSize = true;
            this.Controls.Add(lbl_Valor);

            this.cb_Valor = new ComboBox();
            this.cb_Valor.Location = new Point(40, 240);
            this.cb_Valor.Size = new Size(200, 30);
            this.cb_Valor.Items.Add("0,99");
            this.cb_Valor.Items.Add("1,99");
            this.cb_Valor.Items.Add("2,99");
            this.cb_Valor.Items.Add("3,99");
            this.cb_Valor.Items.Add("4,99");
            //this.cb_Valor.AutoCompleteMode = AutoCompleteMode.Append;
            this.Controls.Add(cb_Valor);

            this.lbl_Estoque = new Label();
            this.lbl_Estoque.Text = "Quantidade :";
            this.lbl_Estoque.Location = new Point(40, 280);
            this.lbl_Estoque.AutoSize = true;
            this.Controls.Add(lbl_Estoque);

            this.num_Estoque = new NumericUpDown();
            this.num_Estoque.Location = new Point(40, 300);
            this.num_Estoque.Size = new Size(50, 20);
            this.num_Estoque.Minimum = 1;
            this.num_Estoque.Maximum = 100;
            this.Controls.Add(num_Estoque);

            this.btn_Confirmar = new Library.Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(90, 340);
            this.btn_Confirmar.Click += new EventHandler(this.btn_ConfirmarClick);
            this.Controls.Add(btn_Confirmar);

            this.btn_Cancelar = new Library.Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(90, 370);
            this.btn_Cancelar.Click += new EventHandler(this.btn_CancelarClick);
            this.Controls.Add(btn_Cancelar);
        }
    }
}