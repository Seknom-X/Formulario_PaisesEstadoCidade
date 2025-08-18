﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoELP4Paises
{
    internal class Interfaces
    {
        FrmConsPaises oFrmConsPaises;
        FrmConsEstados oFrmConsEstados;
        FrmConsCidades oFrmConsCidades;
        
        FrmCadPaises oFrmCadPaises;
        FrmCadEstados oFrmCadEstados;
        FrmCadCidades oFrmCadCidades;

        public Interfaces()
        {
            oFrmConsPaises = new FrmConsPaises();
            oFrmConsEstados = new FrmConsEstados();
            oFrmConsCidades = new FrmConsCidades();
            
            oFrmCadPaises = new FrmCadPaises();
            oFrmCadEstados = new FrmCadEstados();
            oFrmCadCidades = new FrmCadCidades();

            oFrmConsPaises.setFrmCadastro(oFrmCadPaises);
            oFrmConsEstados.setFrmCadastro(oFrmCadEstados);
            oFrmConsCidades.setFrmCadastro(oFrmCadCidades);
        }

        public void PecaPaises(object obj, object ctrl)
        {
            oFrmConsPaises.ConhecaObj(obj, ctrl);
            oFrmConsPaises.ShowDialog();
        }

        public void PecaEstados(object obj, object ctrl)
        {
            oFrmConsEstados.ConhecaObj(obj, ctrl);
            oFrmConsEstados.ShowDialog();
        }

        public void PecaCidades(object obj, object ctrl)
        {
            oFrmConsCidades.ConhecaObj(obj, ctrl);
            oFrmConsCidades.ShowDialog();
        }
    }
}
