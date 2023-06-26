﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEGOCIO_PRESENTACION
{
    public partial class Consultar_Reci_Caja_Emple : Form
    {
        public Consultar_Reci_Caja_Emple()
        {
            InitializeComponent();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            if (txt_CodRecicaja.Text == "")
            {
                LOGICA.Clase_Recibo_Caja objmarca = new LOGICA.Clase_Recibo_Caja();
                objmarca.Consultar_Recibo_CajaG(ref Grilla_ReciCaja);
            }
            else
            {
                LOGICA.Clase_Recibo_Caja objmarca = new LOGICA.Clase_Recibo_Caja();
                objmarca.Codigo_ReciCajaM = long.Parse(txt_Cod_Cliente_ReciCaja.Text);
                objmarca.ConsultarRecibo_CajaEspecifico(ref Grilla_ReciCaja);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            LOGICA.Clase_Recibo_Caja objemple = new LOGICA.Clase_Recibo_Caja();
            objemple.Codigo_ReciCajaM = long.Parse(txt_CodRecicaja.Text);
            objemple.Codigo_Cliente_ReciCaja_FKM = long.Parse(txt_Cod_Cliente_ReciCaja.Text);
            objemple.Codigo_FactVent_ReciCaja_FKM = long.Parse(txt_Cod_FactV_ReciCaja.Text);
            objemple.Fecha_ReciCajaM = dtp_FReciCaja.Value;
            objemple.Valor_ReciCajaM = long.Parse(txt_Valor_ReciCaja.Text);
            objemple.Descripcion_ReciCajaM = txt_Descripcion_ReciCaja.Text;
            objemple.Estado_ReciCajaM = cmb_EstadoReciC.Text;
            objemple.Modificar_Recibo_Caja();
            limpiar();
        }
        private void limpiar()
        {
            txt_Cod_Cliente_ReciCaja.Clear();
            txt_Cod_FactV_ReciCaja.Clear();
            dtp_FReciCaja.Text = "";
            txt_Valor_ReciCaja.Clear();
            txt_Descripcion_ReciCaja.Clear();
            cmb_EstadoReciC.Text = "";
            txt_Cod_Cliente_ReciCaja.Focus();
        }
        
    }
}
