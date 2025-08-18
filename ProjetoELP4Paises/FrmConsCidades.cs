using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmConsCidades : ProjetoELP4Paises.frmConsultas
    {
        FrmCadCidades oFrmCadCidades;
        Cidades aCidade;
        Controller aCtrl;
        public FrmConsCidades()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
        }

        protected override void Incluir()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }

        protected override void Excluir()
        {
            oFrmCadCidades.ConhecaObj(aCidade, aCtrl);
            oFrmCadCidades.ShowDialog();
        }

        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadCidades = (FrmCadCidades)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                aCidade = (Cidades)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }
    }
}
