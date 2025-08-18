﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoELP4Paises
{
    public partial class FrmConsEstados : ProjetoELP4Paises.frmConsultas
    {
        FrmCadEstados oFrmCadEstados;
        Estados oEstado;
        Controller aCtrl; 
        
        public FrmConsEstados()
        {
            InitializeComponent();
        }

        protected override void Pesquisar()
        {
        }

        protected override void Incluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado,aCtrl);
            oFrmCadEstados.ShowDialog();
        }

        protected override void Alterar()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
        }

        protected override void Excluir()
        {
            oFrmCadEstados.ConhecaObj(oEstado, aCtrl);
            oFrmCadEstados.ShowDialog();
        }

        public override void setFrmCadastro(object obj)
        {
            if (obj != null)
                oFrmCadEstados = (FrmCadEstados)obj;
        }

        public override void ConhecaObj(object obj, object ctrl)
        {
            if (obj != null)
                oEstado = (Estados)obj;
            if (ctrl != null)
                aCtrl = (Controller)ctrl;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

    }
}
