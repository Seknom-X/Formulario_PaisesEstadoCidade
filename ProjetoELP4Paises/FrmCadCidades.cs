using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmCadCidades : ProjetoELP4Paises.FrmCadastros
    {
        Cidades aCidade;
        Controller aCtrl;
        public FrmCadCidades()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
        protected override void Salvar()
        {
            //if (MessageDlg("Confirma (S/N)") == "S")
            aCidade.Codigo  = Convert.ToInt32(txtCodigo.Text);
            aCidade.Cidade  = txtCidade.Text;
            aCidade.DDD     = txtDDD.Text;
        }

        protected override void CarregaTxt()
        {
            this.txtCodigo.Text = Convert.ToString(aCidade.Codigo);
            this.txtCidade.Text = aCidade.Cidade;
            this.txtDDD.Text = aCidade.DDD;
        }

        protected override void LimparTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidade.Clear();
            this.txtDDD.Clear();
        }

        protected override void BloquearTxt()
        {
            this.txtCidade.Enabled = false;
            this.txtDDD.Enabled = false;
        }

        protected override void DesbloquearTxt()
        {
            this.txtCidade.Enabled = true;
            this.txtDDD.Enabled = true;
        }
    }
}
